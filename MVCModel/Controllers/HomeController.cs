using MVCModel.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Listele()
        {
            //öncelikle yapmamız gereken verilerimizi çekmek.
            //PersonelVeriler içindeki listPersonelleri model nesnemize atayalım.
            //add-view diyerek view i oluşturduk.
            var model = PersonelVeriler.listPersoneller;
            return View(model); //view e modelide gönderdik.
        }
    }
}