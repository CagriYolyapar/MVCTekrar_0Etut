using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Entities
{
    public class Tag:BaseEntity
    {
        public int TagName { get; set; }


        //Relational Properties
        public virtual List<ArticleTag> ArticleTags { get; set; }
    }
}