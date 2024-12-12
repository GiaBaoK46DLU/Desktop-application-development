using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace BusinessLogic
{
    public class BUS_TaiKhoan
    {
        public static string Key = "TaiKhoan";
        public static TaiKhoan KiemTraDangNhap(string TenDangNhap, string MatKhau, out string msg)
        {
            msg = "";
            try
            {
                var users = CBO.FillCollection<TaiKhoan>(DataProvider.Instance.ExecuteReader("sp_KiemTraDangNhap", TenDangNhap, MatKhau));
                return users.FirstOrDefault();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }
        }

        public static List<TaiKhoan> GetAll(out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillCollection<TaiKhoan>(DataProvider.Instance.ExecuteReader("TAIKHOAN_GetAll"));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<TaiKhoan>();
            }
        }

        public static TaiKhoan Search_Single(int id, out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillObject<TaiKhoan>(DataProvider.Instance.ExecuteReader("TAIKHOAN_GetByID", id));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new TaiKhoan();
            }
        }

        public static bool Add(TaiKhoan taiKhoan, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "TAIKHOAN_Insert", taiKhoan.id,
                    taiKhoan.TenTaiKhoan, taiKhoan.TenDangNhap, taiKhoan.MatKhau, taiKhoan.HoTenNhanVien,
                    taiKhoan.idLoaiTaiKhoan);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static bool Update(TaiKhoan taiKhoan, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("TAIKHOAN_Update", taiKhoan.id,
                    taiKhoan.TenTaiKhoan, taiKhoan.TenDangNhap, taiKhoan.MatKhau, taiKhoan.HoTenNhanVien,
                    taiKhoan.idLoaiTaiKhoan);
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
                int result = DataProvider.Instance.ExecuteNonQuery("TAIKHOAN_Delete", id);
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<TaiKhoan> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<TaiKhoan>(DataProvider.Instance.ExecuteReader("TAIKHOAN_GetAll"));
                }
                List<TaiKhoan> data = (List<TaiKhoan>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(taiKhoan => taiKhoan.HoTenNhanVien.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<TaiKhoan>();
            }
        }

        public static bool DoiMatKhau(string TenDangNhap, string MatKhauCu, string MatKhauMoi, out string msg)
        {
            msg = "";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("MatKhau_Update", TenDangNhap, MatKhauCu, MatKhauMoi);
                return result > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }
    }
}
