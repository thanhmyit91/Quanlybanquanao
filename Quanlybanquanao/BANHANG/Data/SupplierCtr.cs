using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class SupplierCtr
    {
        public static void Insert(SupplierOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Supplier_Add");
                objIData.AddParameter("@Supplier_ID", ob.Supplier_ID);
                objIData.AddParameter("@Supplier_Name", ob.Supplier_Name);
                objIData.AddParameter("@Supplier_Phone", ob.Supplier_Phone);
                objIData.AddParameter("@Supplier_Address", ob.Supplier_Address);
                objIData.AddParameter("@Supplier_Email", ob.Supplier_Email);
                objIData.AddParameter("@Supplier_Facbook", ob.Supplier_Facbook);
                objIData.AddParameter("@Supplier_Zalo", ob.Supplier_Zalo);
                objIData.AddParameter("@Supplier_Description", ob.Supplier_Description);
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
        public static void Update(SupplierOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Supplier_Update");
                objIData.AddParameter("@Supplier_ID", ob.Supplier_ID);
                objIData.AddParameter("@Supplier_Name", ob.Supplier_Name);
                objIData.AddParameter("@Supplier_Phone", ob.Supplier_Phone);
                objIData.AddParameter("@Supplier_Address", ob.Supplier_Address);
                objIData.AddParameter("@Supplier_Email", ob.Supplier_Email);
                objIData.AddParameter("@Supplier_Facbook", ob.Supplier_Facbook);
                objIData.AddParameter("@Supplier_Zalo", ob.Supplier_Zalo);
                objIData.AddParameter("@Supplier_Description", ob.Supplier_Description);
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
        public static void Delete(SupplierOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Supplier_Delete");
                objIData.AddParameter("@Supplier_ID", ob.Supplier_ID);
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
                objIData.CreateNewStoredProcedure("pr_Supplier_Seach");
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
                objIData.CreateNewStoredProcedure("pr_Supplier_Seach_Use");
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
        public static SupplierOB Select(string Supplier_ID)
        {
            SupplierOB ob = new SupplierOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Supplier_Select");
                objIData.AddParameter("@Supplier_ID", Supplier_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new SupplierOB(data.Rows[0]);
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
        public static SupplierOB SelectByPhone(string Supplier_Phone)
        {
            SupplierOB ob = new SupplierOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Supplier_SelectByPhone");
                objIData.AddParameter("@Supplier_Phone", Supplier_Phone);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new SupplierOB(data.Rows[0]);
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
                objIData.CreateNewStoredProcedure("pr_Supplier_Check");
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
