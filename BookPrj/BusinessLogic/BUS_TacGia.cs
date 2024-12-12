using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_TacGia
    {
        public static string Key = "TacGia";

        public static List<TacGia> GetAll(out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<TacGia>(DataProvider.Instance.ExecuteReader("TACGIA_GetAll"));
                }
                return BUS_MemoryCache.Cache[Key] as List<TacGia>;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<TacGia>();
            }
        }

        public static TacGia Search_Single(int id, out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillObject<TacGia>(DataProvider.Instance.ExecuteReader("TACGIA_GetByID", id));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new TacGia();
            }
        }

        public static bool Add(TacGia tacGia, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "TACGIA_Insert", tacGia.id, tacGia.TenTacGia);
                BUS_MemoryCache.Cache.Remove(Key);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool Update(TacGia tacGia, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("TACGIA_Update", tacGia.id, tacGia.TenTacGia);
                BUS_MemoryCache.Cache.Remove(Key);
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool Delete(int id, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("TACGIA_Delete", id);
                BUS_MemoryCache.Cache.Remove(Key);
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<TacGia> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<TacGia>(DataProvider.Instance.ExecuteReader("TACGIA_GetAll"));
                }
                List<TacGia> data = (List<TacGia>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(tacGia =>
                    tacGia.TenTacGia.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<TacGia>();
            }
        }
    }
}
