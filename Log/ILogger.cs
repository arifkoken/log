using Log.Data;

namespace Log
{
    public interface ILogger
    {
        FullLogType Log(LogUserInfoSurragateType logInfo);
        FullLogType Log(LogSurragateType logInfo);
    }
}
