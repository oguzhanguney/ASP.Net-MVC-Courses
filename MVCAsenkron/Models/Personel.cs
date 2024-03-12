using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVCAsenkron.Models
{
    public class Personel
    {
        public int Id{ get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    //personel classımız oluştu.bunlarıda asenkron olarak cagıracagımız verileri oluşturalım.
    public class PersonelVeri
    {
        public async Task<List<Personel>> GetirPersoneller()
        {
            var personeller = Task.Factory.StartNew(() =>
            {
                return new List<Personel>
                {
                    new Personel{Id=1,Ad="Ali",Soyad="Hazır"},
                    new Personel{Id=2,Ad="Oguzhan",Soyad="Güney"}
                };
            });
            return await personeller;//böylelikle asenkron verileri eklemiş olduk.şimdi bir controller oluşturalım ve verileri gösterelim.controlleri asenkron classından getirecegiz.
        }
    }

}