namespace Log.WebApi.Data
{
    internal interface ILocation
    {
        string FullUrl { get; set; }
        string Controller { get; set; }
        string Action { get; set; }
        string Parametre { get; set; }
    }
}
