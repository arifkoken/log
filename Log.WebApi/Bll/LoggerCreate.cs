using System;
using Log.Data;
using Log.WebApi.Data;
using FullLogType = Log.WebApi.Data.FullLogType;

namespace Log.WebApi.Bll
{
    public class LoggerCreate:Log.Bll.LoggerCreate,ILogger
    {
        public virtual FullLogType Log(Location location, LogUserInfoSurragateType logInfo)
        {
            var fullLogType = new FullLogType() {ClientIpAdresi =location.ClientIpAdresi, FullUrl =location.FullUrl, Controller =location.Controller,Action =location.Action,Parametre =location.Parametre, UserKey = logInfo.UserKey, LogTuru = logInfo.LogTuru, LogKategori = logInfo.LogKategori, LogIcerik = logInfo.LogIcerik, TarihSaat = DateTime.Now };
            return fullLogType;
        }
        public virtual FullLogType Log(Location location, LogSurragateType logInfo)
        {
            var fullLogType = new FullLogType() { ClientIpAdresi = location.ClientIpAdresi, FullUrl =location.FullUrl, Controller = location.Controller, Action = location.Action, Parametre = location.Parametre,LogTuru = logInfo.LogTuru, LogKategori = logInfo.LogKategori, LogIcerik = logInfo.LogIcerik, TarihSaat = DateTime.Now };
            return fullLogType;
        }
    }
}
