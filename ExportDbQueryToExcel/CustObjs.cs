using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandR
{

    public class CustomRegistrySettings
    {
        public string dbServer { get; set; }
        public string dbName { get; set; }
        public string dbUsername { get; set; }
        public string dbPassword { get; set; }

        public string dbQuery { get; set; }
    }

}
