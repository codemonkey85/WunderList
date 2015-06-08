using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WunderListSample.Models;

namespace WunderListSample.DataBase
{
    public class DbFactory:DbContext
    {
        public DbFactory()
            : base("DefaultConnection")
        {
            Database.SetInitializer<DbFactory>(new CreateDatabaseIfNotExists<DbFactory>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<WunderListItem> WunderListItems { get; set; }
        public DbSet<WunderTask> WunderTasks { get; set; }
        public DbSet<WunderListSubTask> WunderListSubTasks { get; set; }

    }
}