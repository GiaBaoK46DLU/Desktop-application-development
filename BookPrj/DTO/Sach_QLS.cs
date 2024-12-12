using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Sách của Quản Lý Sách
    /// </summary>
    public class Sach_QLS : Sach_PMT
    {
        public int id { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }

        [Browsable(false)]
        public int idTheLoai { get; set; }

        public string TenTheLoai { get; set; }

        [Browsable(false)]
        public int idTacGia { get; set; }

        public string TenTacGia { get; set; }

        [Browsable(false)]
        public string idNhaXuatBan { get; set; }

        public string TenNhaXuatBan { get; set; }

        public int NamXB { get; set; }

        public int SoLuong { get; set; }

        public int GiaBia { get; set; }


        public Sach_QLS()
        {
        }

        public Sach_QLS(string TenSach, int idTheLoai, int idTacGia, string idNhaXuatBan, int NamXB, int SoLuong, int GiaBia)
        {
            this.TenSach = TenSach;
            this.idTheLoai = idTheLoai;
            this.idTacGia = idTacGia;
            this.idNhaXuatBan = idNhaXuatBan;
            this.NamXB = NamXB;
            this.SoLuong = SoLuong;
            this.GiaBia = GiaBia;
        }

        public Sach_QLS(int id, string TenSach, int idTheLoai, int idTacGia, string idNhaXuatBan, int NamXB, int SoLuong, int GiaBia)
        {
            this.id = id;
            this.TenSach = TenSach;
            this.idTheLoai = idTheLoai;
            this.idTacGia = idTacGia;
            this.idNhaXuatBan = idNhaXuatBan;
            this.NamXB = NamXB;
            this.SoLuong = SoLuong;
            this.GiaBia = GiaBia;
        }

        public override string ToString()
        {
            return TenSach.ToString() + "\t" + idTheLoai.ToString() + "\t" + idTacGia.ToString() + "\t" + idNhaXuatBan.ToString() + "\t" + NamXB.ToString() + "\t" + SoLuong.ToString() + "\t" + GiaBia.ToString() + "\t" + id.ToString() + "\t" + MaSach.ToString();
        }

        public Sach_PMT Convert()
        {
            return new Sach_PMT(this.id, this.MaSach, this.TenSach);
        }
    }
}