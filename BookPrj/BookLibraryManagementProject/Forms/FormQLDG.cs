using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Interop;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormQLDG : Form
    {
        public FormQLDG()
        {
            InitializeComponent();
            cMSXoa_QLDG.Items[0].Click += btnXoa_QLDG_Click;
        }

        private void btnXoa_QLDG_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            switch (tabQLDG.SelectedIndex)
            {
                case 0:
                    if (dgvDocGia.SelectedRows.Count > 0 && dgvDocGia.DataSource != null && dgvDocGia.DataSource is List<DocGia>)
                    {
                        var row = dgvDocGia.SelectedRows[0];
                        bool kq = BUS_DocGia.Delete(int.Parse(row.Cells["id"].Value.ToString()), out msg);
                        if (kq)
                        {
                            dgvDocGia.DataSource = BUS_DocGia.GetAll(out msg);
                            MessageBox.Show("Xóa độc giả thành công");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {msg}");
                        }
                    }
                    break;

                case 1:
                    if (dgvLoaiDocGia.SelectedRows.Count > 0 && dgvLoaiDocGia.DataSource != null && dgvLoaiDocGia.DataSource is List<LoaiDocGia>)
                    {
                        var row = dgvLoaiDocGia.SelectedRows[0];
                        bool kq = BUS_LoaiDocGia.Delete(int.Parse(row.Cells["id2"].Value.ToString()), out msg);
                        if (kq)
                        {
                            dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.GetAll(out msg);
                            MessageBox.Show("Xóa loại độc giả thành công");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {msg}");
                        }
                    }
                    break;
            }
        }

        private void FormQLDG_Load(object sender, EventArgs e)
        {
            string msg;
            dgvDocGia.DataSource = BUS_DocGia.GetAll(out msg);
            dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.GetAll(out msg);
            cBLoaiDocGia.DataSource = BUS_LoaiDocGia.GetAll(out msg);
        }
        //Xử lý các sự kiện của Độc Giả
        private void iBtnAddDG_Click(object sender, EventArgs e)
        {
            string tendocgia = tbTenDocGia.Text;
            string ngaysinh = tbNgaySinh.Text;
            string ngaylapthe = tbNgayLapThe.Text;
            string ngayhethan = tbNgayHetHan.Text;
            string sodienthoai = tbSoDienThoai.Text;
            string diachi = tbDiaChi.Text;
            string gioitinh = tbGioiTinh.Text;
            string idloaidocgia = cBLoaiDocGia.SelectedValue.ToString();
            string msg;

            if (!string.IsNullOrEmpty(tendocgia) && !string.IsNullOrEmpty(ngaysinh) && !string.IsNullOrEmpty(ngaylapthe) && !string.IsNullOrEmpty(ngayhethan) && !string.IsNullOrEmpty(sodienthoai) && !string.IsNullOrEmpty(diachi) && !string.IsNullOrEmpty(gioitinh))
            {
                DateTime ngaysinh2 = DateTime.Parse(ngaysinh);
                DateTime ngaylapthe2 = DateTime.Parse(ngaylapthe);
                DateTime ngayhethan2 = DateTime.Parse(ngayhethan);
                int idloaidocgia2 = int.Parse(idloaidocgia);
                DocGia docGia = new DocGia(tendocgia, ngaysinh2, ngaylapthe2, ngayhethan2, sodienthoai, diachi, gioitinh, idloaidocgia2);

                bool kq = BUS_DocGia.Add(docGia, out msg);
                if (kq)
                {
                    dgvDocGia.DataSource = BUS_DocGia.GetAll(out msg);
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


        private void iBtnUpdateDG_Click(object sender, EventArgs e)
        {
            string tendocgia = tbTenDocGia.Text;
            string ngaysinh = tbNgaySinh.Text;
            string ngaylapthe = tbNgayLapThe.Text;
            string ngayhethan = tbNgayHetHan.Text;
            string sodienthoai = tbSoDienThoai.Text;
            string diachi = tbDiaChi.Text;
            string gioitinh = tbGioiTinh.Text;
            string idloaidocgia = cBLoaiDocGia.SelectedValue.ToString();
            string msg;

            if (!string.IsNullOrEmpty(tendocgia) && !string.IsNullOrEmpty(ngaysinh) && !string.IsNullOrEmpty(ngaylapthe) && !string.IsNullOrEmpty(ngayhethan) && !string.IsNullOrEmpty(sodienthoai) && !string.IsNullOrEmpty(diachi) && !string.IsNullOrEmpty(gioitinh))
            {
                int id = int.Parse(dgvDocGia.SelectedRows[0].Cells["id"].Value.ToString());
                DateTime ngaysinh2 = DateTime.Parse(ngaysinh);
                DateTime ngaylapthe2 = DateTime.Parse(ngaylapthe);
                DateTime ngayhethan2 = DateTime.Parse(ngayhethan);
                int idloaidocgia2 = int.Parse(idloaidocgia);
                DocGia docGia = new DocGia(id, tendocgia, ngaysinh2, ngaylapthe2, ngayhethan2, sodienthoai, diachi, gioitinh, idloaidocgia2);

                bool kq = BUS_DocGia.Update(docGia, out msg);
                if (kq)
                {
                    dgvDocGia.DataSource = BUS_DocGia.GetAll(out msg);
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
        private void dgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocGia.SelectedRows.Count > 0 && dgvDocGia.DataSource != null && dgvDocGia.DataSource is List<DocGia>)
            {
                var row = dgvDocGia.SelectedRows[0];
                tbMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
                tbTenDocGia.Text = row.Cells["TenDocGia"].Value.ToString();
                tbNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                tbNgayLapThe.Text = row.Cells["NgayLapThe"].Value.ToString();
                tbNgayHetHan.Text = row.Cells["NgayHetHan"].Value.ToString();
                tbSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                tbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                cBLoaiDocGia.Text = row.Cells["LoaiDocGia"].Value.ToString();
            }
        }

        private void dgvDocGia_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvDocGia.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvDocGia.Rows[hitTestInfo.RowIndex].Selected = true;
                    cMSXoa_QLDG.Show(dgvDocGia, e.Location);
                }
            }
        }

        private void tbSearch_DocGia_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvDocGia.DataSource = BUS_DocGia.Search(tbSearch_DocGia.Text, out msg);
        }
        private void iBtnDocGia_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvDocGia.DataSource = BUS_DocGia.GetAll(out msg);
        }

        //Xử lý các sự kiện của Loại Độc Giả
        private void iBtnAdd_LDG_Click(object sender, EventArgs e)
        {
            string tenloaidocgia = tBTenLDG.Text;
            string msg;

            if (!string.IsNullOrEmpty(tenloaidocgia))
            {
                LoaiDocGia loaiDocGia = new LoaiDocGia(tenloaidocgia);

                bool kq = BUS_LoaiDocGia.Add(loaiDocGia, out msg);
                if (kq)
                {
                    dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.GetAll(out msg);
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

        private void iBtnUpdate_LDG_Click(object sender, EventArgs e)
        {
            string tenloaidocgia = tBTenLDG.Text;
            string msg;

            if (!string.IsNullOrEmpty(tenloaidocgia))
            {
                int id = int.Parse(dgvLoaiDocGia.SelectedRows[0].Cells["id2"].Value.ToString());
                LoaiDocGia loaiDocGia = new LoaiDocGia(id, tenloaidocgia);

                bool kq = BUS_LoaiDocGia.Update(loaiDocGia, out msg);
                if (kq)
                {
                    dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.GetAll(out msg);
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

        private void dgvLoaiDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiDocGia.SelectedRows.Count > 0 && dgvLoaiDocGia.DataSource != null && dgvLoaiDocGia.DataSource is List<LoaiDocGia>)
            {
                var row = dgvLoaiDocGia.SelectedRows[0];
                tBMaLDG.Text = row.Cells["MaLoaiDocGia"].Value.ToString();
                tBTenLDG.Text = row.Cells["TenLoaiDocGia"].Value.ToString();
            }
        }

        private void dgvLoaiDocGia_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvLoaiDocGia.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvLoaiDocGia.Rows[hitTestInfo.RowIndex].Selected = true;
                    cMSXoa_QLDG.Show(dgvLoaiDocGia, e.Location);
                }
            }
        }

        private void btnSearch_LDG_Click(object sender, EventArgs e)
        {
            string msg;
            if (!string.IsNullOrWhiteSpace(tBSearch_LDG.Text))
            {
                dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.Search(tBSearch_LDG.Text, out msg);
            }
        }

        private void iBtnLoaiDocGia_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.GetAll(out msg);
        }

        private void tBSearch_LDG_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvLoaiDocGia.DataSource = BUS_LoaiDocGia.Search(tBSearch_LDG.Text, out msg);
        }
    }
}
