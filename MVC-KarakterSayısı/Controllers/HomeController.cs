﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_KarakterSayısı.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult KarakterSayisi()
        {
            return View();
        }
    }
}