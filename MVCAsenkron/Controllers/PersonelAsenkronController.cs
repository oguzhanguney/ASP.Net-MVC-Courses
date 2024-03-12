using MVCAsenkron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCAsenkron.Controllers
{
    public class PersonelAsenkronController : Controller
    {
        public async Task<ActionResult> PersonelListesi()
        {
            PersonelVeri veri= new PersonelVeri();
            var personeller=await veri.GetirPersoneller();
            return View(personeller);
        }
    }
}