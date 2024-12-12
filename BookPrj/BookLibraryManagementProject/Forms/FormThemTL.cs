using BusinessLogic;
using DTO;
using System;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormThemTL : Form
    {
        public FormThemTL()
        {
            InitializeComponent();
        }

        private void iBtnAddTL_Click(object sender, EventArgs e)
        {
            string tentheloai = tbTenTheLoai.Text;
            string msg;

            if (!string.IsNullOrEmpty(tentheloai))
            {
                TheLoai theLoai = new TheLoai(tentheloai);

                bool kq = BUS_TheLoai.Add(theLoai, out msg);
                if (kq)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
            }
        }
    }
}
