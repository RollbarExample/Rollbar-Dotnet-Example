using Rollbar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RollBar
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            const string postServerItemAccessToken = "69609226b4014ef39f62d4b2008c56ed";
            RollbarLocator.RollbarInstance.Configure(new RollbarConfig(postServerItemAccessToken)
            {
                Environment = "production"
            });

           

        }
    }
}
