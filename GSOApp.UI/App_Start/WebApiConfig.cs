
using AutoMapper;
using PredictiveApp.App_Start;
using PredictiveApp.Infrastructure.Data;
//using PredictiveApp.Infrastructure.Data.Repositories;
//using PredictiveApp.Infrastructure.Interfaces;
//using PredictiveApp.Services;
//using PredictiveApp.Services.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;


namespace PredictiveApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            // mapper section
            var configuration = new MapperConfiguration( cfg =>
            {
        



            });
                               
            configuration.AssertConfigurationIsValid();


            var mapper = configuration.CreateMapper();  
            // end mapper section

            // Unity container - configuration
            var container = new UnityContainer();
            container.RegisterInstance<IMapper>(mapper);       
            container.RegisterType<DbContext, DataContext>();
     




            config.DependencyResolver = new UnityResolver(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            // end unity container - configuration

        }
    }
}
