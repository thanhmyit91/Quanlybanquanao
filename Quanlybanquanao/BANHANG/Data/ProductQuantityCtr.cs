using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class ProductQuantityCtr
    {
        public static void Insert(IData objIData, string ProductID, int Quantity)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Add");
                objIData.AddParameter("@ProductID", ProductID);
                objIData.AddParameter("@Quantity", Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }

        public static void ProductQuantity_Input(IData objIData, string ProductID, int Quantity)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Input");
                objIData.AddParameter("@ProductID", ProductID);
                objIData.AddParameter("@Quantity", Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }

        public static void ProductQuantity_Output(IData objIData, string ProductID, int Quantity)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Output");
                objIData.AddParameter("@ProductID", ProductID);
                objIData.AddParameter("@Quantity", Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }

        public static void ProductQuantity_OutputSale(IData objIData, string ProductID, int Quantity)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_OutputSale");
                objIData.AddParameter("@ProductID", ProductID);
                objIData.AddParameter("@Quantity", Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }

        public static void ProductQuantity_Sale(IData objIData, string ProductID, int Quantity)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Sale");
                objIData.AddParameter("@ProductID", ProductID);
                objIData.AddParameter("@Quantity", Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }

        public static void ProductQuantity_Update(IData objIData, string ProductID, int Quantity)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Update");
                objIData.AddParameter("@ProductID", ProductID);
                objIData.AddParameter("@Quantity", Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }

        public static DataTable Select(params object[] objkeywords)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Select");
                objIData.AddParameter(objkeywords);
                data = objIData.ExecStoreToDataTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
            return data;
        }

        public static DataTable Seach(params object[] objkeywords)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_ProductQuantity_Seach");
                objIData.AddParameter(objkeywords);
                data = objIData.ExecStoreToDataTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
            return data;
        }
    }
}
