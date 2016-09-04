using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class CustomerOB
    {
        private string _Customer_ID;
        private string _Customer_Name;
        private string _Customer_Phone;
        private string _Customer_Address;
        private string _Customer_Email;
        private string _Customer_Facbook;
        private string _Customer_Zalo;
        private string _Customer_Description;
        private bool _IsActive;
        private bool _IsDelete;
        private DateTime? _CreatedDate;
        private string _CreatedBy;
        private DateTime? _ModifiedDate;
        private string _ModifiedBy;
       
        public string Customer_Zalo
        {
            get { return _Customer_Zalo; }
            set { _Customer_Zalo = value; }
        }

        public string Customer_Facbook
        {
            get { return _Customer_Facbook; }
            set { _Customer_Facbook = value; }
        }

        public string Customer_Email
        {
            get { return _Customer_Email; }
            set { _Customer_Email = value; }
        }

        public string Customer_Address
        {
            get { return _Customer_Address; }
            set { _Customer_Address = value; }
        }

        public string Customer_Phone
        {
            get { return _Customer_Phone; }
            set { _Customer_Phone = value; }
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

        public string Customer_Description
        {
            get { return _Customer_Description; }
            set { _Customer_Description = value; }
        }

        public string Customer_Name
        {
            get { return _Customer_Name; }
            set { _Customer_Name = value; }
        }

        public string Customer_ID
        {
            get { return _Customer_ID; }
            set { _Customer_ID = value; }
        }

        public CustomerOB()
        {
            this._Customer_ID = string.Empty;
            this._Customer_Name = string.Empty;
            this._Customer_Address = string.Empty;
            this._Customer_Email = string.Empty;
            this._Customer_Facbook = string.Empty;
            this._Customer_Phone = string.Empty;
            this._Customer_Zalo = string.Empty;
            this._Customer_Description = string.Empty;
            this._IsActive = true;
            this._IsDelete = false;
            this._CreatedDate = null;
            this._CreatedBy = string.Empty;
            this._ModifiedDate = null;
            this._ModifiedBy = string.Empty;
        }

        public CustomerOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Customer_ID"])) this._Customer_ID = Convert.ToString(row["Customer_ID"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Name"])) this._Customer_Name = Convert.ToString(row["Customer_Name"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Address"])) this._Customer_Address = Convert.ToString(row["Customer_Address"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Email"])) this._Customer_Email = Convert.ToString(row["Customer_Email"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Facbook"])) this._Customer_Facbook = Convert.ToString(row["Customer_Facbook"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Phone"])) this._Customer_Phone = Convert.ToString(row["Customer_Phone"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Zalo"])) this._Customer_Zalo = Convert.ToString(row["Customer_Zalo"]).Trim();
            if (!Convert.IsDBNull(row["Customer_Description"])) this._Customer_Description = Convert.ToString(row["Customer_Description"]).Trim();
            if (!Convert.IsDBNull(row["IsActive"])) this._IsActive = Convert.ToBoolean(row["IsActive"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
