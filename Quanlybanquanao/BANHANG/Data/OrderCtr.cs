using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using Entity;

namespace Data
{
    public class OrderCtr
    {
        public static void Insert(OrderOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Order_Add");
                objIData.AddParameter("@Order_ID", ob.Order_ID);
                objIData.AddParameter("@Order_Date", ob.Order_Date);
                objIData.AddParameter("@Order_CustomerID", ob.Order_CustomerID);
                objIData.AddParameter("@Order_Description", ob.Order_Description);
                objIData.AddParameter("@Order_SendType", ob.Order_SendType);
                objIData.AddParameter("@Order_SendMoney", ob.Order_SendMoney);
                objIData.AddParameter("@Order_Total", ob.Order_Total);
                objIData.AddParameter("@Order_TotalVAT", ob.Order_TotalVAT);
                objIData.AddParameter("@Order_VAT", ob.Order_VAT);
                objIData.AddParameter("@Order_SaleMoney", ob.Order_SaleMoney);
                objIData.AddParameter("@CreatedBy", ob.CreatedBy);
                objIData.ExecNonQuery();

                foreach(OrderDetailOB obDetail in ob.LstOrderDetail)
                {
                    obDetail.OrderDetail_OrderID = ob.Order_ID;
                    OrderDetailCtr.Insert(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Sale(objIData, obDetail.OrderDetail_ProductID, obDetail.OrderDetail_Quantity - obDetail.OrderDetail_QuantityOld);
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
        public static void Update(OrderOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Order_Update");
                objIData.AddParameter("@Order_ID", ob.Order_ID);
                objIData.AddParameter("@Order_Description", ob.Order_Description);
                objIData.AddParameter("@Order_SendType", ob.Order_SendType);
                objIData.AddParameter("@Order_SendMoney", ob.Order_SendMoney);
                objIData.AddParameter("@Order_Total", ob.Order_Total);
                objIData.AddParameter("@Order_TotalVAT", ob.Order_TotalVAT);
                objIData.AddParameter("@Order_VAT", ob.Order_VAT);
                objIData.AddParameter("@Order_SaleMoney", ob.Order_SaleMoney);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
                objIData.ExecNonQuery();
                List<OrderDetailOB> lstDetailInsert = new List<OrderDetailOB>();
                List<OrderDetailOB> lstDetailUpdate = new List<OrderDetailOB>();
                List<OrderDetailOB> lstDetailDelete = new List<OrderDetailOB>();
                lstDetailInsert = ob.LstOrderDetail.FindAll(o => o.Flat == 0);
                lstDetailUpdate = ob.LstOrderDetail.FindAll(o => o.Flat == 1);
                lstDetailDelete = ob.LstOrderDetail.FindAll(o => o.Flat == 2);
                //insert dong them moi
                foreach (OrderDetailOB obDetail in lstDetailInsert)
                {
                    obDetail.OrderDetail_OrderID = ob.Order_ID;
                    OrderDetailCtr.Insert(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Sale(objIData, obDetail.OrderDetail_ProductID, obDetail.OrderDetail_Quantity - obDetail.OrderDetail_QuantityOld);
                }
                //Cap nhat dong chinh sua
                foreach (OrderDetailOB obDetail in lstDetailUpdate)
                {
                    obDetail.OrderDetail_OrderID = ob.Order_ID;
                    OrderDetailCtr.Update(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Sale(objIData, obDetail.OrderDetail_ProductID, obDetail.OrderDetail_Quantity - obDetail.OrderDetail_QuantityOld);
                }
                //Xoa dong
                foreach (OrderDetailOB obDetail in lstDetailDelete)
                {
                    obDetail.OrderDetail_OrderID = ob.Order_ID;
                    OrderDetailCtr.Delete(objIData, obDetail);
                    ProductQuantityCtr.ProductQuantity_Sale(objIData, obDetail.OrderDetail_ProductID, -obDetail.OrderDetail_QuantityOld);
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
                objIData.CreateNewStoredProcedure("pr_Order_Update_Status");
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
        public static void Delete(OrderOB ob)
        {
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.BeginTransaction();
                objIData.CreateNewStoredProcedure("pr_Order_Delete");
                objIData.AddParameter("@Order_ID", ob.Order_ID);
                objIData.AddParameter("@ModifiedBy", ob.ModifiedBy);
                objIData.ExecNonQuery();
                foreach (OrderDetailOB obDetail in ob.LstOrderDetail)
                {
                    ProductQuantityCtr.ProductQuantity_Sale(objIData, obDetail.OrderDetail_ProductID, - obDetail.OrderDetail_QuantityOld);
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
                objIData.CreateNewStoredProcedure("pr_Order_Seach");
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
        public static DataTable Inbanhang(string orderiD)
        {
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("prt_Banhang");
                objIData.AddParameter("@Order_ID", orderiD);
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
        public static OrderOB Select(string Order_ID)
        {
            OrderOB ob = new OrderOB();
            DataTable data = new DataTable();
            IData objIData = DataAccess.Data.CreateData();
            try
            {
                objIData.Connect();
                objIData.CreateNewStoredProcedure("pr_Order_Select");
                objIData.AddParameter("@Order_ID", Order_ID);
                data = objIData.ExecStoreToDataTable();
                if (data.Rows.Count > 0)
                {
                    ob = new OrderOB(data.Rows[0]);
                    ob.LstOrderDetail = OrderDetailCtr.SelectList(Order_ID);
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
