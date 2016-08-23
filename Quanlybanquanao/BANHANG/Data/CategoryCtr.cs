using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class CategoryCtr
    {
        public static void Insert(CategoryOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Category_Add");
                objIData.AddParameter("@Category_Name", ob.Category_Name);
                objIData.AddParameter("@Category_Description", ob.Category_Description);
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
        public static void Update(CategoryOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Category_Update");
                objIData.AddParameter("@Category_ID", ob.Category_ID);
                objIData.AddParameter("@Category_Name", ob.Category_Name);
                objIData.AddParameter("@Category_Description", ob.Category_Description);
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
                            objIData.CreateNewStoredProcedure("pr_Category_Update_Index");
                            objIData.AddParameter("@Category_ID", Convert.ToInt32(lstOrderIndex[i]));
                            objIData.AddParameter("@Orderindex", i);
                            objIData.ExecNonQuery();
                        }
                        catch(Exception ex)
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
        public static void Delete(CategoryOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Category_Delete");
                objIData.AddParameter("@Category_ID", ob.Category_ID);
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
                objIData.CreateNewStoredProcedure("pr_Category_Seach");
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
                objIData.CreateNewStoredProcedure("pr_Category_Cache");
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
        public static CategoryOB Select(int Category_ID)
        {
            CategoryOB ob = new CategoryOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Category_Select");
                objIData.AddParameter("@Category_ID", Category_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new CategoryOB(data.Rows[0]);
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
