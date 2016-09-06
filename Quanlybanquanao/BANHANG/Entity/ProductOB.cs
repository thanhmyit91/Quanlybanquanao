using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class ProductOB
    {
        private string _Product_ID;
        private int _Product_ColorID;
        private string _Product_ModelID;
        private string _Product_Name;
        private string _Product_Description;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;

        public int Product_ColorID
        {
            get { return _Product_ColorID; }
            set { _Product_ColorID = value; }
        }

        public string Product_ModelID
        {
            get { return _Product_ModelID; }
            set { _Product_ModelID = value; }
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

        public string Product_Description
        {
            get { return _Product_Description; }
            set { _Product_Description = value; }
        }

        public string Product_Name
        {
            get { return _Product_Name; }
            set { _Product_Name = value; }
        }

        public string Product_ID
        {
            get { return _Product_ID; }
            set { _Product_ID = value; }
        }

        public ProductOB()
        {
            this._Product_ID = string.Empty;
            this._Product_ColorID = 0;
            this._Product_ModelID = string.Empty;
            this._Product_Name = string.Empty;
            this._Product_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public ProductOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Product_ID"])) this._Product_ID = Convert.ToString(row["Product_ID"]).Trim();
            if (!Convert.IsDBNull(row["Product_ColorID"])) this.Product_ColorID = Convert.ToInt32(row["Product_ColorID"]);
            if (!Convert.IsDBNull(row["Product_ModelID"])) this._Product_ModelID = Convert.ToString(row["Product_ModelID"]).Trim();
            if (!Convert.IsDBNull(row["Product_Name"])) this._Product_Name = Convert.ToString(row["Product_Name"]).Trim();
            if (!Convert.IsDBNull(row["Product_Description"])) this._Product_Description = Convert.ToString(row["Product_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
