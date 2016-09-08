using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class SendTypeCtr
    {
        public static void Insert(SendTypeOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_SendType_Add");
                objIData.AddParameter("@SendType_Name", ob.SendType_Name);
                objIData.AddParameter("@SendType_Description", ob.SendType_Description);
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
        public static void Update(SendTypeOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_SendType_Update");
                objIData.AddParameter("@SendType_ID", ob.SendType_ID);
                objIData.AddParameter("@SendType_Name", ob.SendType_Name);
                objIData.AddParameter("@SendType_Description", ob.SendType_Description);
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
        public static void Update_Index(List<object> lstOrderIndex)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                if (lstOrderIndex != null && lstOrderIndex.Count > 0)
                {
                    for (int i = 0; i < lstOrderIndex.Count; i++)
                    {
                        try
                        {
                            objIData.CreateNewStoredProcedure("pr_SendType_Update_Index");
                            objIData.AddParameter("@SendType_ID", Convert.ToInt32(lstOrderIndex[i]));
                            objIData.AddParameter("@Orderindex", i);
                            objIData.ExecNonQuery();
                        }
                        catch (Exception ex)
                        {
                            objIData.RollBackTransaction();
                            throw ex;
                        }
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
        public static void Delete(SendTypeOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_SendType_Delete");
                objIData.AddParameter("@SendType_ID", ob.SendType_ID);
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
                objIData.CreateNewStoredProcedure("pr_SendType_Seach");
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
        public static DataTable Cache()
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_SendType_Cache");
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
        public static SendTypeOB Select(int SendType_ID)
        {
            SendTypeOB ob = new SendTypeOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_SendType_Select");
                objIData.AddParameter("@SendType_ID", SendType_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new SendTypeOB(data.Rows[0]);
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
