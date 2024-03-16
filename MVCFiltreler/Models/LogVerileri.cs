using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFiltreler.Models
{
    public class LogVerileri
    {
        private static List<LogBilgi> logListesi = new List<LogBilgi>();

        public static List<LogBilgi> Loglar
        {
            get { return logListesi; }
        }


    }
}