using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        public class LoginController : ApiController
        {
            [HttpPost]
            [ActionName("LoginAttempt")]
            public HttpResponseMessage PostComplex(string update)
            {
                if (ModelState.IsValid && update != null)
                {
                    Console.WriteLine(update);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
        }
    }
}
        