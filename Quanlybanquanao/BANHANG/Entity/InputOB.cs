using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class InputOB
    {
        private string _Input_ID = string.Empty;

        public string Input_ID
        {
            get { return _Input_ID; }
            set { _Input_ID = value; }
        }
        private DateTime? _Input_Date=null;

        public DateTime? Input_Date
        {
            get { return _Input_Date; }
            set { _Input_Date = value; }
        }
        private string _Input_SupplierID = string.Empty;

        public string Input_SupplierID
        {
            get { return _Input_SupplierID; }
            set { _Input_SupplierID = value; }
        }
        private string _Input_Description=string.Empty;

        public string Input_Description
        {
            get { return _Input_Description; }
            set { _Input_Description = value; }
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
        private int _Input_IsVoucher=0;

        public int Input_IsVoucher
        {
            get { return _Input_IsVoucher; }
            set { _Input_IsVoucher = value; }
        }
        private string _Input_VoucherID=string.Empty;

        public string Input_VoucherID
        {
            get { return _Input_VoucherID; }
            set { _Input_VoucherID = value; }
        }

 
        private decimal _Input_Total=0;

        public decimal Input_Total
        {
            get { return _Input_Total; }
            set { _Input_Total = value; }
        }
        private decimal _Input_TotalVAT=0;

        public decimal Input_TotalVAT
        {
            get { return _Input_TotalVAT; }
            set { _Input_TotalVAT = value; }
        }
        private float _Input_VAT=0;

        public float Input_VAT
        {
            get { return _Input_VAT; }
            set { _Input_VAT = value; }
        }
        private decimal _Input_SaleMoney=0;

        public decimal Input_SaleMoney
        {
            get { return _Input_SaleMoney; }
            set { _Input_SaleMoney = value; }
        }

        private List<InputDetailOB> _lstInputDetail=null;

        public List<InputDetailOB> LstInputDetail
        {
            get { return _lstInputDetail; }
            set { _lstInputDetail = value; }
        }
        public InputOB()
        {
            this._CreatedBy = string.Empty;
            this._CreatedDate = null;
            this._IsDelete = false;
            this._ModifiedBy = string.Empty;
            this._ModifiedDate = null;
            this._Input_SupplierID = string.Empty;
            this._Input_Date = DateTime.Now;
            this._Input_Description = string.Empty;
            this._Input_ID = string.Empty;
            this._Input_IsVoucher = 0;
            this._Input_SaleMoney = 0;
            this._Input_Total = 0;
            this._Input_TotalVAT = 0;
            this._Input_VAT = 0;
            this._Input_VoucherID = string.Empty;
            this._lstInputDetail = new List<InputDetailOB>();
        }

        public InputOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Input_ID"])) this._Input_ID = Convert.ToString(row["Input_ID"]).Trim();
            if (!Convert.IsDBNull(row["Input_Date"])) this._Input_Date = (DateTime)row["Input_Date"];
            if (!Convert.IsDBNull(row["Input_SupplierID"])) this._Input_SupplierID = Convert.ToString(row["Input_SupplierID"]).Trim();
            if (!Convert.IsDBNull(row["Input_Description"])) this._Input_Description = Convert.ToString(row["Input_Description"]).Trim();
            if (!Convert.IsDBNull(row["Input_IsVoucher"])) this._Input_IsVoucher = Convert.ToInt32(row["Input_IsVoucher"]);
            if (!Convert.IsDBNull(row["Input_VoucherID"])) this._Input_VoucherID = Convert.ToString(row["Input_VoucherID"]).Trim();
            if (!Convert.IsDBNull(row["Input_Total"])) this._Input_Total = Convert.ToDecimal(row["Input_Total"]);
            if (!Convert.IsDBNull(row["Input_TotalVAT"])) this._Input_TotalVAT = Convert.ToDecimal(row["Input_TotalVAT"]);
            if (!Convert.IsDBNull(row["Input_VAT"])) this._Input_VAT = float.Parse(row["Input_VAT"].ToString());
            if (!Convert.IsDBNull(row["Input_SaleMoney"])) this._Input_SaleMoney = Convert.ToDecimal(row["Input_SaleMoney"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
