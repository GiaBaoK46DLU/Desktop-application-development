//using BusinessLogic;
using BusinessLogic;
using DTO;
using System;
using System.Windows.Forms;

namespace BookLibraryManagementProject
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var taiKhoan = CheckLogin(txtUsername.Text, txtUserpwd.Text);
            if (taiKhoan != null)
            {
                fManager f = new fManager();
                UserInfo.id = taiKhoan.id;
                UserInfo.idLoaiTaiKhoan = taiKhoan.idLoaiTaiKhoan;
                UserInfo.TenDangNhap = taiKhoan.TenDangNhap;
                this.Hide();
                f.Show();
                f.Activate();
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau", "Loi");
                txtUsername.Focus();
            }
        }

        TaiKhoan CheckLogin(string tentaikhoan, string matkhau)
        {
            string msg;
            return BUS_TaiKhoan.KiemTraDangNhap(tentaikhoan, matkhau, out msg);
        }
    }
}
