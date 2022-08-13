using MVCTekrar_0.DesignPatterns.SingletonPattern;
using MVCTekrar_0.Models.Context;
using MVCTekrar_0.Models.Entities;
using MVCTekrar_0.Models.Enums;
using MVCTekrar_0.Models.LogContext;
using MVCTekrar_0.Models.LogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTekrar_0.Filters
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        MyLogContext _db;

        public ActFilter()
        {
            _db = LogDBTool.DBInstance;
        }


        void LogProficiently(ControllerContext filterContext, bool girisMi)
        {
            if (filterContext is ActionExecutedContext)
            {
                ActionExecutedContext param = filterContext as ActionExecutedContext;
                Log logger = new Log();
                logger.ActionName = param.ActionDescriptor.ActionName;
                logger.ControllerName = param.ActionDescriptor.ControllerDescriptor.ControllerName;
                logger.Information = param.HttpContext.Session["Author"] == null ? "Anonim kullanıcı" : (param.HttpContext.Session["Author"] as Author).UserName;
                //Todo: aslında bu noktada hemen bir LogAppUser instance'i alınarak (bilgilerini Author'dan alacak) LoggerDatabase'ine kaydedilmesi en iyisi olur...
                ControlEntry(girisMi, logger);
                AddLogger(logger);
            }
            else
            {
                ActionExecutingContext param = filterContext as ActionExecutingContext;
                Log logger = new Log();
                logger.ActionName = param.ActionDescriptor.ActionName;
                logger.ControllerName = param.ActionDescriptor.ControllerDescriptor.ControllerName;
                logger.Information = param.HttpContext.Session["Author"] == null ? "Anonim kullanıcı" : (param.HttpContext.Session["Author"] as Author).UserName;
                ControlEntry(girisMi, logger);
                AddLogger(logger);
            }
        }

        void AddLogger(Log logger)
        {
            _db.Logs.Add(logger);
            _db.SaveChanges();

        }

        void ControlEntry(bool girisMi, Log logger)
        {
            logger.Keyword = girisMi ? Keyword.Enter : Keyword.Exit;
        }



        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

           
            LogProficiently(filterContext, false);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogProficiently(filterContext, true);
        }
    }
}