using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SHCM_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            json.SerializerSettings.ReferenceLoopHandling
                        = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API routes
            config.MapHttpAttributeRoutes();

            //=====================PRODUCT======================================
            config.Routes.MapHttpRoute(
                name: "GetAllProduct",
                routeTemplate: "api/all-product",
                defaults: new { controller = "Products", action = "GetAllProduct" }
            );

            config.Routes.MapHttpRoute(
                name: "GetProductDetail",
                routeTemplate: "api/product-detail/{id}",
                defaults: new { controller = "Products", action = "GetProductDetail" }
            );

            config.Routes.MapHttpRoute(
                name: "AddProduct",
                routeTemplate: "api/add-product",
                defaults: new { controller = "Products", action = "AddProduct" }
            );
            //=====================ACCOUNT======================================
            config.Routes.MapHttpRoute(
                name: "GetRanking",
                routeTemplate: "api/ranking",
                defaults: new { controller = "Accounts", action = "GetRanking" }
            );

            config.Routes.MapHttpRoute(
                name: "GetDetails",
                routeTemplate: "api/details/{id}",
                defaults: new { controller = "Accounts", action = "GetDetails" }
            );

            config.Routes.MapHttpRoute(
                name: "ChangeInfo",
                routeTemplate: "api/change-info",
                defaults: new { controller = "Accounts", action = "ChangeInfo" }
            );

            config.Routes.MapHttpRoute(
                name: "RegisterAccount",
                routeTemplate: "api/register",
                defaults: new { controller = "Accounts", action = "RegisterAccount" }
            );

            config.Routes.MapHttpRoute(
                name: "Login",
                routeTemplate: "api/login",
                defaults: new { controller = "Accounts", action = "Login" }
            );

            config.Routes.MapHttpRoute(
                name: "UpdateScore",
                routeTemplate: "api/update-score",
                defaults: new { controller = "Accounts", action = "UpdateScore" }
            );

            config.Routes.MapHttpRoute(
                name: "GetQuiz",
                routeTemplate: "api/quiz",
                defaults: new { controller = "Accounts", action = "GetQuiz" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
