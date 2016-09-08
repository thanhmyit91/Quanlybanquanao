using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class PaymentsOB
    {
        private string _Payments_ID = string.Empty;

        public string Payments_ID
        {
            get { return _Payments_ID; }
            set { _Payments_ID = value; }
        }
        private DateTime? _Payments_Date=null;

        public DateTime? Payments_Date
        {
            get { return _Payments_Date; }
            set { _Payments_Date = value; }
        }
        private string _Payments_CustomerID = string.Empty;

        public string Payments_CustomerID
        {
            get { return _Payments_CustomerID; }
            set { _Payments_CustomerID = value; }
        }
        private string _Payments_Description=string.Empty;

        public string Payments_Description
        {
            get { return _Payments_Description; }
            set { _Payments_Description = value; }
        }
        private int _Payments_Type = 0;

        public int Payments_Type
        {
            get { return _Payments_Type; }
            set { _Payments_Type = value; }
        }
      
        private bool _IsDelete = false;

        public bool IsDelete
        {
            get { return _IsDelete; }
            set { _IsDelete = value; }
        }
        private DateTime? _CreatedDate=null;

        public DateTime? CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        private string _CreatedBy=string.Empty;

        public string CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        private DateTime? _ModifiedDate=null;

        public DateTime? ModifiedDate
        {
            get { return _ModifiedDate; }
            set { _ModifiedDate = value; }
        }
        private string _ModifiedBy=string.Empty;

        public string ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }

        private string _Payments_Vouchers = string.Empty;

        public string Payments_Vouchers
        {
            get { return _Payments_Vouchers; }
            set { _Payments_Vouchers = value; }
        }

        private decimal _Payments_Amount = 0;

        public decimal Payments_Amount
        {
            get { return _Payments_Amount; }
            set { _Payments_Amount = value; }
        }
       
        public PaymentsOB()
        {
            this._CreatedBy = string.Empty;
            this._CreatedDate = null;
            this._IsDelete = false;
            this._ModifiedBy = string.Empty;
            this._ModifiedDate = null;
            this._Payments_CustomerID = string.Empty;
            this._Payments_Date = DateTime.Now;
            this._Payments_Description = string.Empty;
            this._Payments_ID = string.Empty;
            this._Payments_Amount = 0;
            this._Payments_Vouchers = string.Empty;
            this._Payments_Type = 0;
        }

        public PaymentsOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Payments_ID"])) this._Payments_ID = Convert.ToString(row["Payments_ID"]).Trim();
            if (!Convert.IsDBNull(row["Payments_Date"])) this._Payments_Date = (DateTime)row["Payments_Date"];
            if (!Convert.IsDBNull(row["Payments_Amount"])) this._Payments_Amount = Convert.ToDecimal(row["Payments_Amount"]);
            if (!Convert.IsDBNull(row["Payments_CustomerID"])) this._Payments_CustomerID = Convert.ToString(row["Payments_CustomerID"]).Trim();
            if (!Convert.IsDBNull(row["Payments_Vouchers"])) this._Payments_Vouchers = Convert.ToString(row["Payments_Vouchers"]).Trim();
            if (!Convert.IsDBNull(row["Payments_Description"])) this._Payments_Description = Convert.ToString(row["Payments_Description"]).Trim();
            if (!Convert.IsDBNull(row["Payments_Type"])) this._Payments_Type = Convert.ToInt32(row["Payments_Type"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
