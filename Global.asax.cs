using PredictionApp.App_Start;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PredictionApp
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // Set the App_Data path for the application
            string appDataPath = Server.MapPath("~/App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", appDataPath);

            // Log the path for verification
            System.Diagnostics.Debug.WriteLine($"AppDataPath: {appDataPath}");

            // Register components and routes
            UnityConfig.RegisterComponents();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
