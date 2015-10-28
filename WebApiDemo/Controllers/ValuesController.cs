using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers {
    public class ValuesController : ApiController {
        // GET api/values
        //[ActionName("RetrieveValues")]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id) {
            return "value-" + id;
        }

        // POST api/values/post
        // Read important info about how to post to web api from javascript at
        // http://encosia.com/using-jquery-to-post-frombody-parameters-to-web-api/
        public void Post([FromBody]string value) { 
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        public void Delete(int id) {
        }
    }
}
