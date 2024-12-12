using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Interop;

namespace BusinessLogic
{
    public class BUS_DocGia
    {
        public static string Key = "DocGia";

        public static List<DocGia> GetAll(out string message)
        {
            message = "";
            try
            {
                // Check if the data is already cached
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    // If not, fetch from database and cache it
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<DocGia>(DataProvider.Instance.ExecuteReader("DOCGIA_GetAll"));
                }

                // Return the cached data
                return BUS_MemoryCache.Cache[Key] as List<DocGia>;
            }
            catch (Exception e)
            {
                message = e.Message;
                return new List<DocGia>();
            }
        }

        public static DocGia Search_Single(int id, out string message)
        {
            message = "";
            try
            {
                // Search in cache first if applicable
                if (BUS_MemoryCache.Cache.Contains(Key))
                {
                    var list = BUS_MemoryCache.Cache[Key] as List<DocGia>;
                    var docGia = list?.Find(d => d.ID == id);
                    if (docGia != null)
                    {
                        return docGia;
                    }
                }

                // If not found in cache, fetch from database
                return CBO.FillObject<DocGia>(DataProvider.Instance.ExecuteReader("DOCGIA_GetByID", id));
            }
            catch (Exception e)
            {
                message = e.Message;
                return new DocGia();
            }
        }

        public static bool Add(DocGia docGia, out string message)
        {
            message = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "DOCGIA_Insert", docGia.ID,
                    docGia.TenDocGia, docGia.NgaySinh, docGia.NgayLapThe, docGia.NgayHetHan,
                    docGia.SoDienThoai, docGia.DiaChi, docGia.GioiTinh, docGia.idLoaiDocGia);

                // Clear the cache as the data has been updated
                BUS_MemoryCache.Cache.Remove(Key);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }
        }

        public static bool Update(DocGia docGia, out string message)
        {
            message = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("DOCGIA_Update", docGia.ID,
                    docGia.TenDocGia, docGia.NgaySinh, docGia.NgayLapThe, docGia.NgayHetHan,
                    docGia.SoDienThoai, docGia.DiaChi, docGia.GioiTinh, docGia.idLoaiDocGia);

                // Clear the cache as the data has been updated
                BUS_MemoryCache.Cache.Remove(Key);
                return result > 0;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool Delete(int id, out string message)
        {
            message = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("DOCGIA_Delete", id);

                // Clear the cache as the data has been modified
                BUS_MemoryCache.Cache.Remove(Key);
                return result > 0;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static List<DocGia> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<DocGia>(DataProvider.Instance.ExecuteReader("DOCGIA_GetAll"));
                }
                List<DocGia> data = (List<DocGia>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(docGia => docGia.TenDocGia.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<DocGia>();
            }
        }
    }
}
