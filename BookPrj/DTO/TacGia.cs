namespace DTO
{
    /// <summary>
    /// Tác giả
    /// </summary>
    public class TacGia
    {
        public int id { get; set; }
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }


        public TacGia()
        {
        }

        public TacGia(string TenTacGia)
        {
            this.TenTacGia = TenTacGia;
        }
        public TacGia(int id, string TenTacGia)
        {
            this.id = id;
            this.TenTacGia = TenTacGia;
        }
        public override string ToString()
        {
            return TenTacGia.ToString();
        }
    }
}