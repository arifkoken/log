namespace Log.WebApi.Data
{
    public class FullLogType:Log.Data.FullLogType, ILocation
    {
        public string ClientIpAdresi { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Parametre { get; set; }
        public string FullUrl { get; set; }
    }
}
