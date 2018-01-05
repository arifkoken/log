using Log.Data;

namespace Log.Bll
{
    public class LoggerContext
    {
        #region Properties
        private static ILogger Logger { get; set; }
        #endregion

        public static FullLogType Log(LogUserInfoSurragateType logInfo)
        {
           return Logger.Log(logInfo);
        }

        public static FullLogType Log(LogSurragateType logInfo)
        {
            return Logger.Log(logInfo);
        }
    }
}
