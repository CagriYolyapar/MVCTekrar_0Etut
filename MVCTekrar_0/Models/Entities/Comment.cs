using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Entities
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; }
        public int ArticleID { get; set; }
        public int AuthorID { get; set; }



        //Relational Properties
        public virtual Article Article { get; set; }
        public virtual Author Author { get; set; }


    }
}