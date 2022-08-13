using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Entities
{
    public class Author:UserSpec
    {
       

        //Relational Properties
        public virtual AuthorProfile AuthorProfile { get; set; }
        public virtual List<Comment> Comments { get; set; }



    }
}