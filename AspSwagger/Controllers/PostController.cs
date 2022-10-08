using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspSwagger.Controllers
{
    public class PostController : ApiController
    {
        [Route("CheckStr/{str}")]
        [HttpGet]
        public IHttpActionResult CheckId(string str)
        {
            if (str == "swagger")
            {
                str = "asp use swagger";
            }
            else if (str =="api")
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else if (str != "swaggerapi")
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(string.Format("No Employee found with str = {0}", 10)),
                    ReasonPhrase = "Employee Not Found"
                };

                throw new HttpResponseException(response);
            }

            return Ok(str);
        }
    }
}
