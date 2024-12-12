using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_PhieuMuonTra
    {
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
                    phieuMuonTra.DaTraSach, phieuMuonTra.TienPhat);
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
    }
}