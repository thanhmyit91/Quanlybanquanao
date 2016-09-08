using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class OutputCtr
    {
        public static void Insert(OutputOB ob, bool isSale)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Output_Add");
                objIData.AddParameter("@Output_ID", ob.Output_ID);
                objIData.AddParameter("@Output_Date", ob.Output_Date);
                objIData.AddParameter("@Output_CustomerID", ob.Output_CustomerID);
                objIData.AddParameter("@Output_Description", ob.Output_Description);
                objIData.AddParameter("@Output_Total", ob.Output_Total);
                objIData.AddParameter("@Output_Vouchers", ob.Output_Vouchers);
                objIData.AddParameter("@CreatedBy", ob.CreatedBy);
                objIData.ExecNonQuery();

                foreach(OutputDetailOB obDetail in ob.LstOutputDetail)
                {
                    obDetail.OutputDetail_OutputID = ob.Output_ID;
                    OutputDetailCtr.Insert(objIData, obDetail);
                    if (isSale)
                    {
                        ProductQuantityCtr.ProductQuantity_OutputSale(objIData, obDetail.OutputDetail_ProductID, obDetail.OutputDetail_Quantity - obDetail.OutputDetail_QuantityOld);
                    }
                    else
                    {
                        ProductQuantityCtr.ProductQuantity_Output(objIData, obDetail.OutputDetail_ProductID, obDetail.OutputDetail_Quantity - obDetail.OutputDetail_QuantityOld);
                    }
                }
                objIData.CommitTransaction();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
            finally
            {
                objIData.Disconnect();
            }
        }

        public static void Delete(OutputOB ob, bool isSale)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Output_Delete");
                objIData.AddParameter("@Output_ID", ob.Output_ID);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
                objIData.ExecNonQuery();
                foreach (OutputDetailOB obDetail in ob.LstOutputDetail)
                {
                    if (isSale)
                    {
                        ProductQuantityCtr.ProductQuantity_OutputSale(objIData, obDetail.OutputDetail_ProductID, obDetail.OutputDetail_Quantity - obDetail.OutputDetail_QuantityOld);
                    }
                    else
                    {
                        ProductQuantityCtr.ProductQuantity_Output(objIData, obDetail.OutputDetail_ProductID, obDetail.OutputDetail_Quantity - obDetail.OutputDetail_QuantityOld);
                    }
                }
                objIData.CommitTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
        }
        public static DataTable Seach(params object[] objkeywords)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Output_Seach");
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
        public static OutputOB Select(string Output_ID)
        {
            OutputOB ob = new OutputOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Output_Select");
                objIData.AddParameter("@Output_ID", Output_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new OutputOB(data.Rows[0]);
                    ob.LstOutputDetail = OutputDetailCtr.SelectList(Output_ID);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objIData.Disconnect();
            }
            return ob;
        }
    }
}
