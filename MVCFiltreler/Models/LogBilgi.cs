using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFiltreler.Models
{
    public class LogBilgi
    {
        //log hangi controllerla hangi işleme girdi ne zmn ve tipi ne :

        public string Controller { get; set; }
        public string Action { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string Tip { get; set; }
        public string HataMesaj { get; set; }
    }
}