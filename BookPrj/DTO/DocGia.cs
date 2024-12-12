using System;
using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Độc giả
    /// </summary>
    public class DocGia
    {
        public int ID { get; set; }
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }

        [Browsable(false)]
        public int idLoaiDocGia { get; set; }
        public string TenLoaiDocGia { get; set; }

        public DocGia()
        {
        }
        public DocGia(string TenDocGia, DateTime NgaySinh, DateTime NgayLapThe, DateTime NgayHetHan, string SoDienThoai, string DiaChi, string GioiTinh, int idLoaiDocGia)
        {
            this.TenDocGia = TenDocGia;
            this.NgaySinh = NgaySinh;
            this.NgayLapThe = NgayLapThe;
            this.NgayHetHan = NgayHetHan;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
            this.GioiTinh = GioiTinh;
            this.idLoaiDocGia = idLoaiDocGia;
        }

        public DocGia(int ID, string TenDocGia, DateTime NgaySinh, DateTime NgayLapThe, DateTime NgayHetHan, string SoDienThoai, string DiaChi, string GioiTinh, int idLoaiDocGia)
        {
            this.ID = ID;
            this.TenDocGia = TenDocGia;
            this.NgaySinh = NgaySinh;
            this.NgayLapThe = NgayLapThe;
            this.NgayHetHan = NgayHetHan;
            this.SoDienThoai = SoDienThoai;
            this.DiaChi = DiaChi;
            this.GioiTinh = GioiTinh;
            this.idLoaiDocGia = idLoaiDocGia;
        }

        public override string ToString()
        {
            return TenDocGia.ToString() + "\t" + NgaySinh.ToString() + "\t" + NgayLapThe.ToString() + "\t" + NgayHetHan.ToString() + "\t" + SoDienThoai.ToString() + "\t" + DiaChi.ToString() + "\t" + GioiTinh.ToString() + "\t" + idLoaiDocGia.ToString() + "\t" + ID.ToString() + "\t" + MaDocGia.ToString();
        }
    }
}