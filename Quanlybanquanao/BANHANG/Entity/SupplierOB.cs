using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class SupplierOB
    {
        private string _Supplier_ID;
        private string _Supplier_Name;
        private string _Supplier_Phone;
        private string _Supplier_Address;
        private string _Supplier_Email;
        private string _Supplier_Facbook;
        private string _Supplier_Zalo;
        private string _Supplier_Description;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;
       
        public string Supplier_Zalo
        {
            get { return _Supplier_Zalo; }
            set { _Supplier_Zalo = value; }
        }

        public string Supplier_Facbook
        {
            get { return _Supplier_Facbook; }
            set { _Supplier_Facbook = value; }
        }

        public string Supplier_Email
        {
            get { return _Supplier_Email; }
            set { _Supplier_Email = value; }
        }

        public string Supplier_Address
        {
            get { return _Supplier_Address; }
            set { _Supplier_Address = value; }
        }

        public string Supplier_Phone
        {
            get { return _Supplier_Phone; }
            set { _Supplier_Phone = value; }
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

        public string Supplier_Description
        {
            get { return _Supplier_Description; }
            set { _Supplier_Description = value; }
        }

        public string Supplier_Name
        {
            get { return _Supplier_Name; }
            set { _Supplier_Name = value; }
        }

        public string Supplier_ID
        {
            get { return _Supplier_ID; }
            set { _Supplier_ID = value; }
        }

        public SupplierOB()
        {
            this._Supplier_ID = string.Empty;
            this._Supplier_Name = string.Empty;
            this._Supplier_Address = string.Empty;
            this._Supplier_Email = string.Empty;
            this._Supplier_Facbook = string.Empty;
            this._Supplier_Phone = string.Empty;
            this._Supplier_Zalo = string.Empty;
            this._Supplier_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public SupplierOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Supplier_ID"])) this._Supplier_ID = Convert.ToString(row["Supplier_ID"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Name"])) this._Supplier_Name = Convert.ToString(row["Supplier_Name"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Address"])) this._Supplier_Address = Convert.ToString(row["Supplier_Address"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Email"])) this._Supplier_Email = Convert.ToString(row["Supplier_Email"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Facbook"])) this._Supplier_Facbook = Convert.ToString(row["Supplier_Facbook"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Phone"])) this._Supplier_Phone = Convert.ToString(row["Supplier_Phone"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Zalo"])) this._Supplier_Zalo = Convert.ToString(row["Supplier_Zalo"]).Trim();
            if (!Convert.IsDBNull(row["Supplier_Description"])) this._Supplier_Description = Convert.ToString(row["Supplier_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
