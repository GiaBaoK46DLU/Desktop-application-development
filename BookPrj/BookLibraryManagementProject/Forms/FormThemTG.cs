using BusinessLogic;
using DTO;
using System;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormThemTG : Form
    {
        public FormThemTG()
        {
            InitializeComponent();
        }

        private void iBtnAddTG_Click(object sender, EventArgs e)
        {
            string tentacgia = tbTenTacGia.Text;
            string msg;

            if (!string.IsNullOrEmpty(tentacgia))
            {
                TacGia tacGia = new TacGia(tentacgia);

                bool kq = BUS_TacGia.Add(tacGia, out msg);
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
