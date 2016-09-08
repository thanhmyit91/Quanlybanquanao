using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class PriceTypeOB
    {
        private int _PriceType_ID;
        private string _PriceType_Name;
        private string _PriceType_Description;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;
        private bool _Isdefault;

        public bool Isdefault
        {
            get { return _Isdefault; }
            set { _Isdefault = value; }
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

        public string PriceType_Description
        {
            get { return _PriceType_Description; }
            set { _PriceType_Description = value; }
        }

        public string PriceType_Name
        {
            get { return _PriceType_Name; }
            set { _PriceType_Name = value; }
        }

        public int PriceType_ID
        {
            get { return _PriceType_ID; }
            set { _PriceType_ID = value; }
        }

        public PriceTypeOB()
        {
            this._PriceType_ID = 0;
            this._PriceType_Name = string.Empty;
            this._PriceType_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
            this._Isdefault = false;
        }

        public PriceTypeOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["PriceType_ID"])) this._PriceType_ID = Convert.ToInt32(row["PriceType_ID"]);
            if (!Convert.IsDBNull(row["PriceType_Name"])) this._PriceType_Name = Convert.ToString(row["PriceType_Name"]).Trim();
            if (!Convert.IsDBNull(row["PriceType_Description"])) this._PriceType_Description = Convert.ToString(row["PriceType_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["Isdefault"])) this._Isdefault = Convert.ToBoolean(row["Isdefault"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
