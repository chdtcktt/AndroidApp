using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppApi.Controllers
{
    public class DataController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
            slkdjflkasjd
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            var item = value;
            var things = 1;
            sldkfj
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
            
            var myValue1 = "hey yall";lkdjfksjdfkj
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}