using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_LoaiTaiKhoan
    {
        public static string Key = "LoaiTaiKhoan";

        public static List<LoaiTaiKhoan> GetAll(out string msg)
        {
            msg = "";
            try
            {
                // Check if the data is already cached
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    // If not, fetch from the database and cache it
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<LoaiTaiKhoan>(DataProvider.Instance.ExecuteReader("LOAITAIKHOAN_GetAll"));
                }

                // Return the cached data
                return BUS_MemoryCache.Cache[Key] as List<LoaiTaiKhoan>;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<LoaiTaiKhoan>();
            }
        }
    }
}
