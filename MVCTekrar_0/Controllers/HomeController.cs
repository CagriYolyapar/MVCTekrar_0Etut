using MVCTekrar_0.DesignPatterns.SingletonPattern;
using MVCTekrar_0.Models.Context;
using MVCTekrar_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTekrar_0.Controllers
{
    public class HomeController : Controller
    {
        MyContext _db;

        public HomeController()
        {
            _db = DBTool.DBInstance;
        }




        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Author author )
        {
            if(_db.Authors.Any(x=>x.UserName == author.UserName && x.Password == author.Password))
            {
                Session["Author"] = _db.Authors.FirstOrDefault(x => x.UserName == author.UserName && x.Password == author.Password);

                return RedirectToAction("CategoryList", "Category");
            }
            return View();
        }
    }
}