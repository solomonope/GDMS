using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace GDataLib.BO
{
    public class Config
    {
        public static string ConnString
        {
            get
            {
                return @"C:\Users\Folorunsho Solomon\Documents\GitHub\GDataManageSystem\GDMS\GDataWeb\App_Data\db\gtres.yap";//Path.Combine(Server.MapPath("~/App_Data/db"), "gtres");
            }
        }

        public static string MySqlConnString
        {
            get
            {
                return String.Format("server={0};uid={1};pwd={2};database={3}", "localhost", "root", "@Nolimitsouljar536", "geotrex");
            }
            
        }
    }
}
