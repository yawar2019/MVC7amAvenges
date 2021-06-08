using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{

    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> test()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "my id is:"+ id +" and My value is "+ value;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "my id is:" + id;
        }
    }
}
