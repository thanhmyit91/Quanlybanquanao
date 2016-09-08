using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class OrderDetailOB
    {
        private string _OrderDetail_ProductID;

        public string OrderDetail_ProductID
        {
            get { return _OrderDetail_ProductID; }
            set { _OrderDetail_ProductID = value; }
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
        private string _OrderDetail_OrderID;

        public string OrderDetail_OrderID
        {
            get { return _OrderDetail_OrderID; }
            set { _OrderDetail_OrderID = value; }
        }

        private int _OrderDetail_PriceType;

        public int OrderDetail_PriceType
        {
            get { return _OrderDetail_PriceType; }
            set { _OrderDetail_PriceType = value; }
        }

        private int _OrderDetail_Quantity;

        public int OrderDetail_Quantity
        {
            get { return _OrderDetail_Quantity; }
            set
            {
                _OrderDetail_Quantity = value;
            }
        }
        private decimal _OrderDetail_Price;

        public decimal OrderDetail_Price
        {
            get { return _OrderDetail_Price ; }
            set 
            {
                _OrderDetail_Price = value;
            }
        }
        private decimal _OrderDetail_Sale;

        public decimal OrderDetail_Sale
        {
            get { return _OrderDetail_Sale; }
            set { _OrderDetail_Sale = value; }
        }
        
        //Truong tu dong tinh theo du lieu co sang
        private decimal _OrderDetail_Total;

        public decimal OrderDetail_Total
        {
            get
            {
                return _OrderDetail_Total ; 
            }
            set { _OrderDetail_Total = value; }
        }
        //-1: Mặc đinh; 0: Thêm; 1: Sửa; 2: Xóa
        private int _Flat;

        public int Flat
        {
            get { return _Flat; }
            set { _Flat = value; }
        }

        private int _OrderDetail_QuantityOld;

        public int OrderDetail_QuantityOld
        {
            get { return _OrderDetail_QuantityOld; }
            set { _OrderDetail_QuantityOld = value; }
        }

        public OrderDetailOB()
        {
            this._Flat = 0;
            this._OrderDetail_ProductID = string.Empty;
            this._Product_Name = string.Empty;
            this._Color_Name = string.Empty;
            this._OrderDetail_OrderID = string.Empty;
            this._OrderDetail_PriceType = 0;
            this._OrderDetail_Quantity = 0;
            this._OrderDetail_QuantityOld = 0;
            this._OrderDetail_Price = 0;
            this._OrderDetail_Sale = 0;
            this._OrderDetail_Total = 0;
        }

        public OrderDetailOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["OrderDetail_ProductID"])) this._OrderDetail_ProductID = Convert.ToString(row["OrderDetail_ProductID"]).Trim();
            if (!Convert.IsDBNull(row["Product_Name"])) this._Product_Name = Convert.ToString(row["Product_Name"]).Trim();
            if (!Convert.IsDBNull(row["Color_Name"])) this._Color_Name = Convert.ToString(row["Color_Name"]).Trim();
            if (!Convert.IsDBNull(row["OrderDetail_OrderID"])) this._OrderDetail_OrderID = Convert.ToString(row["OrderDetail_OrderID"]).Trim();
            if (!Convert.IsDBNull(row["OrderDetail_Price"])) this._OrderDetail_Price = Convert.ToDecimal(row["OrderDetail_Price"]);
            if (!Convert.IsDBNull(row["OrderDetail_Sale"])) this._OrderDetail_Sale = Convert.ToDecimal(row["OrderDetail_Sale"]);
            if (!Convert.IsDBNull(row["OrderDetail_PriceType"])) this._OrderDetail_PriceType = Convert.ToInt32(row["OrderDetail_PriceType"]);
            if (!Convert.IsDBNull(row["OrderDetail_Quantity"])) this._OrderDetail_Quantity = Convert.ToInt32(row["OrderDetail_Quantity"]);
            this._OrderDetail_QuantityOld = this._OrderDetail_Quantity;
            this._Flat = -1;
           

            this._OrderDetail_Total = (this._OrderDetail_Price * this._OrderDetail_Quantity)+(this._OrderDetail_Quantity*this._OrderDetail_Sale);
        }

    }
}
