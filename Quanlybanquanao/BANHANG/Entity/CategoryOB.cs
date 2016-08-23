using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class CategoryOB
    {
        private int _Category_ID;
        private string _Category_Name;
        private string _Category_Description;
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

        public string Category_Description
        {
            get { return _Category_Description; }
            set { _Category_Description = value; }
        }

        public string Category_Name
        {
            get { return _Category_Name; }
            set { _Category_Name = value; }
        }

        public int Category_ID
        {
            get { return _Category_ID; }
            set { _Category_ID = value; }
        }

        public CategoryOB()
        {
            this._Category_ID = 0;
            this._Category_Name = string.Empty;
            this._Category_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public CategoryOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Category_ID"])) this._Category_ID = Convert.ToInt32(row["Category_ID"]);
            if (!Convert.IsDBNull(row["Category_Name"])) this._Category_Name = Convert.ToString(row["Category_Name"]).Trim();
            if (!Convert.IsDBNull(row["Category_Description"])) this._Category_Description = Convert.ToString(row["Category_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
