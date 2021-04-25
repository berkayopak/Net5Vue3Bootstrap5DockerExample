namespace Net5Vue3BootstrapExample.Config
{
    public class AppConfig
    {
        public const string Section = "App";
        public ClientConfig Client { get; set; }
        public class ClientConfig
        {
            public string Path { get; set; }
            public string DistPath { get; set; }
        }
    }
}
