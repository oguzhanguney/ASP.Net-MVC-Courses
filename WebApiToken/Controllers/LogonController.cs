using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace WebApiToken.Controllers
{
    [MyFilter.MyAuthorizationFilter]
    public class LogonController : ApiController
    {
        public string logon()
        {
            return Thread.CurrentPrincipal.Identity.Name;
        }
    }
}
