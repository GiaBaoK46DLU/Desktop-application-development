using DataAccess;
using DTO;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BUS_CTPhieuMuonTra
    {
        public static string Key = "CT_PhieuMuonTra";

        public static List<CT_PhieuMuonTra> GetAll(out string message)
        {
            message = "";
            try
            {
                if (!BUS_MemoryCache.Cache.Contains(Key))
                {
                    var data = CBO.FillCollection<CT_PhieuMuonTra>(DataProvider.Instance.ExecuteReader("CT_PHIEUMUONTRA_GetAll"));
                    BUS_MemoryCache.Cache[Key] = data;
                }
                return BUS_MemoryCache.Cache[Key] as List<CT_PhieuMuonTra>;
            }
            catch (Exception e)
            {
                message = e.Message;
                return new List<CT_PhieuMuonTra>();
            }
        }

        public static bool Add(CT_PhieuMuonTra cT_PhieuMuonTra, out string message)
        {
            message = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQueryWithOutput("@idSoPhieuMuonTra", "CT_PHIEUMUONTRA_Insert",
                    cT_PhieuMuonTra.idSoPhieuMuonTra,
                    cT_PhieuMuonTra.idSach,
                    cT_PhieuMuonTra.GhiChu);
                if (Convert.ToInt32(result) > 0)
                {
                    BUS_MemoryCache.Cache.Remove(Key);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }
        }

        public static List<CT_PhieuMuonTra> SearchByID_PMT(int idPMT, out string message)
        {
            message = "";
            try
            {
                return CBO.FillCollection<CT_PhieuMuonTra>(DataProvider.Instance.ExecuteReader("CT_PHIEUMUONTRA_Search", idPMT));
            }
            catch (Exception e)
            {
                message = e.Message;
                return new List<CT_PhieuMuonTra> { };
            }
        }

        public static bool TraSach(int id, out string message)
        {
            message = "";
            try
            {
                object result = DataProvider.Instance.ExecuteNonQuery("CT_PHIEUMUONTRA_Update", id);
                if (Convert.ToInt32(result) > 0)
                {
                    BUS_MemoryCache.Cache.Remove(Key);
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                message = e.Message;
                return false;
            }
        }
    }
}
