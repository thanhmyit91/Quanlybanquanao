using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class ModelOB
    {
        private string _Model_ID;
        private string _Model_Name;
        private string _Model_Description;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;
        private int _Model_CategoryID;

        public int Model_CategoryID
        {
            get { return _Model_CategoryID; }
            set { _Model_CategoryID = value; }
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

        public string Model_Description
        {
            get { return _Model_Description; }
            set { _Model_Description = value; }
        }

        public string Model_Name
        {
            get { return _Model_Name; }
            set { _Model_Name = value; }
        }

        public string Model_ID
        {
            get { return _Model_ID; }
            set { _Model_ID = value; }
        }

        public ModelOB()
        {
            this._Model_ID = string.Empty;
            this._Model_CategoryID = 0;
            this._Model_Name = string.Empty;
            this._Model_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public ModelOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Model_ID"])) this._Model_ID = Convert.ToString(row["Model_ID"]).Trim();
            if (!Convert.IsDBNull(row["Model_CategoryID"])) this.Model_CategoryID = Convert.ToInt32(row["Model_CategoryID"]);
            if (!Convert.IsDBNull(row["Model_Name"])) this._Model_Name = Convert.ToString(row["Model_Name"]).Trim();
            if (!Convert.IsDBNull(row["Model_Description"])) this._Model_Description = Convert.ToString(row["Model_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
