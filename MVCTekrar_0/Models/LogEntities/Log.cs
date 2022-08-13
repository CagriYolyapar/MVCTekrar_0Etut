using MVCTekrar_0.Models.Entities;
using MVCTekrar_0.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.LogEntities
{
    public class Log:BaseEntity
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Information { get; set; }
        public Keyword Keyword { get; set; }
    }



}