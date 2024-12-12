namespace DTO
{
    /// <summary>
    /// Thể loại
    /// </summary>
    public class TheLoai
    {
        public int id { get; set; }
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public TheLoai()
        {
        }

        public TheLoai(string TenTheLoai)
        {
            this.TenTheLoai = TenTheLoai;
        }

        public TheLoai(int id, string TenTheLoai)
        {
            this.id = id;
            this.TenTheLoai = TenTheLoai;
        }

        public override string ToString()
        {
            return TenTheLoai.ToString();
        }
    }
}