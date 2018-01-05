using Log.Data;
using Log.WebApi.Bll;
using Log.WebApi.Data;
using FullLogType = Log.Data.FullLogType;

namespace Log.WebApi.Debug.Bll
{
    public class LoggerDebug : LoggerCreate
    {
        public override FullLogType Log(LogSurragateType logInfo)
        {
            var fullLogType = base.Log(logInfo);
            var logString = $"LogTuru:{fullLogType.LogTuru},LogKategorisi:{fullLogType.LogKategori},TarihSaat:{fullLogType.TarihSaat},LogIcerik:{fullLogType.LogIcerik}";

            System.Diagnostics.Debug.WriteLine("----------------------------------LOG START--------------------------------------");
            System.Diagnostics.Debug.WriteLine(logString);
            System.Diagnostics.Debug.WriteLine("----------------------------------LOG END----------------------------------------");
            return fullLogType;
        }
        public override FullLogType Log(LogUserInfoSurragateType logInfo)
        {
            var fullLogType = base.Log(logInfo);
            var logString = $"UserKey:{fullLogType.UserKey},LogTuru:{fullLogType.LogTuru},LogKategorisi:{fullLogType.LogKategori},TarihSaat:{fullLogType.TarihSaat},LogIcerik:{fullLogType.LogIcerik}";

            System.Diagnostics.Debug.WriteLine("----------------------------------LOG START--------------------------------------");
            System.Diagnostics.Debug.WriteLine(logString);
            System.Diagnostics.Debug.WriteLine("----------------------------------LOG END----------------------------------------");
            return fullLogType;
        }
        public override WebApi.Data.FullLogType Log(Location location, LogSurragateType logInfo)
        {
            var fullLogType = base.Log(location, logInfo);
            var logString = $"ClientIpAdresi:{fullLogType.ClientIpAdresi},FullUrl:{fullLogType.FullUrl},Controller:{fullLogType.Controller},Action:{fullLogType.Action},Parametre:{fullLogType.Parametre},LogTuru:{fullLogType.LogTuru},LogKategorisi:{fullLogType.LogKategori},TarihSaat:{fullLogType.TarihSaat},LogIcerik:{fullLogType.LogIcerik}";

            System.Diagnostics.Debug.WriteLine("----------------------------------LOG START--------------------------------------");
            System.Diagnostics.Debug.WriteLine(logString);
            System.Diagnostics.Debug.WriteLine("----------------------------------LOG END----------------------------------------");
            return fullLogType;
        }
        public override WebApi.Data.FullLogType Log(Location location, LogUserInfoSurragateType logInfo)
        {
            var fullLogType = base.Log(location, logInfo);
            var logString = $"ClientIpAdresi:{fullLogType.ClientIpAdresi},FullUrl:{fullLogType.FullUrl},Controller:{fullLogType.Controller},Action:{fullLogType.Action},Parametre:{fullLogType.Parametre},UserKey:{fullLogType.UserKey},LogTuru:{fullLogType.LogTuru},LogKategorisi:{fullLogType.LogKategori},TarihSaat:{fullLogType.TarihSaat},LogIcerik:{fullLogType.LogIcerik}";

            System.Diagnostics.Debug.WriteLine("----------------------------------LOG START--------------------------------------");
            System.Diagnostics.Debug.WriteLine(logString);
            System.Diagnostics.Debug.WriteLine("----------------------------------LOG END----------------------------------------");
            return fullLogType;
        }
    }
}
