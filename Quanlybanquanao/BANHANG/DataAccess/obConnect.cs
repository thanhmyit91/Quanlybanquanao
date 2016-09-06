using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class obConnect
    {
        private string _ConnectionString;
        private string _Type;

        public obConnect()
        {
            _ConnectionString = "";
            _Type = "";
        }
        public obConnect(string strConnectString, string type)
        {
            _ConnectionString = strConnectString;
            _Type = type;
        }
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
