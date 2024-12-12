using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class BUS_Sach
    {
        public static string Key = "Sach";

        public static List<Sach_QLS> GetAll(out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<Sach_QLS>(DataProvider.Instance.ExecuteReader("SACH_GetAll2"));
                }
                return BUS_MemoryCache.Cache[Key] as List<Sach_QLS>;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<Sach_QLS>();
            }
        }

        public static List<Sach_PMT> GetAll2(out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<Sach_QLS>(DataProvider.Instance.ExecuteReader("SACH_GetAll2"));
                }
                var ds = BUS_MemoryCache.Cache[Key] as List<Sach_QLS>;
                return ds.Select(s => s.Convert()).ToList();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<Sach_PMT>();
            }
        }

        public static Sach_QLS Search_Single(int id, out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillObject<Sach_QLS>(DataProvider.Instance.ExecuteReader("SACH_GetByID", id));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new Sach_QLS();
            }
        }

        public static bool Add(Sach_QLS sach, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "SACH_Insert", sach.id,
                    sach.TenSach, sach.idTheLoai, sach.idTacGia, sach.idNhaXuatBan,
                    sach.NamXB, sach.SoLuong, sach.GiaBia);
                BUS_MemoryCache.Cache.Remove(Key);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool Update(Sach_QLS sach, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("SACH_Update", sach.id,
                    sach.TenSach, sach.idTheLoai, sach.idTacGia, sach.idNhaXuatBan,
                    sach.NamXB, sach.SoLuong, sach.GiaBia);
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
                int result = DataProvider.Instance.ExecuteNonQuery("SACH_Delete", id);
                BUS_MemoryCache.Cache.Remove(Key);
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<Sach_QLS> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<Sach_QLS>(DataProvider.Instance.ExecuteReader("SACH_GetAll"));
                }
                List<Sach_QLS> data = (List<Sach_QLS>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(sach =>
                    sach.TenSach.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    sach.TenTheLoai.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    sach.TenTacGia.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                );
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<Sach_QLS>();
            }
        }
    }
}
