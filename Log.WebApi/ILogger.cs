using System.Web.Http.Controllers;
using Log.Data;
using Log.WebApi.Data;
using FullLogType = Log.WebApi.Data.FullLogType;
namespace Log.WebApi
{
    public interface ILogger:Log.ILogger
    {
        FullLogType Log(Location location,LogUserInfoSurragateType logInfo);
        FullLogType Log(Location location, LogSurragateType logInfo);
    }
}
