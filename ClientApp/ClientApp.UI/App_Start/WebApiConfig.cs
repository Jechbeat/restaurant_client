
using AutoMapper;
using ClientApp.App_Start;
using ClientApp.Infrastructure.Data;
//using ClientApp.Infrastructure.Data.Repositories;
//using ClientApp.Infrastructure.Interfaces;
//using ClientApp.Services;
//using ClientApp.Services.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;


namespace ClientApp
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
