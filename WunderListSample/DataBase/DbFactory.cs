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
        public DbFactory() : base("DefaultConnection") { 

        }

        public DbSet<WunderListItem> WunderListItems { get; set; }
        public DbSet<WunderTask> WunderTasks { get; set; }

    }
}