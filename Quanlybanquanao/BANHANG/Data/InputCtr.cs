using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class InputCtr
    {
        public static void Insert(InputOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Input_Add");
                objIData.AddParameter("@Input_ID", ob.Input_ID);
                objIData.AddParameter("@Input_Date", ob.Input_Date);
                objIData.AddParameter("@Input_SupplierID", ob.Input_SupplierID);
                objIData.AddParameter("@Input_Description", ob.Input_Description);
                objIData.AddParameter("@Input_Total", ob.Input_Total);
                objIData.AddParameter("@Input_TotalVAT", ob.Input_TotalVAT);
                objIData.AddParameter("@Input_VAT", ob.Input_VAT);
                objIData.AddParameter("@Input_SaleMoney", ob.Input_SaleMoney);
                objIData.AddParameter("@CreatedBy", ob.CreatedBy);
                objIData.ExecNonQuery();

                foreach(InputDetailOB obDetail in ob.LstInputDetail)
                {
                    obDetail.InputDetail_InputID = ob.Input_ID;
                    InputDetailCtr.Insert(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Input(objIData, obDetail.InputDetail_ProductID, obDetail.InputDetail_Quantity - obDetail.InputDetail_QuantityOld);
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
        public static void Update(InputOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Input_Update");
                objIData.AddParameter("@Input_ID", ob.Input_ID);
                objIData.AddParameter("@Input_Description", ob.Input_Description);
                objIData.AddParameter("@Input_Total", ob.Input_Total);
                objIData.AddParameter("@Input_TotalVAT", ob.Input_TotalVAT);
                objIData.AddParameter("@Input_VAT", ob.Input_VAT);
                objIData.AddParameter("@Input_SaleMoney", ob.Input_SaleMoney);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
                objIData.ExecNonQuery();
                List<InputDetailOB> lstDetailInsert = new List<InputDetailOB>();
                List<InputDetailOB> lstDetailUpdate = new List<InputDetailOB>();
                List<InputDetailOB> lstDetailDelete = new List<InputDetailOB>();
                lstDetailInsert = ob.LstInputDetail.FindAll(o => o.Flat == 0);
                lstDetailUpdate = ob.LstInputDetail.FindAll(o => o.Flat == 1);
                lstDetailDelete = ob.LstInputDetail.FindAll(o => o.Flat == 2);
                //insert dong them moi
                foreach (InputDetailOB obDetail in lstDetailInsert)
                {
                    obDetail.InputDetail_InputID = ob.Input_ID;
                    InputDetailCtr.Insert(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Input(objIData, obDetail.InputDetail_ProductID, obDetail.InputDetail_Quantity - obDetail.InputDetail_QuantityOld);
                }
                //Cap nhat dong chinh sua
                foreach (InputDetailOB obDetail in lstDetailUpdate)
                {
                    obDetail.InputDetail_InputID = ob.Input_ID;
                    InputDetailCtr.Update(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Input(objIData, obDetail.InputDetail_ProductID, obDetail.InputDetail_Quantity - obDetail.InputDetail_QuantityOld);
                }
                //Xoa dong
                foreach (InputDetailOB obDetail in lstDetailDelete)
                {
                    obDetail.InputDetail_InputID = ob.Input_ID;
                    InputDetailCtr.Delete(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Input(objIData, obDetail.InputDetail_ProductID, -obDetail.InputDetail_QuantityOld);
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
        public static void Update_Status(params object[] objkeywords)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Input_Update_Status");
                objIData.AddParameter(objkeywords);
                objIData.ExecNonQuery();
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
        public static void Delete(InputOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Input_Delete");
                objIData.AddParameter("@Input_ID", ob.Input_ID);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
                objIData.ExecNonQuery();
                foreach (InputDetailOB obDetail in ob.LstInputDetail)
                {
                    ProductQuantityCtr.ProductQuantity_Input(objIData, obDetail.InputDetail_ProductID, -obDetail.InputDetail_QuantityOld);
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
                objIData.CreateNewStoredProcedure("pr_Input_Seach");
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
        public static InputOB Select(string Input_ID)
        {
            InputOB ob = new InputOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Input_Select");
                objIData.AddParameter("@Input_ID", Input_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new InputOB(data.Rows[0]);
                    ob.LstInputDetail = InputDetailCtr.SelectList(Input_ID);
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
