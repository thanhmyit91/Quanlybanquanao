using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class OutputDetailOB
    {
        private string _OutputDetail_ProductID;

        public string OutputDetail_ProductID
        {
            get { return _OutputDetail_ProductID; }
            set { _OutputDetail_ProductID = value; }
        }
        private string _Product_Name;

        public string Product_Name
        {
            get { return _Product_Name; }
            set { _Product_Name = value; }
        }
        private string _Color_Name;

        public string Color_Name
        {
            get { return _Color_Name; }
            set { _Color_Name = value; }
        }
        private string _OutputDetail_OutputID;

        public string OutputDetail_OutputID
        {
            get { return _OutputDetail_OutputID; }
            set { _OutputDetail_OutputID = value; }
        }

        private int _OutputDetail_Quantity;

        public int OutputDetail_Quantity
        {
            get { return _OutputDetail_Quantity; }
            set
            {
                _OutputDetail_Quantity = value;
            }
        }
        private decimal _OutputDetail_Price;

        public decimal OutputDetail_Price
        {
            get { return _OutputDetail_Price ; }
            set 
            {
                _OutputDetail_Price = value;
            }
        }
       
        //Truong tu dong tinh theo du lieu co sang
        private decimal _OutputDetail_Total;

        public decimal OutputDetail_Total
        {
            get
            {
                return _OutputDetail_Total ; 
            }
            set { _OutputDetail_Total = value; }
        }
        //-1: Mặc đinh; 0: Thêm; 1: Sửa; 2: Xóa
        private int _Flat;

        public int Flat
        {
            get { return _Flat; }
            set { _Flat = value; }
        }

        private int _OutputDetail_QuantityOld;

        public int OutputDetail_QuantityOld
        {
            get { return _OutputDetail_QuantityOld; }
            set { _OutputDetail_QuantityOld = value; }
        }

        public OutputDetailOB()
        {
            this._Flat = 0;
            this._OutputDetail_OutputID = string.Empty;
            this._OutputDetail_Price = 0;
            this._OutputDetail_ProductID = string.Empty;
            this._OutputDetail_Quantity = 0;
            this._OutputDetail_QuantityOld = 0;
            this._OutputDetail_Total = 0;
            this._Product_Name = string.Empty;
            this._Color_Name = string.Empty;
        }

        public OutputDetailOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["OutputDetail_ProductID"])) this._OutputDetail_ProductID = Convert.ToString(row["OutputDetail_ProductID"]).Trim();
            if (!Convert.IsDBNull(row["OutputDetail_OutputID"])) this._OutputDetail_OutputID = Convert.ToString(row["OutputDetail_OutputID"]).Trim();
            if (!Convert.IsDBNull(row["OutputDetail_Price"])) this._OutputDetail_Price = Convert.ToDecimal(row["OutputDetail_Price"]);
            if (!Convert.IsDBNull(row["OutputDetail_Quantity"])) this._OutputDetail_Quantity = Convert.ToInt32(row["OutputDetail_Quantity"]);
            this._OutputDetail_QuantityOld = this._OutputDetail_Quantity;
            this._Flat = -1;
            if (!Convert.IsDBNull(row["Product_Name"])) this._Product_Name = Convert.ToString(row["Product_Name"]).Trim();
            if (!Convert.IsDBNull(row["Color_Name"])) this._Color_Name = Convert.ToString(row["Color_Name"]).Trim();

            this._OutputDetail_Total = this._OutputDetail_Price * this._OutputDetail_Quantity;
        }

    }
}
