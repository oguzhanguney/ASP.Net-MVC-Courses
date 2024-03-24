using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDurumYonetimi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //Session Start
        protected void Session_Start(object sender, EventArgs e)
        {
            int onlineUyeSayisi = Convert.ToInt32(Application["OnlineUyeSayisi"]);
            onlineUyeSayisi += 1;
            Application["OnlineUyeSayisi"] = onlineUyeSayisi;
        }

        //Session End
        protected void Session_End(object sender, EventArgs e)
        {
            int onlineUyeSayisi = Convert.ToInt32(Application["OnlineUyeSayisi"]);
            onlineUyeSayisi -= 1;
            Application["OnlineUyeSayisi"] = onlineUyeSayisi; 
        }
    }
}

