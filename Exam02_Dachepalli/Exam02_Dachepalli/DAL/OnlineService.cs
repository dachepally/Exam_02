using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam02_Dachepalli.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Exam02_Dachepalli.DAL
{
    public class OnlineService : DbContext
    {
        public OnlineService() : base("OnlineService")
        {
        }

        public DbSet<Customer> Students { get; set; }
        public DbSet<Order> Enrollments { get; set; }
        public DbSet<Product> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}