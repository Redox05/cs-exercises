using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static internal class ConnectionHelper
    {
        internal static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;
        }

    }
}
