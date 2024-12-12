using System;
using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Chi tiết phiếu mượn trả
    /// </summary>
    public class CT_PhieuMuonTra

    {
        public int ID { get; set; }
        [Browsable(false)]
        public int idSoPhieuMuonTra { get; set; }
        [Browsable(false)]
        public int idSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayTra { get; set; }
        [Browsable(false)]
        public string GhiChu { get; set; }

        public CT_PhieuMuonTra()
        {
        }

        public CT_PhieuMuonTra(int idSoPhieuMuonTra, int idSach, string GhiChu)
        {
            this.idSoPhieuMuonTra = idSoPhieuMuonTra;
            this.idSach = idSach;
            this.GhiChu = GhiChu;
        }

        public CT_PhieuMuonTra(int idSoPhieuMuonTra, int idSach, DateTime NgayTra, string GhiChu)
        {
            this.idSoPhieuMuonTra = idSoPhieuMuonTra;
            this.idSach = idSach;
            this.NgayTra = NgayTra;
            this.GhiChu = GhiChu;
        }

        public override string ToString()
        {
            return idSach.ToString() + "\t" + NgayTra.ToString() + "\t" + GhiChu.ToString();
        }
    }
}