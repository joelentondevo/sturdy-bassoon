using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication1
{

    public class Login2Controller : ApiController
    {
        [HttpPost]
        [ActionName("LoginAttempt")]
        public HttpResponseMessage PostComplex(HttpRequest request)
        {
            if (request != null)
            {
                Console.WriteLine("bing");
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                Console.WriteLine("FailedState but I still did something");
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}