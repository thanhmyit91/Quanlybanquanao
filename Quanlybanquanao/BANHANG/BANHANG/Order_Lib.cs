using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data;
using Entity;
namespace BANHANG
{
    public class Order_Lib
    {
        //Kiểm tra sản phẩm bắn vào
        public static bool CheckProduct(string strProduct)
        {
            bool result = false;
            DataTable dtProduct = new DataTable();
            dtProduct = Datacache.GetProductCache().Copy();
            string expression = "Product_ID = '" + strProduct + "'";
            DataRow[] row = dtProduct.Select(expression);
            if (row.Length > 0)
            {
                result = true;
            }
            return result;
        }

        public static string getConfig(string strConfigID)
        {
            string strResult = string.Empty;
            DataRow Row = Datacache.GetConfigCache().Select("Config_ID='" + strConfigID+"'").FirstOrDefault();
            strResult = Row["Config_Value"].ToString();
            return strResult;
        }

        public static bool checkPrice(int iPrice_Type, string strPrice_Product)
        {
            DataRow[] dataRows = Datacache.GetPriceCache().Select("Price_Type=" + iPrice_Type.ToString() + " AND Price_Product = '" + strPrice_Product +"'");
            return dataRows.Count() > 0;
        }

        public static decimal getPrice(int iPrice_Type, string strPrice_Product)
        {
            DataRow row = Datacache.GetPriceCache().Select("Price_Type=" + iPrice_Type.ToString() + " AND Price_Product = '" + strPrice_Product + "'").FirstOrDefault();
            decimal iPrice = 0;
            decimal.TryParse(row["Price_Now"].ToString(), out iPrice);
            return iPrice;
        }

        public static bool checkProductQuantity(string strProductID,int iOrderQuantity)
        {
            bool result = false;
            DataTable data=new DataTable();
            object[] objKeywords = null;
            objKeywords = new object[] { "@ProductID", strProductID};
            data = ProductQuantityCtr.Select(objKeywords);
            if (data.Rows.Count > 0)
            {
                int iQuantity = Convert.ToInt32(data.Rows[0]["Quantity"]);
                result = iQuantity >= iOrderQuantity;
            }
            else
            {
                result = false;
            }
            return result;
        }
        
    }
}
