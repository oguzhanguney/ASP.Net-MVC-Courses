using MVC.Grid.Models.Manager;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Grid.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db=new DatabaseContext();
        // GET: Home
        public ActionResult Index()
        {
            var model=db.Personeller.ToList();
            return View();
        }

        public ActionResult Listele()
        {
            var model= db.Personeller.ToList();
            return View(model);
        }
    }
}