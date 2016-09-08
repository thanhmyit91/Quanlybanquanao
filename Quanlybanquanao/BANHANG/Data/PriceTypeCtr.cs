using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class PriceTypeCtr
    {
        public static void Insert(PriceTypeOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_PriceType_Add");
                objIData.AddParameter("@PriceType_Name", ob.PriceType_Name);
                objIData.AddParameter("@PriceType_Description", ob.PriceType_Description);
                objIData.AddParameter("@Isdefault", ob.Isdefault);
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
        public static void Update(PriceTypeOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_PriceType_Update");
                objIData.AddParameter("@PriceType_ID", ob.PriceType_ID);
                objIData.AddParameter("@PriceType_Name", ob.PriceType_Name);
                objIData.AddParameter("@PriceType_Description", ob.PriceType_Description);
                objIData.AddParameter("@Isdefault", ob.Isdefault);
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
                            objIData.CreateNewStoredProcedure("pr_PriceType_Update_Index");
                            objIData.AddParameter("@PriceType_ID", Convert.ToInt32(lstOrderIndex[i]));
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
        public static void Delete(PriceTypeOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_PriceType_Delete");
                objIData.AddParameter("@PriceType_ID", ob.PriceType_ID);
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
                objIData.CreateNewStoredProcedure("pr_PriceType_Seach");
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
                objIData.CreateNewStoredProcedure("pr_PriceType_Cache");
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
        public static PriceTypeOB Select(int PriceType_ID)
        {
            PriceTypeOB ob = new PriceTypeOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_PriceType_Select");
                objIData.AddParameter("@PriceType_ID", PriceType_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new PriceTypeOB(data.Rows[0]);
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
