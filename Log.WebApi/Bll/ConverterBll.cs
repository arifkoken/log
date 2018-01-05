using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Http.Controllers;
using Log.WebApi.Data;
using Microsoft.Owin;
using Newtonsoft.Json;

namespace Log.WebApi.Bll
{
    public static class ConverterBll
    {

        public static string Email(HttpRequestContext httpRequestContext)
        {

            var principal = httpRequestContext.Principal as ClaimsPrincipal;
            var email = principal.Claims?.SingleOrDefault(k => k.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value;
            //var email = "";
            //var principal = httpRequestContext.Principal as ClaimsPrincipal;
            //if (principal == null) return email;
            //var identity = principal.Identities.FirstOrDefault();
            //var firstOrDefault = identity?.Claims.FirstOrDefault(k => k.Type == "r_email");
            //if (firstOrDefault == null) return email;
            //email = firstOrDefault.Value;
            return email;
        }
        public static Location Location(HttpActionContext httpActionContext)
        {
            var actioncontext = httpActionContext.ActionDescriptor;

            return new Location()
            {
   
                ClientIpAdresi = ClientIpAdresi(httpActionContext.Request),
                FullUrl = httpActionContext.Request.RequestUri.ToString(),
                Controller = actioncontext.ControllerDescriptor.ControllerName,
                Action = actioncontext.ActionName,
                Parametre = Paremetre(httpActionContext.ActionArguments)

            };
        }
        public static string ClientIpAdresi(HttpRequestMessage request)
        {
            var requestUserHostAddress = ((HttpContextBase)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                if (requestUserHostAddress != null)
                    return IPAddress.Parse(requestUserHostAddress).ToString();
            }
            if (request.Properties.ContainsKey("MS_OwinContext"))
            {
                return IPAddress.Parse(((OwinContext)request.Properties["MS_OwinContext"]).Request.RemoteIpAddress).ToString();
            }
            return null;
        }
        private static string Paremetre(IDictionary<string, object> keyvaluepair)
        {
            var argument = keyvaluepair.ToArray();
            var parametreString = "";
            if (!argument.Any()) return parametreString;
            //var abc = new object();
            //var serializer = new JsonSerializer {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
            //serializer.Serialize((JsonWriter) abc,argument);


            parametreString = JsonConvert.SerializeObject(argument, Formatting.None,new JsonSerializerSettings{ ReferenceLoopHandling = ReferenceLoopHandling.Ignore });            
            return parametreString;
        }

    }
}
