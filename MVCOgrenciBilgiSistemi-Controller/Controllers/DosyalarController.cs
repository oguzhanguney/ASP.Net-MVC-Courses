using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCOgrenciBilgiSistemi_Controller.Controllers
{
    public class DosyalarController : Controller
    {
        // GET: Dosyalar
        public ActionResult Index()
        {
            return View();
        }

        //FileResult metodumuzu oluşturalım.
        public FileResult UniversiteBilgi()
        {
            string dosyaYolu = Server.MapPath("~/Files/Universitemiz.txt");
            string dosyaIcerikTur = "text/plain";
            return new FilePathResult(dosyaYolu, dosyaIcerikTur);
            //böylelikle UnıversiteBilgi action ı çalıştıgı zaman dosya oluşmuş olacak yada gösterilecek yada indirilecel.(tarayıcıya baglı)
            //sayfa ındexı oluşturalım.
        }

        //FileStreamResult metodumuzu oluşturalım
        public FileStreamResult UniversiteStreamBilgi()
        {
            //bu metot içerisinde bir dosya oluşturacagız ve bu dosyayıda geri döndermiş olacagız.(bu metot çalıştıgında)
            string metin = "Deneme yazısı";
            //streamleri kullanırken şöyle bir yol izliyoruz:memory stream türünde bir degisken oluşturuyoruz,sonra içine yazılacak yazıyı bayt türüne çeviriyoruz türkçe karakter şeklinde
            //bayt türüne çevrilmiş yazıyıda register a atıyoruz.başlangıc ve ne kadar olacagını belirtiyoruz.sonrada filestreamresult un içerisine registeri yazıyoruz.
            MemoryStream register = new MemoryStream();
            byte[] bytes=Encoding.UTF8.GetBytes(metin);
            register.Write(bytes, 0, bytes.Length);
            register.Position = 0;
            FileStreamResult fileStreamResult = new FileStreamResult(register, "text/plain");
            fileStreamResult.FileDownloadName = "Bilgi.txt";//indirme ismi
            return fileStreamResult;

        }



    }
}