namespace DTO
{
    /// <summary>
    /// Loại độc giả
    /// </summary>
    public class LoaiDocGia
    {
        public int id { get; set; }
        public string MaLoaiDocGia { get; set; }
        public string TenLoaiDocGia { get; set; }


        public LoaiDocGia()
        {
        }

        public LoaiDocGia(string TenLoaiDocGia)
        {
            this.TenLoaiDocGia = TenLoaiDocGia;
        }

        public LoaiDocGia(int id, string TenLoaiDocGia)
        {
            this.id = id;
            this.TenLoaiDocGia = TenLoaiDocGia;

        }

        public override string ToString()
        {
            return TenLoaiDocGia.ToString();
        }
    }
}