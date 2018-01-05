using Log.Data;
using Log.WebApi.Data;
using FullLogType = Log.WebApi.Data.FullLogType;

namespace Log.WebApi.Bll
{
   public  class LoggerContext
    {
        #region Properties
        private static ILogger Logger { get; set; }
        #endregion
        public static FullLogType Log(Location location, LogSurragateType logInfo)
        {
            return Logger.Log(location, logInfo);
        }
        public static FullLogType Log(Location location, LogUserInfoSurragateType logInfo)
        {
            return Logger.Log(location, logInfo);
        }
        public static Log.Data.FullLogType Log(LogSurragateType logInfo)
        {
            return Logger.Log(logInfo);
        }
        public static Log.Data.FullLogType Log(LogUserInfoSurragateType logInfo)
        {
            return Logger.Log(logInfo);
        }
    }
}
