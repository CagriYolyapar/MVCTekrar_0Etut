using MVCTekrar_0.AuthenticationClasses;
using MVCTekrar_0.DesignPatterns.SingletonPattern;
using MVCTekrar_0.Filters;
using MVCTekrar_0.Models.Context;
using MVCTekrar_0.Models.Entities;
using MVCTekrar_0.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTekrar_0.Controllers
{

    [AuthorAuthentication]
    [ActFilter]
    public class CategoryController : Controller
    {
        MyContext _db;
        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }
      
        public ActionResult CategoryList()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _db.Categories.ToList()
            };
            return View(cvm);
        }


        public ActionResult AddCategory()
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult UpdateCategory(int id)
        {
            CategoryVM cvm = new CategoryVM() 
            {
                Category = _db.Categories.Find(id)
            };

            return View(cvm);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            Category toBeUpdated = _db.Categories.Find(category.ID);
            toBeUpdated.CategoryName = category.CategoryName;
            toBeUpdated.Description = category.Description;
            _db.SaveChanges();

            return RedirectToAction("CategoryList");
        }


        public ActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}