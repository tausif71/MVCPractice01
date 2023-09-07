using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCPractice01.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext() : base("MyDatabase")
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ApplicationDBContext>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties().Where(p => p.Name.EndsWith("Id")).Configure(c => c.HasColumnType("bigint"));
        }
    }
}