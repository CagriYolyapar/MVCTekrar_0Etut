using MVCTekrar_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.LogEntities
{
    public class LogAppUser:BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        
    }
}