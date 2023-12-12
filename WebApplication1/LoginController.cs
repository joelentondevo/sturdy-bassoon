using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApplication1
{

    public class LoginController : ApiController
    {
        [HttpPost]
        [ActionName("LoginAttempt")]
        public HttpResponseMessage PostComplex(Login login)
        {
            if (ModelState.IsValid && login != null)
            {
                Console.WriteLine(login);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}