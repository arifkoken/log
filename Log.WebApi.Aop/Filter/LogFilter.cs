using System.Diagnostics;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Log.Data;
using Log.Data.Enum;
using Log.WebApi.Bll;

namespace Log.WebApi.Aop.Filter
{
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext httpActionContext)
        {
            var userEmail = ConverterBll.Email(httpActionContext.RequestContext);
            var location = ConverterBll.Location(httpActionContext);
            LoggerContext.Log(location,
                new LogUserInfoSurragateType()
                {
                    UserKey = userEmail,
                    LogKategori = "",
                    LogTuru = LogTuru.Bilgi,
                    LogIcerik = "Istek Yapıldı.."
                });
            base.OnActionExecuting(httpActionContext);
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Debug.WriteLine("OnActionExecuted Çalıştı...");
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}
