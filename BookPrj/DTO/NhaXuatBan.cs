namespace DTO
{
    /// <summary>
    /// Nhà xuất bản
    /// </summary>
    public class NhaXuatBan
    {
        public int id { get; set; }
        public string TenNhaXuatBan { get; set; }
        public string MaNhaXuatBan { get; set; }

        public NhaXuatBan()
        {
        }

        public NhaXuatBan(int id, string TenNhaXuatBan, string MaNhaXuatBan)
        {
            this.id = id;
            this.TenNhaXuatBan = TenNhaXuatBan;
            this.MaNhaXuatBan = MaNhaXuatBan;
        }

        public override string ToString()
        {
            return id.ToString() + "\t" + TenNhaXuatBan.ToString() + "\t" + MaNhaXuatBan.ToString();
        }
    }
}
