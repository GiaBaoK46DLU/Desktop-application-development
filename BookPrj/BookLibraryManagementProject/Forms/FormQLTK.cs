using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormQLTK : Form
    {
        public FormQLTK()
        {
            InitializeComponent();
            cMSXoa_TaiKhoan.Items[0].Click += btnXoa_QLTK_Click;
        }
        private void btnXoa_QLTK_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            switch (tabQLTK.SelectedIndex)
            {
                case 0:
                    if (dgvTaiKhoan.SelectedRows.Count > 0 && dgvTaiKhoan.DataSource != null && dgvTaiKhoan.DataSource is List<TaiKhoan>)
                    {
                        var row = dgvTaiKhoan.SelectedRows[0];
                        bool kq = BUS_TaiKhoan.Delete(int.Parse(row.Cells["id"].Value.ToString()), out msg);
                        if (kq)
                        {
                            dgvTaiKhoan.DataSource = BUS_TaiKhoan.GetAll(out msg);
                            MessageBox.Show("Xóa tài khoản thành công");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {msg}");
                        }
                    }
                    break;
            }
        }

        private void FormQLTK_Load(object sender, System.EventArgs e)
        {
            string msg;
            dgvTaiKhoan.DataSource = BUS_TaiKhoan.GetAll(out msg);
            cBLoaiTaiKhoan.DataSource = BUS_LoaiTaiKhoan.GetAll(out msg);
        }

        private void iBtnAdd_TaiKhoan_Click(object sender, EventArgs e)
        {
            string tentaikhoan = tbTenTaiKhoan.Text;
            string tendangnhap = tbTenDangNhap.Text;
            string matkhau = tbMatKhau.Text;
            string hotennhanvien = tbHoTenNhanVien.Text;
            string loaitaikhoan = cBLoaiTaiKhoan.SelectedValue.ToString();
            string msg;

            if (!string.IsNullOrEmpty(tentaikhoan) && !string.IsNullOrEmpty(tendangnhap) && !string.IsNullOrEmpty(matkhau) && !string.IsNullOrEmpty(hotennhanvien))
            {
                int loaitaikhoan2 = int.Parse(loaitaikhoan);
                TaiKhoan taiKhoan = new TaiKhoan(tentaikhoan, tendangnhap, matkhau, hotennhanvien, loaitaikhoan2);

                bool kq = BUS_TaiKhoan.Add(taiKhoan, out msg);
                if (kq)
                {
                    dgvTaiKhoan.DataSource = BUS_TaiKhoan.GetAll(out msg);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
            }
        }

        private void iBtnUpdate_TaiKhoan_Click(object sender, EventArgs e)
        {
            string tentaikhoan = tbTenTaiKhoan.Text;
            string tendangnhap = tbTenDangNhap.Text;
            string matkhau = tbMatKhau.Text;
            string hotennhanvien = tbHoTenNhanVien.Text;
            string loaitaikhoan = cBLoaiTaiKhoan.SelectedValue.ToString();
            string msg;

            if (!string.IsNullOrEmpty(tentaikhoan) && !string.IsNullOrEmpty(tendangnhap) && !string.IsNullOrEmpty(matkhau) && !string.IsNullOrEmpty(hotennhanvien))
            {
                int id = int.Parse(dgvTaiKhoan.SelectedRows[0].Cells["id"].Value.ToString());
                int loaitaikhoan2 = int.Parse(loaitaikhoan);
                TaiKhoan taiKhoan = new TaiKhoan(id, tentaikhoan, tendangnhap, matkhau, hotennhanvien, loaitaikhoan2);

                bool kq = BUS_TaiKhoan.Update(taiKhoan, out msg);
                if (kq)
                {
                    dgvTaiKhoan.DataSource = BUS_TaiKhoan.GetAll(out msg);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0 && dgvTaiKhoan.DataSource != null && dgvTaiKhoan.DataSource is List<TaiKhoan>)
            {
                var row = dgvTaiKhoan.SelectedRows[0];
                tbMaTaiKhoan.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                tbTenTaiKhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                tbTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                tbMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                tbHoTenNhanVien.Text = row.Cells["HoTenNhanVien"].Value.ToString();
                cBLoaiTaiKhoan.Text = row.Cells["LoaiTaiKhoan"].Value.ToString();
            }
        }

        private void dgvTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvTaiKhoan.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvTaiKhoan.Rows[hitTestInfo.RowIndex].Selected = true;

                    cMSXoa_TaiKhoan.Show(dgvTaiKhoan, e.Location);
                }
            }
        }

        private void iBtnTaiKhoan_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvTaiKhoan.DataSource = BUS_TaiKhoan.GetAll(out msg);
        }

        private void tbSearch_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvTaiKhoan.DataSource = BUS_TaiKhoan.Search(tbSearch_TaiKhoan.Text, out msg);
        }
    }
}
