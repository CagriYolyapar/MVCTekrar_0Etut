using MVCTekrar_0.Models.Entities;
using MVCTekrar_0.Models.Init;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTekrar_0.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasOptional(x => x.AuthorProfile).WithRequired(x => x.Author);
            modelBuilder.Entity<ArticleTag>().Ignore(x => x.ID);
            modelBuilder.Entity<ArticleTag>().HasKey(x => new
            {
                x.ArticleID,
                x.TagID
            });
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorProfile> AuthorProfiles { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}