using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class OrderOB
    {
        private string _Order_ID = string.Empty;

        public string Order_ID
        {
            get { return _Order_ID; }
            set { _Order_ID = value; }
        }
        private DateTime? _Order_Date=null;

        public DateTime? Order_Date
        {
            get { return _Order_Date; }
            set { _Order_Date = value; }
        }
        private string _Order_CustomerID = string.Empty;

        public string Order_CustomerID
        {
            get { return _Order_CustomerID; }
            set { _Order_CustomerID = value; }
        }
        private string _Order_Description=string.Empty;

        public string Order_Description
        {
            get { return _Order_Description; }
            set { _Order_Description = value; }
        }
        private int _Order_IsSend=0;

        public int Order_IsSend
        {
            get { return _Order_IsSend; }
            set { _Order_IsSend = value; }
        }
        private int _Order_SendType=-1;

        public int Order_SendType
        {
            get { return _Order_SendType; }
            set { _Order_SendType = value; }
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
        private int _Order_IsVoucher=0;

        public int Order_IsVoucher
        {
            get { return _Order_IsVoucher; }
            set { _Order_IsVoucher = value; }
        }
        private string _Order_VoucherID=string.Empty;

        public string Order_VoucherID
        {
            get { return _Order_VoucherID; }
            set { _Order_VoucherID = value; }
        }
        private int _Order_IsOutput=0;

        public int Order_IsOutput
        {
            get { return _Order_IsOutput; }
            set { _Order_IsOutput = value; }
        }
        private string _Order_OutputID=string.Empty;

        public string Order_OutputID
        {
            get { return _Order_OutputID; }
            set { _Order_OutputID = value; }
        }
        private decimal _Order_SendMoney=0;

        public decimal Order_SendMoney
        {
            get { return _Order_SendMoney; }
            set { _Order_SendMoney = value; }
        }
        private decimal _Order_Total=0;

        public decimal Order_Total
        {
            get { return _Order_Total; }
            set { _Order_Total = value; }
        }
        private decimal _Order_TotalVAT=0;

        public decimal Order_TotalVAT
        {
            get { return _Order_TotalVAT; }
            set { _Order_TotalVAT = value; }
        }
        private float _Order_VAT=0;

        public float Order_VAT
        {
            get { return _Order_VAT; }
            set { _Order_VAT = value; }
        }
        private decimal _Order_SaleMoney=0;

        public decimal Order_SaleMoney
        {
            get { return _Order_SaleMoney; }
            set { _Order_SaleMoney = value; }
        }

        private List<OrderDetailOB> _lstOrderDetail=null;

        public List<OrderDetailOB> LstOrderDetail
        {
            get { return _lstOrderDetail; }
            set { _lstOrderDetail = value; }
        }
        public OrderOB()
        {
            this._CreatedBy = string.Empty;
            this._CreatedDate = null;
            this._IsDelete = false;
            this._ModifiedBy = string.Empty;
            this._ModifiedDate = null;
            this._Order_CustomerID = string.Empty;
            this._Order_Date = DateTime.Now;
            this._Order_Description = string.Empty;
            this._Order_ID = string.Empty;
            this._Order_IsOutput = 0;
            this._Order_IsSend = 0;
            this._Order_IsVoucher = 0;
            this._Order_OutputID = string.Empty;
            this._Order_SaleMoney = 0;
            this._Order_SendMoney = 0;
            this._Order_SendType = -1;
            this._Order_Total = 0;
            this._Order_TotalVAT = 0;
            this._Order_VAT = 0;
            this._Order_VoucherID = string.Empty;
            this._lstOrderDetail = new List<OrderDetailOB>();
        }

        public OrderOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["Order_ID"])) this._Order_ID = Convert.ToString(row["Order_ID"]).Trim();
            if (!Convert.IsDBNull(row["Order_Date"])) this._Order_Date = (DateTime)row["Order_Date"];
            if (!Convert.IsDBNull(row["Order_CustomerID"])) this._Order_CustomerID = Convert.ToString(row["Order_CustomerID"]).Trim();
            if (!Convert.IsDBNull(row["Order_Description"])) this._Order_Description = Convert.ToString(row["Order_Description"]).Trim();
            if (!Convert.IsDBNull(row["Order_IsSend"])) this._Order_IsSend = Convert.ToInt32(row["Order_IsSend"]);
            if (!Convert.IsDBNull(row["Order_SendType"])) this._Order_SendType = Convert.ToInt32(row["Order_SendType"]);
            if (!Convert.IsDBNull(row["Order_IsVoucher"])) this._Order_IsVoucher = Convert.ToInt32(row["Order_IsVoucher"]);
            if (!Convert.IsDBNull(row["Order_VoucherID"])) this._Order_VoucherID = Convert.ToString(row["Order_VoucherID"]).Trim();
            if (!Convert.IsDBNull(row["Order_IsOutput"])) this._Order_IsOutput = Convert.ToInt32(row["Order_IsOutput"]);
            if (!Convert.IsDBNull(row["Order_OutputID"])) this._Order_OutputID = Convert.ToString(row["Order_OutputID"]).Trim();
            if (!Convert.IsDBNull(row["Order_SendMoney"])) this._Order_SendMoney = Convert.ToDecimal(row["Order_SendMoney"]);
            if (!Convert.IsDBNull(row["Order_Total"])) this._Order_Total = Convert.ToDecimal(row["Order_Total"]);
            if (!Convert.IsDBNull(row["Order_TotalVAT"])) this._Order_TotalVAT = Convert.ToDecimal(row["Order_TotalVAT"]);
            if (!Convert.IsDBNull(row["Order_VAT"])) this._Order_VAT = float.Parse(row["Order_VAT"].ToString());
            if (!Convert.IsDBNull(row["Order_SaleMoney"])) this._Order_SaleMoney = Convert.ToDecimal(row["Order_SaleMoney"]);
            if (!Convert.IsDBNull(row["IsDelete"])) this._IsDelete = Convert.ToBoolean(row["IsDelete"]);
            if (!Convert.IsDBNull(row["CreatedDate"])) this._CreatedDate = (DateTime)row["CreatedDate"];
            if (!Convert.IsDBNull(row["CreatedBy"])) this._ModifiedBy = Convert.ToString(row["CreatedBy"]).Trim();
            if (!Convert.IsDBNull(row["ModifiedDate"])) this._ModifiedDate = (DateTime)row["ModifiedDate"];
            if (!Convert.IsDBNull(row["ModifiedBy"])) this._ModifiedBy = Convert.ToString(row["ModifiedBy"]).Trim();
        }
    }
}
