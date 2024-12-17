using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace BusinessLogic
{
    public class BUS_PhieuMuonTra
    {
        public static string Key = "PhieuMuonTra";
        public static List<PhieuMuonTra> GetAll(out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillCollection<PhieuMuonTra>(DataProvider.Instance.ExecuteReader("PHIEUMUONTRA_GetAll"));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<PhieuMuonTra>();
            }
        }

        public static List<PhieuMuonTra> GetAll_PhieuChuaTra(out string msg)
        {
            msg = "";
            try
            {
                return CBO.FillCollection<PhieuMuonTra>(DataProvider.Instance.ExecuteReader("PHIEUMUONTRA_Get_PhieuChuaTra"));
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<PhieuMuonTra>();
            }
        }

        public static int Add(PhieuMuonTra phieuMuonTra, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@id", "PHIEUMUONTRA_Insert", phieuMuonTra.ID,
                    phieuMuonTra.idDocGia, phieuMuonTra.idTaiKhoan, phieuMuonTra.NgayMuon, phieuMuonTra.HanTra,
                    phieuMuonTra.DaTraSach, phieuMuonTra.TrangThaiSach,phieuMuonTra.TienPhat);
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return 0;
            }
        }

        public static bool Update(int id, out string msg)
        {
            msg = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQuery("PhieuMuonTra_Update_TraHet", id);
                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }

        public static List<PhieuMuonTra> Search(string keyword, out string msg)
        {
            msg = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    BUS_MemoryCache.Cache[Key] = CBO.FillCollection<PhieuMuonTra>(DataProvider.Instance.ExecuteReader("PHIEUMUONTRA_GetAll"));
                }
                List<PhieuMuonTra> data = (List<PhieuMuonTra>)BUS_MemoryCache.Cache[Key];
                return data.FindAll(phieuMuonTra =>
                    phieuMuonTra.TenDocGia.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    phieuMuonTra.HoTenNhanVien.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                );
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return new List<PhieuMuonTra>();
            }
        }
    }
}