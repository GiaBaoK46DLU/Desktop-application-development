namespace DTO
{
    /// <summary>
    /// Sách của quản lý phiếu mượn trả
    /// </summary>
    public class Sach_PMT
    {
        public int id { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }

        public Sach_PMT()
        {
        }

        public Sach_PMT(int id, string MaSach, string TenSach)
        {
            this.id = id;
            this.MaSach = MaSach;
            this.TenSach = TenSach;
        }

        public override string ToString()
        {
            return TenSach.ToString();
        }
    }
}
