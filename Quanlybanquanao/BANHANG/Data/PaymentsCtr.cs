using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class PaymentsCtr
    {
        public static void Insert(PaymentsOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Payments_Add");
                objIData.AddParameter("@Payments_ID", ob.Payments_ID);
                objIData.AddParameter("@Payments_Date", ob.Payments_Date);
                objIData.AddParameter("@Payments_CustomerID", ob.Payments_CustomerID);
                objIData.AddParameter("@Payments_Description", ob.Payments_Description);
                objIData.AddParameter("@Payments_Vouchers", ob.Payments_Vouchers);
                objIData.AddParameter("@Payments_Amount", ob.Payments_Amount);
                objIData.AddParameter("@Payments_Type", ob.Payments_Type);
                objIData.AddParameter("@CreatedBy", ob.CreatedBy);
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
        public static void Update(PaymentsOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Payments_Update");
                objIData.AddParameter("@Payments_ID", ob.Payments_ID);
                objIData.AddParameter("@Payments_Description", ob.Payments_Description);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
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
        public static void Delete(PaymentsOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Payments_Delete");
                objIData.AddParameter("@Payments_ID", ob.Payments_ID);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
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
        public static DataTable Seach(params object[] objkeywords)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Payments_Seach");
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
        public static PaymentsOB Select(string Payments_ID)
        {
            PaymentsOB ob = new PaymentsOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Payments_Select");
                objIData.AddParameter("@Payments_ID", Payments_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new PaymentsOB(data.Rows[0]);
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
