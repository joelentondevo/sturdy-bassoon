using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using FormEncode.Models;

namespace WebApplication1
{

    public class Login2Controller : ApiController
    {
        [HttpPost]
        [ActionName("LoginAttempt")]
        public HttpResponseMessage PostComplex(LoginModel login)
        {

            if (login.username == "bing")
            {
                Console.WriteLine("bing");
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            else
            {
                Console.WriteLine("FailedState but I still did something");
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}