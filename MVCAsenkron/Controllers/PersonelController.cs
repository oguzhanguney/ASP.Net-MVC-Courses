using MVCAsenkron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAsenkron.Controllers
{
    public class PersonelController : AsyncController //asenkron controllerdan kalıtım aldık.
    {
        // 1 completed 1 async metotlarını oluşturalım.

        //async metodu:
        public async void PersonelListesiAsync()
        {
            //burada asenkron manager kullanarak GetirPersoneller(models-class) metoduna ulaşıp ordaki dönüş tipini almamız lazım.
            PersonelVeri veri= new PersonelVeri();//bu verinin içerisindeki  GetirPersoneller e ulaşmam lazım bunun içinde async manager kullanalım.
            AsyncManager.Parameters["personeller"] = await veri.GetirPersoneller();
        }

        //completed metodu: 
        public ActionResult PersonelListesiCompleted(List<Personel> personeller) //bu içerisine async de tanımlanan bir personelleri alacak.
        {
            //burada yapmamız gereken şey completed metodu view eklemek.(add view -temp:list-model:personel)
            return View(personeller);
        }
    }
}