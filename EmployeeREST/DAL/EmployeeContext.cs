using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EmployeeREST.Models;

namespace EmployeeREST.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("employeecontext")
        {

        }

        public DbSet<Employee> Employees { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}