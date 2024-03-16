using Antlr.Runtime.Misc;
using MVCFiltreler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltreler.Filters
{
    public class LogAttribute : FilterAttribute, IActionFilter,IResultFilter,IExceptionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //logbilgilerde action ve controller tutacagız demiştık bu action ve controller isimlerine filtercontext içerisindeki actiondescriptor aracılıgı ile erişiriz.

            LogVerileri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IslemTarihi = DateTime.Now,
                Tip = " (action)Çalıştıktan Sonra"
            });
        }

        //action filter:
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogVerileri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = filterContext.ActionDescriptor.ActionName,
                IslemTarihi = DateTime.Now,
                Tip = "(action)Çalışmadan Önce"
            });
        }

        //exception filter:
        public void OnException(ExceptionContext filterContext)
        {
            LogVerileri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                IslemTarihi = DateTime.Now,
                Tip = "Hata",
                HataMesaj=filterContext.Exception.Message
                
            });
        }



        //Result filter:
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogVerileri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                IslemTarihi = DateTime.Now,
                Tip = "(view)Çalışmadan Sonra"
            });
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogVerileri.Loglar.Add(new LogBilgi
            {
                Controller = filterContext.RouteData.Values["controller"].ToString(),
                Action = filterContext.RouteData.Values["action"].ToString(),
                IslemTarihi = DateTime.Now,
                Tip = "(view)Çalışmadan Önce"
            });
        }
    }
}