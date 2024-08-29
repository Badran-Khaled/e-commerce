using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireWolf
{
    internal static class Connections
    {
        public const string sqlConStr = """
            Server = .;
            Database = dbFireWolf;
            Integrated Security=SSPI;
            TrustServerCertificate=True;
            Trusted_Connection=True;
            """;
          //  "MyCon": "Server=DESKTOP-UD70J1L\\SQLEXPRESS; Database= EVCharge2;Integrated Security=SSPI; TrustServerCertificate=True; Trusted_Connection=True;"
    }
}
