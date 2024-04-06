using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiToken.MyFilter
{
    public class MyAuthorizationFilter:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization==null) 
            {
                actionContext.Response=actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
            }
            else
            {
                //eğer authorize olduysak parola ve kullanıcı adını almamız gerekir ve bunları bir standart haline getirmemiz gerekir(encoding)
                var key = actionContext.Request.Headers.Authorization.Parameter;
                var adParola=Encoding.UTF8.GetString(Convert.FromBase64String(key));
                //ad ve parola arasında iki nokta üst üste olacak şekilde gelir.bunu split ile ayıralım.
                var adParolaDizisi = adParola.Split(':');
                var kullanciAd = adParolaDizisi[0];
                var parola = adParolaDizisi[1];

                if (Login.Giris(kullanciAd,parola))
                {
                    //kullanıcı adını bir thread de tutalım.//iki parametre alır ikinci parametre role.
                    Thread.CurrentPrincipal=new GenericPrincipal(new GenericIdentity(kullanciAd),null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized);
                }


            }
        }
    }
}