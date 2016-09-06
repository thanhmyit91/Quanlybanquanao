using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data;

namespace BANHANG
{
    public class Datacache
    {
        #region nạp category vào cache
        private static DataTable CategoryCache=null;
        public static DataTable GetCategoryCache()
        {
            if (CategoryCache == null)
            {
                DataTable data = new DataTable();
                data = CategoryCtr.Cache();
                CategoryCache = data;
            }
            return CategoryCache;
        }
        #endregion 

        #region nạp color vào cache
        private static DataTable ColorCache = null;
        public static DataTable GetColorCache()
        {
            if (ColorCache == null)
            {
                DataTable data = new DataTable();
                data = ColorCtr.Cache();
                ColorCache = data;
            }
            return ColorCache;
        }
        #endregion 

        #region nạp config vào cache
        private static DataTable ConfigCache = null;
        public static DataTable GetConfigCache()
        {
            if (ConfigCache == null)
            {
                DataTable data = new DataTable();
                data = ConfigCtr.Cache();
                ConfigCache = data;
            }
            return ConfigCache;
        }
        #endregion 

        #region nạp Model vào cache
        private static DataTable ModelCache = null;
        public static DataTable GetModelCache()
        {
            if (ModelCache == null)
            {
                DataTable data = new DataTable();
                data = ModelCtr.Cache();
                ModelCache = data;
            }
            return ModelCache;
        }
        #endregion 

        //#region nạp SendType vào cache
        //private static DataTable SendTypeCache = null;
        //public static DataTable GetSendTypeCache()
        //{
        //    if (SendTypeCache == null)
        //    {
        //        DataTable data = new DataTable();
        //        data = SendTypeCtr.Cache();
        //        SendTypeCache = data;
        //    }
        //    return SendTypeCache;
        //}
        //#endregion 

        //#region nạp PriceType vào cache
        //private static DataTable PriceTypeCache = null;
        //public static DataTable GetPriceTypeCache()
        //{
        //    if (PriceTypeCache == null)
        //    {
        //        DataTable data = new DataTable();
        //        data = PriceTypeCtr.Cache();
        //        PriceTypeCache = data;
        //    }
        //    return PriceTypeCache;
        //}
        //#endregion 
        //#region nạp Price vào cache
        //private static DataTable PriceCache = null;
        //public static DataTable GetPriceCache()
        //{
        //    if (PriceCache == null)
        //    {
        //        DataTable data = new DataTable();
        //        data = PriceCtr.Cache();
        //        PriceCache = data;
        //    }
        //    return PriceCache;
        //}
        //#endregion 

        #region nạp Product vào cache
        private static DataTable ProductCache = null;
        public static DataTable GetProductCache()
        {
            if (ProductCache == null)
            {
                DataTable data = new DataTable();
                data = ProductCtr.Cache();
                ProductCache = data;
            }
            return ProductCache;
        }
        #endregion 

        #region Xóa cache
        public static void DeleteCache()
        {
            CategoryCache = null;
            ColorCache = null;
            ConfigCache = null;
            ModelCache = null;
            //SendTypeCache = null;
            ProductCache = null;
            //PriceTypeCache = null;
            //PriceCache = null;
        }
        #endregion
    }
}
