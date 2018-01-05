using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log.Data.Enum;

namespace Log.Data
{
    public class FullLogType
    {
        public string UserKey { get; set; }
        public LogTuru LogTuru { get; set; }
        public string LogKategori { get; set; }
        public string LogIcerik { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
