<template>
    <div class="container">
        <div class="row">
            <div class="col-sm">
                <span class="badge rounded-pill bg-primary">Primary</span>
                <span class="badge rounded-pill bg-secondary">Secondary</span>
                <span class="badge rounded-pill bg-success">Success</span>
                <span class="badge rounded-pill bg-danger">Danger</span>
                <span class="badge rounded-pill bg-warning text-dark">Warning34555</span>
                <span class="badge rounded-pill bg-info text-dark">Info2</span>
                <span class="badge rounded-pill bg-light text-dark">Light</span>
                <span class="badge rounded-pill bg-dark">Dark</span>
            </div>
            <div class="col-sm">
                <div class="alert alert-primary" role="alert">
                    A simple primary alert-check it out!
                </div>
                <div class="alert alert-secondary" role="alert">
                    A simple secondary alert-check it out!
                </div>
                <div class="alert alert-success" role="alert">
                    A simple success alert-check it out!
                </div>
                <div class="alert alert-danger" role="alert">
                    A simple danger alert-check it out!
                </div>
                <div class="alert alert-warning" role="alert">
                    A simple warning alert-check it out!
                </div>
                <div class="alert alert-info" role="alert">
                    A simple info alert-check it out!
                </div>
                <div class="alert alert-light" role="alert">
                    A simple light alert-check it out!
                </div>
                <div class="alert alert-dark" role="alert">
                    A simple dark alert-check it out!
                </div>
            </div>
            <div class="col-sm">
                <button type="button" class="btn btn-primary">Primary</button>
                <button type="button" class="btn btn-secondary">Secondary</button>
                <button type="button" class="btn btn-success">Success</button>
                <button type="button" class="btn btn-danger">Danger</button>
                <button type="button" class="btn btn-warning">Warning</button>
                <button type="button" class="btn btn-info">Info</button>
                <button type="button" class="btn btn-light">Light</button>
                <button type="button" class="btn btn-dark">Dark</button>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'HelloWorld',
        props: {
            msg: String
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h3 {
        margin: 40px 0 0;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color: #42b983;
    }
</style>
