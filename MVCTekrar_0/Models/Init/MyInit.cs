using MVCTekrar_0.Models.Context;
using MVCTekrar_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            Author au = new Author
            {
                UserName = "cag1",
                Password = "123"
            };
            context.Authors.Add(au);
            context.SaveChanges();
        }
    }
}