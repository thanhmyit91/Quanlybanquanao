using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class OutputOB
    {
        private string _Output_ID = string.Empty;

        public string Output_ID
        {
            get { return _Output_ID; }
            set { _Output_ID = value; }
        }
        private DateTime? _Output_Date=null;

        public DateTime? Output_Date
        {
            get { return _Output_Date; }
            set { _Output_Date = value; }
        }
        private string _Output_CustomerID = string.Empty;

        public string Output_CustomerID
        {
            get { return _Output_CustomerID; }
            set { _Output_CustomerID = value; }
        }
        private string _Output_Description=string.Empty;

        public string Output_Description
        {
            get { return _Output_Description; }
            set { _Output_Description = value; }
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

        private string _Output_Vouchers;
        public string Output_Vouchers
        {
            get { return _Output_Vouchers; }
            set { _Output_Vouchers = value; }
        }

 
        private decimal _Output_Total=0;

        public decimal Output_Total
        {
            get { return _Output_Total; }
            set { _Output_Total = value; }
        }
        
        private List<OutputDetailOB> _lstOutputDetail=null;

        public List<OutputDetailOB> LstOutputDetail
        {
            get { return _lstOutputDetail; }
            set { _lstOutputDetail = value; }
        }
        public OutputOB()
        {
            this._CreatedBy = string.Empty;
            this._CreatedDate = null;
            this._IsDelete = false;
            this._ModifiedBy = string.Empty;
            this._ModifiedDate = null;
            this._Output_CustomerID = string.Empty;
            this._Output_Date = DateTime.Now;
            this._Output_Description = string.Empty;
            this._Output_ID = string.Empty;
            this._Output_Total = 0;
            this._Output_Vouchers = string.Empty;
            this._lstOutputDetail = new List<OutputDetailOB>();
        }

        public OutputOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Output_ID"])) this._Output_ID = Convert.ToString(row["Output_ID"]).Trim();
            if (!Convert.IsDBNull(row["Output_Date"])) this._Output_Date = (DateTime)row["Output_Date"];
            if (!Convert.IsDBNull(row["Output_CustomerID"])) this._Output_CustomerID = Convert.ToString(row["Output_CustomerID"]).Trim();
            if (!Convert.IsDBNull(row["Output_Description"])) this._Output_Description = Convert.ToString(row["Output_Description"]).Trim();
            if (!Convert.IsDBNull(row["Output_Vouchers"])) this._Output_Vouchers = Convert.ToString(row["Output_Vouchers"]).Trim();
            if (!Convert.IsDBNull(row["Output_Total"])) this._Output_Total = Convert.ToDecimal(row["Output_Total"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
