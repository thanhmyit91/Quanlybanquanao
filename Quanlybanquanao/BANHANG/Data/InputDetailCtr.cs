using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class InputDetailCtr
    {
        public static void Insert(IData objIData,InputDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_InputDetail_Add");
                objIData.AddParameter("@InputDetail_ProductID", ob.InputDetail_ProductID);
                objIData.AddParameter("@InputDetail_InputID", ob.InputDetail_InputID);
                objIData.AddParameter("@InputDetail_Price", ob.InputDetail_Price);
                objIData.AddParameter("@InputDetail_Quantity", ob.InputDetail_Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static void Update(IData objIData, InputDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_InputDetail_Update");
                objIData.AddParameter("@InputDetail_ProductID", ob.InputDetail_ProductID);
                objIData.AddParameter("@InputDetail_InputID", ob.InputDetail_InputID);
                objIData.AddParameter("@InputDetail_Price", ob.InputDetail_Price);
                objIData.AddParameter("@InputDetail_Quantity", ob.InputDetail_Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static void Delete(IData objIData, InputDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_InputDetail_Delete");
                objIData.AddParameter("@InputDetail_ProductID", ob.InputDetail_ProductID);
                objIData.AddParameter("@InputDetail_InputID", ob.InputDetail_InputID);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static InputDetailOB Select(string InputDetail_ProductID, string InputDetail_InputID)
        {
            InputDetailOB ob = new InputDetailOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_InputDetail_Select");
                objIData.AddParameter("@InputDetail_ProductID", InputDetail_ProductID);
                objIData.AddParameter("@InputDetail_InputID", InputDetail_InputID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new InputDetailOB(data.Rows[0]);
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
        public static List<InputDetailOB> SelectList(string InputDetail_InputID)
        {
            List<InputDetailOB> lst = new List<InputDetailOB>();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_InputDetail_SelectLIST");
                objIData.AddParameter("@InputDetail_InputID", InputDetail_InputID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    InputDetailOB ob;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        ob = new InputDetailOB(data.Rows[i]);
                        lst.Add(ob);
                    }
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
            return lst;
        }
    }
}
