using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class ConfigOB
    {
        private string _Config_ID;
        private string _Config_Value;
        private string _Config_Name;
        private string _Config_Description;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;

        public string Config_Value
        {
            get { return _Config_Value; }
            set { _Config_Value = value; }
        }

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

        public string Config_Description
        {
            get { return _Config_Description; }
            set { _Config_Description = value; }
        }

        public string Config_Name
        {
            get { return _Config_Name; }
            set { _Config_Name = value; }
        }

        public string Config_ID
        {
            get { return _Config_ID; }
            set { _Config_ID = value; }
        }

        public ConfigOB()
        {
            this._Config_ID = string.Empty;
            this._Config_Value = string.Empty;
            this._Config_Name = string.Empty;
            this._Config_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public ConfigOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Config_ID"])) this._Config_ID = Convert.ToString(row["Config_ID"]).Trim();
            if (!Convert.IsDBNull(row["Config_Value"])) this._Config_Value = Convert.ToString(row["Config_Value"]).Trim();
            if (!Convert.IsDBNull(row["Config_Name"])) this._Config_Name = Convert.ToString(row["Config_Name"]).Trim();
            if (!Convert.IsDBNull(row["Config_Description"])) this._Config_Description = Convert.ToString(row["Config_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
