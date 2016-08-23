using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class ColorOB
    {
        private int _Color_ID;
        private string _Color_Name;
        private string _Color_Description;
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

        public string Color_Description
        {
            get { return _Color_Description; }
            set { _Color_Description = value; }
        }

        public string Color_Name
        {
            get { return _Color_Name; }
            set { _Color_Name = value; }
        }

        public int Color_ID
        {
            get { return _Color_ID; }
            set { _Color_ID = value; }
        }

        public ColorOB()
        {
            this._Color_ID = 0;
            this._Color_Name = string.Empty;
            this._Color_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public ColorOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Color_ID"])) this._Color_ID = Convert.ToInt32(row["Color_ID"]);
            if (!Convert.IsDBNull(row["Color_Name"])) this._Color_Name = Convert.ToString(row["Color_Name"]).Trim();
            if (!Convert.IsDBNull(row["Color_Description"])) this._Color_Description = Convert.ToString(row["Color_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
