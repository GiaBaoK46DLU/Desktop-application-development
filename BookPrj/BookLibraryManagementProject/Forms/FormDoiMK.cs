using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void iBtnLuuMK_Click(object sender, EventArgs e)
        {
            string matkhaucu = tbMatKhauCu.Text;
            string matkhaumoi = tbMatKhauMoi.Text;
            string xacnhanmatkhau = tbXacNhanMK.Text;
            string msg;

            if (!string.IsNullOrEmpty(matkhaucu) && !string.IsNullOrEmpty(matkhaumoi) && !string.IsNullOrEmpty(xacnhanmatkhau)
                && matkhaumoi == xacnhanmatkhau)
            {
                bool kq = BUS_TaiKhoan.DoiMatKhau(UserInfo.TenDangNhap, matkhaucu, matkhaumoi, out msg);
                if (kq)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
        }
    }
}
