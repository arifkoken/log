using System;
using Log.Data;
namespace Log.Bll
{
    public class LoggerCreate : ILogger
    {
        public virtual FullLogType Log(LogUserInfoSurragateType logInfo)
        {
            var fullLogType = new FullLogType() { UserKey = logInfo.UserKey, LogTuru = logInfo.LogTuru, LogKategori = logInfo.LogKategori, LogIcerik = logInfo.LogIcerik, TarihSaat = DateTime.Now };
            return fullLogType;
        }
        public virtual FullLogType Log(LogSurragateType logInfo)
        {
            var fullLogType = new FullLogType() { LogTuru = logInfo.LogTuru, LogKategori = logInfo.LogKategori, LogIcerik = logInfo.LogIcerik, TarihSaat = DateTime.Now };
            return fullLogType;
        }
    }
}
