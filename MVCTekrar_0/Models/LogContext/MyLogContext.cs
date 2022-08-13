using MVCTekrar_0.Models.LogEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.LogContext
{
    public class MyLogContext:DbContext
    {
        public MyLogContext():base("MyLogConnection")
        {

        }

        public DbSet<LogAppUser> LogAppUsers { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}