using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Net5Vue3BootstrapExample.Config;
using Net5Vue3BootstrapExample.Middleware;

namespace Net5Vue3BootstrapExample
{
    public class Startup
    {
        private readonly AppConfig _appConfig;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _appConfig = new AppConfig();
            Configuration.GetSection(AppConfig.Section).Bind(_appConfig);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddOptions();
            services.Configure<AppConfig>(Configuration.GetSection("App"));
            // connect vue app - middleware  
            services.AddSpaStaticFiles(options => options.RootPath = _appConfig.Client.DistPath);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // use middleware and launch server for Vue
            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = _appConfig.Client.Path;
                if (env.IsDevelopment())
                {

                    spa.UseVueDevelopmentServer();
                }
            });
        }
    }
}
