using MVCWebApiRouting2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApiRouting2.Controllers
{
    [RoutePrefix("api/personel")] //tüm actionlarımızda kullandıgımız için controller da prefix olarak tanımladık.
    public class PersonelController : ApiController
    {
        static List<Personel> personelList = new List<Personel>()
        {
            new Personel() {Id=1,Ad="Oguzhan"},
            new Personel() {Id=2,Ad="Alican"}

        };
        //şimdi actionlarımızı oluşturalım

        //personelin bütün listesini getirme:
        [Route("")]
        public IEnumerable<Personel> Get()
        {
            return personelList;
        }

        //id sini bildigimiz personeli getirelim: 
        [Route("{id:int}")] //integer kısıtlaması yaptık(route constraint)
        public Personel Get(int id)
        {
            return personelList.FirstOrDefault(x => x.Id == id);
        }
        //optional constraint:
        [Route("default/{id:decimal=2}")] //integer kısıtlaması yaptık(route constraint)
        public Personel Get(decimal id)
        {
            return personelList.FirstOrDefault(x => x.Id == id);
        }

        //route constraint
        [Route("{ad:alpha:ilkh}")] // string kısıtlaması yaptık(route constraint)  /artık sadece baş harfi a olan üyeleri getirecek.
        public Personel Get(string ad)
        {
            return personelList.FirstOrDefault(x => x.Ad.ToUpper() == ad.ToUpper());
        }

        //id sini bildigimiz personelin görevlerini getirelim:
        [Route("{id}/gorev")] // iki metotda get işlemi yaptıgından hangisini yapacagını bilemiyorum bu yuzden attribute based routing kullanacagız.
        public string GetGorev(int id)
        {
            switch (id)
            {
                case 1:
                    return "görev1";
                case 2:
                    return "görev2";
                default:
                    return null;
            }
        }

        //şimdi yeni bir action yazalım ve var olan bütün görevleri döndürsün
        [Route("~/api/gorevler")] //    ~/ yaparak yukarıdaki prefix route u eziyoruz.
        public IEnumerable<string> GetGorev()
        {
            return new List<string> { "görev1", "görev2" };
        }
    }
}
