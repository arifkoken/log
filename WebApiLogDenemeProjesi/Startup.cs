using System;
using System.Collections.Generic;
using System.Linq;
using IocContainer;
using Log.WebApi.Bll;
using Log.WebApi.Mssql.Bll;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApiLogDenemeProjesi.Startup))]

namespace WebApiLogDenemeProjesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IoCResolver.GetInstance.Resolve<LoggerContext, LoggerMssql>();
            ConfigureAuth(app);
        }
    }
}
