using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApiRouting.Controllers
{
    public class ValuesController : ApiController
    {
        //burada statik bir liste oluşturacagız.listenin degerlerini get ile parametresi verilmiş bir ise ona göre ayarlancak ve post put delete işlemlerini yapacagız.

        static List<string> Liste = new List<string>()
        {
            "İlk değer","ikinci değer"
        };



        // GET api/values/action
        [HttpGet]
        public IEnumerable<string> ListeGetir()
        {
            return Liste;
        }

        // GET api/values/action/5
        [HttpGet]

        public string ListedenDegerGetir(int id)
        {
            return Liste[id];

        }

        // POST api/values/action
        [HttpPost]
        public void ListeEKle([FromBody] string value)
        {
            Liste.Add(value);
        }

        // PUT api/values/action/5
        [HttpPut]
        public void ListeGuncelle(int id, [FromBody] string value)
        {
            Liste[id]= value;
        }

        // DELETE api/values/action/5
        [HttpDelete]
        public void ListeSil(int id)
        {
            Liste.RemoveAt(id);
        }
    }
}
