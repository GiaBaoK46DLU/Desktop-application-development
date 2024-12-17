using System;
using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Phiếu mượn trả
    /// </summary>
    public class PhieuMuonTra
    {
        public int ID { get; set; }
        public string SoPhieuMuonTra { get; set; }
        [Browsable(false)]
        public int idDocGia { get; set; }
        public string TenDocGia { get; set; }
        [Browsable(false)]
        public int idTaiKhoan { get; set; }
        public string HoTenNhanVien { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        [Browsable(false)]
        public bool DaTraSach { get; set; }
        public string TrangThaiSach { get; set; }
        public int TienPhat { get; set; }


        public PhieuMuonTra()
        {
        }

        public PhieuMuonTra(int idDocGia, int idTaiKhoan, DateTime NgayMuon, DateTime HanTra, bool DaTraSach, string TrangThaiSach, int TienPhat)
        {
            this.idDocGia = idDocGia;
            this.idTaiKhoan = idTaiKhoan;
            this.NgayMuon = NgayMuon;
            this.HanTra = HanTra;
            this.DaTraSach = DaTraSach;
            this.TrangThaiSach = TrangThaiSach;
            this.TienPhat = TienPhat;
        }

        public override string ToString()
        {
            return idDocGia.ToString() + "\t" + idTaiKhoan.ToString() + "\t" + NgayMuon.ToString() + "\t" + ID.ToString() + "\t" + HanTra.ToString() + "\t" + TienPhat.ToString() + "\t" + SoPhieuMuonTra.ToString() + "\t" + DaTraSach.ToString();
        }
    }
}