﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Polaris4.Startup))]
namespace Polaris4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
