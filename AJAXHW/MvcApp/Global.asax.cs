﻿namespace MvcApp
{
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using MvcApp.Data.Migrations;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseConfig.RegisterDatabase();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
