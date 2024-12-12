using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_NhaXuatBan
    {
        public static string Key = "NhaXuatBan";

        public static List<NhaXuatBan> GetAll(out string msg)
        {
            msg = "";
            try
            {
                // Check if the data is already cached
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    // If not, fetch from the database and cache it
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<NhaXuatBan>(DataProvider.Instance.ExecuteReader("NHAXUATBAN_GetAll"));
                }

                // Return the cached data
                return BUS_MemoryCache.Cache[Key] as List<NhaXuatBan>;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<NhaXuatBan>();
            }
        }

        public static NhaXuatBan Search_Single(int id, out string msg)
        {
            msg = "";
            try
            {
                // Search in cache first if applicable
                if (BUS_MemoryCache.Cache.Contains(Key))
                {
                    var list = BUS_MemoryCache.Cache[Key] as List<NhaXuatBan>;
                    var nxb = list?.Find(n => n.id == id);
                    if (nxb != null)
                    {
                        return nxb;
                    }
                }

                // If not found in cache, fetch from database
                return CBO.FillObject<NhaXuatBan>(DataProvider.Instance.ExecuteReader("NHAXUATBAN_GetByID", id));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new NhaXuatBan();
            }
        }
    }
}
