using AutoMapper;
using PredictiveApp.Infrastructure.Data;
//using PredictiveApp.Services;
//using PredictiveApp.Services.Interfaces;
//using PredictiveApp.DomainEntities;
//using PredictiveApp.InfrastructureData;
//using PredictiveApp.InfrastructureDataRepositories;
//using PredictiveApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.DirectoryServices;

namespace PredictiveApp.Controllers
{
 
    public class TreeController : Controller
    {
        
        private readonly IMapper mapper;

        public  TreeController(IMapper mapper)
        {
            this.mapper = mapper;

      
        }


        //
        // GET: /Tree/
        
        public ActionResult Index()
        {                  
            return View();
        }

    }
}
