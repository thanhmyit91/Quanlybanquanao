using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class UserOB
    {
        private string _User_ID;
        private string _User_Name;
        private string _User_Pass;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;

        public string ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }

        public DateTime? ModifiedDate
        {
            get { return _ModifiedDate; }
            set { _ModifiedDate = value; }
        }

        public string CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public DateTime? CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        public bool IsDelete
        {
            get { return _IsDelete; }
            set { _IsDelete = value; }
        }

        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }

        public string User_Pass
        {
            get { return _User_Pass; }
            set { _User_Pass = value; }
        }

        public string User_Name
        {
            get { return _User_Name; }
            set { _User_Name = value; }
        }

        public string User_ID
        {
            get { return _User_ID; }
            set { _User_ID = value; }
        }

        public UserOB()
        {
            this._User_ID = string.Empty;
            this._User_Name = string.Empty;
            this._User_Pass = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public UserOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["User_ID"])) this._User_ID = Convert.ToString(row["User_ID"]).Trim();
            if (!Convert.IsDBNull(row["User_Name"])) this._User_Name = Convert.ToString(row["User_Name"]).Trim();
            if (!Convert.IsDBNull(row["User_Pass"])) this._User_Pass = Convert.ToString(row["User_Pass"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = Convert.ToDateTime(row["CreatedDate"]);
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = Convert.ToDateTime(row["ModifiedDate"]);
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
