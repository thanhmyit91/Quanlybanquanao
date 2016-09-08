using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class SendTypeOB
    {
        private int _SendType_ID;
        private string _SendType_Name;
        private string _SendType_Description;
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

        public string SendType_Description
        {
            get { return _SendType_Description; }
            set { _SendType_Description = value; }
        }

        public string SendType_Name
        {
            get { return _SendType_Name; }
            set { _SendType_Name = value; }
        }

        public int SendType_ID
        {
            get { return _SendType_ID; }
            set { _SendType_ID = value; }
        }

        public SendTypeOB()
        {
            this._SendType_ID = 0;
            this._SendType_Name = string.Empty;
            this._SendType_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public SendTypeOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["SendType_ID"])) this._SendType_ID = Convert.ToInt32(row["SendType_ID"]);
            if (!Convert.IsDBNull(row["SendType_Name"])) this._SendType_Name = Convert.ToString(row["SendType_Name"]).Trim();
            if (!Convert.IsDBNull(row["SendType_Description"])) this._SendType_Description = Convert.ToString(row["SendType_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
