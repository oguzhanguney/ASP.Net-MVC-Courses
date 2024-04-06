using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiToken.Models;

namespace WebApiToken.Controllers
{
    [MyFilter.MyAuthorizationFilter]
    public class PersonellerController : ApiController
    {
        PersonelVeritabaniEntities entity = new PersonelVeritabaniEntities();

        public IEnumerable<Personeller> Get()
        {
            var personeller = (from p in entity.Personeller select p);

            return personeller;
        }
    }
}
