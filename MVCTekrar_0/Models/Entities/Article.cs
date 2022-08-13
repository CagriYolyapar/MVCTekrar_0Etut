using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Entities
{
    public class Article:BaseEntity
    {
        public string Title { get; set; }
        public string Context { get; set; }
        public int? AuthorID { get; set; }
        public int? EditorID { get; set; }
        public int? CategoryID { get; set; }



        //Relational Properties
        public virtual Author Author { get; set; }
        public virtual Editor Editor { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ArticleTag> ArticleTags { get; set; }



    }
}