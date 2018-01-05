using System.Data.Entity;
using Log.Data;
using Log.WebApi.Bll;
using Log.WebApi.Data;
using Log.WebApi.Mssql.Data.Db;

using Log.WebApi.Mssql.Data.SingletonContext;
using FullLogType = Log.Data.FullLogType;

namespace Log.WebApi.Mssql.Bll
{
    public class LoggerMssql : LoggerCreate
    {
        public override FullLogType Log(LogSurragateType logInfo)
        {
            var data = base.Log(logInfo);
            DbyeKaydet(data);
            return data;
        }
        public override FullLogType Log(LogUserInfoSurragateType logInfo)
        {
            var data = base.Log(logInfo);
            DbyeKaydet(data);
            return data;
        }
        public override WebApi.Data.FullLogType Log(Location location, LogSurragateType logInfo)
        {
            var data = base.Log(location, logInfo);
            DbyeKaydet(data);
            return data;
        }

        public override WebApi.Data.FullLogType Log(Location location, LogUserInfoSurragateType logInfo)
        {
            var data = base.Log(location, logInfo);
            DbyeKaydet(data);
            return data;
        }


        public bool DbyeKaydet(FullLogType data)
        {
            var logkaydi = new Logs_Nuget()
            {
                LogIcerik = data.LogIcerik,
                LogTuru = data.LogTuru.ToString(),
                LogKategori = data.LogKategori,
                UserEmail = data.UserKey,
                TarihSaat = data.TarihSaat
            };

            var db = SingletonContext.GetInstance();
            db.Entry(logkaydi).State = EntityState.Added;
            var sonuc = db.SaveChanges();
            return sonuc != 0;
        }

        public bool DbyeKaydet(WebApi.Data.FullLogType data)
        {
            var logkaydi = new Logs_Nuget()
            {
                ClientIpAdresi = data.ClientIpAdresi,
                FullUrl = data.FullUrl,
                Controller = data.Controller,
                Action = data.Action,
                Parametre = data.Parametre,
                LogIcerik = data.LogIcerik,
                LogTuru = data.LogTuru.ToString(),
                LogKategori = data.LogKategori,
                UserEmail = data.UserKey,
                TarihSaat = data.TarihSaat
            };

            var db = SingletonContext.GetInstance();
            db.Entry(logkaydi).State = EntityState.Added;
            var sonuc = db.SaveChanges();
            return sonuc != 0;



        }


    }
}
