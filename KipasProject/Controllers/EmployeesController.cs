using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using KipasProject.Models.Context;
using KipasProject.Models.Entity;

namespace KipasProject.Controllers
{
    
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {

            EmployeDbContext db = new EmployeDbContext();

            var EmployeesList = db.Employees.ToList();

            return Request.CreateResponse(DataSourceLoader.Load(EmployeesList, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {


            return null;
        }
        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            EmployeDbContext db = new EmployeDbContext();


            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var employee = db.Employees.First(e => e.ID == key);

            JsonConvert.PopulateObject(values, employee);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}