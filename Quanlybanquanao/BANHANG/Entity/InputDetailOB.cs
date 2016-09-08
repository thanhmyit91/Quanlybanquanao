using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entity
{
    public class InputDetailOB
    {
        private string _InputDetail_ProductID;

        public string InputDetail_ProductID
        {
            get { return _InputDetail_ProductID; }
            set { _InputDetail_ProductID = value; }
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
        private string _InputDetail_InputID;

        public string InputDetail_InputID
        {
            get { return _InputDetail_InputID; }
            set { _InputDetail_InputID = value; }
        }

        private int _InputDetail_Quantity;

        public int InputDetail_Quantity
        {
            get { return _InputDetail_Quantity; }
            set
            {
                _InputDetail_Quantity = value;
            }
        }
        private decimal _InputDetail_Price;

        public decimal InputDetail_Price
        {
            get { return _InputDetail_Price ; }
            set 
            {
                _InputDetail_Price = value;
            }
        }
       
        //Truong tu dong tinh theo du lieu co sang
        private decimal _InputDetail_Total;

        public decimal InputDetail_Total
        {
            get
            {
                return _InputDetail_Total ; 
            }
            set { _InputDetail_Total = value; }
        }
        //-1: Mặc đinh; 0: Thêm; 1: Sửa; 2: Xóa
        private int _Flat;

        public int Flat
        {
            get { return _Flat; }
            set { _Flat = value; }
        }

        private int _InputDetail_QuantityOld;

        public int InputDetail_QuantityOld
        {
            get { return _InputDetail_QuantityOld; }
            set { _InputDetail_QuantityOld = value; }
        }

        public InputDetailOB()
        {
            this._Flat = 0;
            this._InputDetail_InputID = string.Empty;
            this._InputDetail_Price = 0;
            this._InputDetail_ProductID = string.Empty;
            this._InputDetail_Quantity = 0;
            this._InputDetail_QuantityOld = 0;
            this._InputDetail_Total = 0;
            this._Product_Name = string.Empty;
            this._Color_Name = string.Empty;
        }

        public InputDetailOB(DataRow row)
        {
            if (!Convert.IsDBNull(row["InputDetail_ProductID"])) this._InputDetail_ProductID = Convert.ToString(row["InputDetail_ProductID"]).Trim();
            if (!Convert.IsDBNull(row["InputDetail_InputID"])) this._InputDetail_InputID = Convert.ToString(row["InputDetail_InputID"]).Trim();
            if (!Convert.IsDBNull(row["InputDetail_Price"])) this._InputDetail_Price = Convert.ToDecimal(row["InputDetail_Price"]);
            if (!Convert.IsDBNull(row["InputDetail_Quantity"])) this._InputDetail_Quantity = Convert.ToInt32(row["InputDetail_Quantity"]);
            this._InputDetail_QuantityOld = this._InputDetail_Quantity;
            this._Flat = -1;
            if (!Convert.IsDBNull(row["Product_Name"])) this._Product_Name = Convert.ToString(row["Product_Name"]).Trim();
            if (!Convert.IsDBNull(row["Color_Name"])) this._Color_Name = Convert.ToString(row["Color_Name"]).Trim();

            this._InputDetail_Total = this._InputDetail_Price * this._InputDetail_Quantity;
        }

    }
}
