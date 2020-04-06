using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Exam02_Dachepalli.Models;
//using Exam02_Dachepalli.DAL;

namespace Exam02_Dachepalli.DAL
{
    public class ShoppingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<OnlineService>
    {
        protected override void Seed(OnlineService context)
        {
            var customers = new List<Customer>
            {
            new Customer{FirstMidName="Carson",LastName="Alexander",OrderDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstMidName="Meredith",LastName="Alonso",OrderDate=DateTime.Parse("2002-09-01")},
           };

            customers.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Product>
            {
            new Product{ProductID=1050,ProductName="Bun",Cost=3,},
            new Product{ProductID=4022,ProductName="Oven",Cost=3,},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Order>
            {
            new Order{CustomerID=1,ProductID=1050,Rating=Rating.FIVE},
            new Order{CustomerID=1,ProductID=4022,Rating=Rating.THREE},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
