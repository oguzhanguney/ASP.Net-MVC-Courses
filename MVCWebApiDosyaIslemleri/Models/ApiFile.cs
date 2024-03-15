using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCWebApiDosyaIslemleri.Models
{
    public class ApiFile
    {
        //constructor metot:
        public ApiFile(string localFileName,string fileName,string origin)
        {
            this.fileName= fileName.Trim('"');//içerisinde bulunan " çıkardık.
            var fileFolderPath=System.Web.Hosting.HostingEnvironment.MapPath(Controllers.FileController.FileFolder);
            var fileFullPath=Path.Combine(fileFolderPath,this.fileName); //folderpath ile filenaneyi birleştirdik.

            File.Copy(localFileName,fileFullPath,true);
            File.Delete(localFileName);

            this.fileUrl=origin+"/"+Controllers.FileController.FileFolder.TrimStart('~')+"/"+this.fileName;
        }

        //filename i oluşturalım
        public string fileName { get; set; }
        public string fileUrl { get; set; }
    }
}