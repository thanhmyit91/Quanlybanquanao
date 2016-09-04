using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class CustomerCtr
    {
        public static void Insert(CustomerOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_Add");
                objIData.AddParameter("@Customer_ID", ob.Customer_ID);
                objIData.AddParameter("@Customer_Name", ob.Customer_Name);
                objIData.AddParameter("@Customer_Phone", ob.Customer_Phone);
                objIData.AddParameter("@Customer_Address", ob.Customer_Address);
                objIData.AddParameter("@Customer_Email", ob.Customer_Email);
                objIData.AddParameter("@Customer_Facbook", ob.Customer_Facbook);
                objIData.AddParameter("@Customer_Zalo", ob.Customer_Zalo);
                objIData.AddParameter("@Customer_Description", ob.Customer_Description);
                objIData.AddParameter("@IsActive", ob.IsActive);
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
        public static void Update(CustomerOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_Update");
                objIData.AddParameter("@Customer_ID", ob.Customer_ID);
                objIData.AddParameter("@Customer_Name", ob.Customer_Name);
                objIData.AddParameter("@Customer_Phone", ob.Customer_Phone);
                objIData.AddParameter("@Customer_Address", ob.Customer_Address);
                objIData.AddParameter("@Customer_Email", ob.Customer_Email);
                objIData.AddParameter("@Customer_Facbook", ob.Customer_Facbook);
                objIData.AddParameter("@Customer_Zalo", ob.Customer_Zalo);
                objIData.AddParameter("@Customer_Description", ob.Customer_Description);
                objIData.AddParameter("@IsActive", ob.IsActive);
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
        public static void Delete(CustomerOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_Delete");
                objIData.AddParameter("@Customer_ID", ob.Customer_ID);
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
                objIData.CreateNewStoredProcedure("pr_Customer_Seach");
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
        public static DataTable Seach_Use(params object[] objkeywords)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_Seach_Use");
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
        public static CustomerOB Select(string Customer_ID)
        {
            CustomerOB ob = new CustomerOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_Select");
                objIData.AddParameter("@Customer_ID", Customer_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new CustomerOB(data.Rows[0]);
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
        public static CustomerOB SelectByPhone(string Customer_Phone)
        {
            CustomerOB ob = new CustomerOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_SelectByPhone");
                objIData.AddParameter("@Customer_Phone", Customer_Phone);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new CustomerOB(data.Rows[0]);
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
        public static bool Check(params object[] objkeywords)
        {
            bool bResult = false;
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Customer_Check");
                objIData.AddParameter(objkeywords);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    bResult = true;
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
            return bResult;
        }
    }
}
