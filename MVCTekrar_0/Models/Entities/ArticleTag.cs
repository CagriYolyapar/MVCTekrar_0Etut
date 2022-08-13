using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Entities
{
    public class ArticleTag:BaseEntity
    {
        public int ArticleID { get; set; }
        public int TagID { get; set; }

        //Relational Properties
        public virtual Article Article { get; set; }
        public virtual Tag Tag { get; set; }

    }
}