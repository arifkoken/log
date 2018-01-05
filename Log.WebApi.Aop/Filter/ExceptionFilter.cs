using System.Web.Http.Filters;
using Log.Data;
using Log.Data.Enum;
using Log.WebApi.Bll;

namespace Log.WebApi.Aop.Filter
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var httpActionContext = actionExecutedContext.ActionContext;
            var userEmail = ConverterBll.Email(httpActionContext.RequestContext);
            var location = ConverterBll.Location(httpActionContext);


            LoggerContext.Log(location,
              new LogUserInfoSurragateType()
              {
                  UserKey = userEmail,
                  LogKategori = "",
                  LogTuru = LogTuru.Hata,
                  LogIcerik = actionExecutedContext.Exception.Message
              });


            #region Respose Düzenleme
            //actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, actionExecutedContext.Exception.Message);
            //actionExecutedContext.Response.Headers.Add("HataID", logkaydi.ID.ToString());
            #endregion
            base.OnException(actionExecutedContext);
        }
    }
}
