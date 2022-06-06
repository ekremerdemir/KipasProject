using KipasProject.Models.Data;
using KipasProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KipasProject.Models.Context
{
    public class EmployeDbContext : DbContext
    {

        public EmployeDbContext() :base("EmployeDb")
        {
            Database.SetInitializer<EmployeDbContext>(new EmployeeInitializer<EmployeDbContext>());
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<City> Cities { get; set; }


    }
}
