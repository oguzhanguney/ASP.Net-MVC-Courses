using MVCWebApiDosyaIslemleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MVCWebApiDosyaIslemleri.Controllers
{
    public class FileController : ApiController
    {
        //öncelikle temp ve files klasörlerine erişelim.bir değişkene yollarını atalım.

        internal const string FileFolder = "~/Files"; // tilda projenin route dizinini oluşturur.
        internal const string TempFolder = "~/Temp";


        //(Upload File)doysa yükleme metodu (asenkenron)

        [HttpPost]
        public async Task<HttpResponseMessage> UploadFile()
        {
            MultipartFormDataStreamProvider streamProvider=new MultipartFormDataStreamProvider(HttpContext.Current.Server.MapPath(TempFolder));

            try
            {
                await Request.Content.ReadAsMultipartAsync(streamProvider);
                var origin = Request.Headers.Host;
                List<ApiFile> result=streamProvider.FileData.Select(i => new ApiFile(i.LocalFileName,i.Headers.ContentDisposition.FileName,origin)).ToList();

                //veritabanı baglantısı için entity oluşturalım:
                using(FileUploadEntities entity=new FileUploadEntities())
                {
                    Files file = new Files();
                    file.fileUrl = result[0].fileUrl;
                    file.fileName = result[0].fileName;
                    entity.Files.Add(file);
                    entity.SaveChanges();
                    
                }

                return Request.CreateResponse(HttpStatusCode.OK,result);
            }
            catch (Exception e)
            {

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        //get all files  metodu:

        [HttpGet]
        public HttpResponseMessage GetAllFiles()
        {
            //veritabanına erişmek için:
            using(FileUploadEntities entity = new FileUploadEntities())
            {
                try
                {
                    var files=entity.Files.ToList();
                    return Request.CreateResponse(HttpStatusCode.OK,files);

                }
                catch (Exception e)
                {

                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
                }
            }
        }

        //delete life metodu:
        public bool DeleteFile(string fileName,int fileId)//filename sistemdeki dosyayı silmek için fileId veritabanındaki dosyayı silmek için 
        {
            fileName="/Files"+fileName;
            bool status;

            try
            {
                System.IO.File.Delete(HttpContext.Current.Server.MapPath("~/" + fileName)); //dosya sistemden silindi.

                using(FileUploadEntities entity=new FileUploadEntities())//veritabanından silme işlemi için
                {
                    var file = entity.Files.FirstOrDefault(i=>i.fileId == fileId);
                    entity.Files.Remove(file);
                    entity.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {

                status=false;
            }
            return status;
        }
    }
}
