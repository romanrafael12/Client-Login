using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Login
{
    public static class AppHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["Client_Login.Properties.Settings.cn"].ConnectionString; 
        
    }
}
