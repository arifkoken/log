namespace Log.WebApi.Mssql.Data.Db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logs_Nuget
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string ClientIpAdresi { get; set; }

        public string FullUrl { get; set; }

        [StringLength(250)]
        public string Controller { get; set; }

        [StringLength(250)]
        public string Action { get; set; }

        public string Parametre { get; set; }

        [StringLength(250)]
        public string LogTuru { get; set; }

        [StringLength(250)]
        public string LogKategori { get; set; }

        [StringLength(250)]
        public string UserEmail { get; set; }

        public string LogIcerik { get; set; }

        public DateTime? TarihSaat { get; set; }
    }
}
