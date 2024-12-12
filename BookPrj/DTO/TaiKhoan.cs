using System.ComponentModel;

namespace DTO
{
    /// <summary>
    /// Tài khoản
    /// </summary>
    public class TaiKhoan
    {
        public int id { get; set; }
        public string MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTenNhanVien { get; set; }
        [Browsable(false)]
        public int idLoaiTaiKhoan { get; set; }
        public string TenLoaiTaiKhoan { get; set; }

        public TaiKhoan()
        {
        }
        public TaiKhoan(string TenTaiKhoan, string TenDangNhap, string MatKhau, string HoTenNhanVien, int idLoaiTaiKhoan)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.HoTenNhanVien = HoTenNhanVien;
            this.idLoaiTaiKhoan = idLoaiTaiKhoan;
        }
        public TaiKhoan(int id, string TenTaiKhoan, string TenDangNhap, string MatKhau, string HoTenNhanVien, int idLoaiTaiKhoan)
        {
            this.id = id;
            this.TenTaiKhoan = TenTaiKhoan;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.HoTenNhanVien = HoTenNhanVien;
            this.idLoaiTaiKhoan = idLoaiTaiKhoan;
        }

        public override string ToString()
        {
            return id.ToString() + "\t" + TenTaiKhoan.ToString() + "\t" + TenDangNhap.ToString() + "\t" + MatKhau.ToString() + "\t" + HoTenNhanVien.ToString() + "\t" + idLoaiTaiKhoan.ToString();
        }
    }
}