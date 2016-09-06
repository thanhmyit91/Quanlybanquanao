using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataAccess
{
    public class Data
    {
        public static DATABASETYPE Loai;
         // Methods
        public static IData CreateData()
        {
            obConnect ob = new obConnect();
            ob.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString.Trim();
            ob.Type = ConfigurationManager.ConnectionStrings["Default"].ProviderName.Trim();
            return CreateData(ob);
        }

        public static IData CreateData(obConnect ob)
        {
            if (ob.Type == DATABASETYPE.SQLSERVER.ToString())
            {
                Loai = DATABASETYPE.SQLSERVER;
                return new SQLData(ob.ConnectionString);
            }
            return null;
        }

        // Database Types
        public enum DATABASETYPE
        {
            SQLSERVER,
            MySQL,
            MsAccess
        }
    }

    
}
