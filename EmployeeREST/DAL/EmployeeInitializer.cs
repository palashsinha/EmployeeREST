using EmployeeREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeREST.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee{ ID = 1, Name = "John", Department = "Tech"},
                new Employee{ ID = 1, Name = "Joe", Department = "Sales"},
                new Employee{ ID = 1, Name = "Steve", Department = "HR"},
                new Employee{ ID = 1, Name = "Angela", Department = "Marketing"}
            };

            employees.ForEach(x => context.Employees.Add(x));
            context.SaveChanges();
        }
    }
}