using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_TheLoai
    {
        public static string Key = "TheLoai";
        public static List<TheLoai> GetAll(out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<TheLoai>(DataProvider.Instance.ExecuteReader("THELOAI_GetAll"));
                }
                return BUS_MemoryCache.Cache[Key] as List<TheLoai>;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<TheLoai>();
            }
        }

        public static TheLoai Search_Single(int id, out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillObject<TheLoai>(DataProvider.Instance.ExecuteReader("THELOAI_GetByID"));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }
        }

        public static bool Add(TheLoai theLoai, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "THELOAI_Insert", theLoai.id, theLoai.TenTheLoai);
                BUS_MemoryCache.Cache.Remove(Key);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool Update(TheLoai theLoai, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("THELOAI_Update", theLoai.id, theLoai.TenTheLoai);
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
                int result = DataProvider.Instance.ExecuteNonQuery("THELOAI_Delete", id);
                BUS_MemoryCache.Cache.Remove(Key);
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<TheLoai> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<TheLoai>(DataProvider.Instance.ExecuteReader("THELOAI_GetAll"));
                }
                List<TheLoai> data = (List<TheLoai>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(theLoai =>
                    theLoai.TenTheLoai.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<TheLoai>();
            }
        }
    }
}