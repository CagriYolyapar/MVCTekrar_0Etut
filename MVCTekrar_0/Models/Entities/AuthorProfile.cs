using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Entities
{
    public class AuthorProfile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual Author Author { get; set; }

    }
}