using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class OutputDetailCtr
    {
        public static void Insert(IData objIData,OutputDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_OutputDetail_Add");
                objIData.AddParameter("@OutputDetail_ProductID", ob.OutputDetail_ProductID);
                objIData.AddParameter("@OutputDetail_OutputID", ob.OutputDetail_OutputID);
                objIData.AddParameter("@OutputDetail_Price", ob.OutputDetail_Price);
                objIData.AddParameter("@OutputDetail_Quantity", ob.OutputDetail_Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static void Update(IData objIData, OutputDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_OutputDetail_Update");
                objIData.AddParameter("@OutputDetail_ProductID", ob.OutputDetail_ProductID);
                objIData.AddParameter("@OutputDetail_OutputID", ob.OutputDetail_OutputID);
                objIData.AddParameter("@OutputDetail_Price", ob.OutputDetail_Price);
                objIData.AddParameter("@OutputDetail_Quantity", ob.OutputDetail_Quantity);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static void Delete(IData objIData, OutputDetailOB ob)
        {
            try
            {
                objIData.CreateNewStoredProcedure("pr_OutputDetail_Delete");
                objIData.AddParameter("@OutputDetail_ProductID", ob.OutputDetail_ProductID);
                objIData.AddParameter("@OutputDetail_OutputID", ob.OutputDetail_OutputID);
                objIData.ExecNonQuery();
            }
            catch (Exception objEx)
            {
                objIData.RollBackTransaction();
                throw (objEx);
            }
        }
        public static OutputDetailOB Select(string OutputDetail_ProductID, string OutputDetail_OutputID)
        {
            OutputDetailOB ob = new OutputDetailOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_OutputDetail_Select");
                objIData.AddParameter("@OutputDetail_ProductID", OutputDetail_ProductID);
                objIData.AddParameter("@OutputDetail_OutputID", OutputDetail_OutputID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new OutputDetailOB(data.Rows[0]);
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
        public static List<OutputDetailOB> SelectList(string OutputDetail_OutputID)
        {
            List<OutputDetailOB> lst = new List<OutputDetailOB>();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_OutputDetail_SelectLIST");
                objIData.AddParameter("@OutputDetail_OutputID", OutputDetail_OutputID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    OutputDetailOB ob;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        ob = new OutputDetailOB(data.Rows[i]);
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
