namespace DTO
{
    /// <summary>
    /// Loại tài khoản
    /// </summary>
    public class LoaiTaiKhoan
    {
        public int id { get; set; }
        public string TenLoaiTaiKhoan { get; set; }
        public string MaLoaiTaiKhoan { get; set; }

        public LoaiTaiKhoan()
        {
        }

        public LoaiTaiKhoan(int id, string TenLoaiTaiKhoan, string MaLoaiTaiKhoan)
        {
            this.id = id;
            this.TenLoaiTaiKhoan = TenLoaiTaiKhoan;
            this.MaLoaiTaiKhoan = MaLoaiTaiKhoan;
        }

        public override string ToString()
        {
            return id.ToString() + "\t" + TenLoaiTaiKhoan.ToString() + "\t" + MaLoaiTaiKhoan.ToString();
        }
    }
}