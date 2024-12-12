using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_LoaiDocGia
    {
        public static string Key = "LoaiDocGia";

        public static List<LoaiDocGia> GetAll(out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<LoaiDocGia>(DataProvider.Instance.ExecuteReader("LOAIDOCGIA_GetAll"));
                }
                return BUS_MemoryCache.Cache[Key] as List<LoaiDocGia>;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<LoaiDocGia>();
            }
        }

        public static LoaiDocGia Search_Single(int id, out string msg)
        {
            msg = "";
            try
            {
                if (BUS_MemoryCache.Cache.Contains(Key))
                {
                    var list = BUS_MemoryCache.Cache[Key] as List<LoaiDocGia>;
                    var loaiDocGia = list?.Find(ldg => ldg.id == id);
                    if (loaiDocGia != null)
                    {
                        return loaiDocGia;
                    }
                }
                return CBO.FillObject<LoaiDocGia>(DataProvider.Instance.ExecuteReader("LOAIDOCGIA_GetByID", id));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new LoaiDocGia();
            }
        }

        public static bool Add(LoaiDocGia loaiDocGia, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "LOAIDOCGIA_Insert",
                    loaiDocGia.id, loaiDocGia.TenLoaiDocGia);
                BUS_MemoryCache.Cache.Remove(Key);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool Update(LoaiDocGia loaiDocGia, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("LOAIDOCGIA_Update",
                    loaiDocGia.id, loaiDocGia.TenLoaiDocGia);
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
                int result = DataProvider.Instance.ExecuteNonQuery("LOAIDOCGIA_Delete", id);
                BUS_MemoryCache.Cache.Remove(Key);
                msg = "Thành công";
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<LoaiDocGia> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<LoaiDocGia>(DataProvider.Instance.ExecuteReader("LOAIDOCGIA_GetAll"));
                }
                List<LoaiDocGia> data = (List<LoaiDocGia>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(loaiDocGia => loaiDocGia.TenLoaiDocGia.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<LoaiDocGia>();
            }
        }
    }
}
