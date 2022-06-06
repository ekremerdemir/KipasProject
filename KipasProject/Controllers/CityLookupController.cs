using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using KipasProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;

namespace KipasProject.Controllers
{
    public class CityLookupController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {

            EmployeDbContext db = new EmployeDbContext();

            var CityList = db.Cities.ToList();

            return Request.CreateResponse(DataSourceLoader.Load(CityList, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {


            return null;
        }
    }
}