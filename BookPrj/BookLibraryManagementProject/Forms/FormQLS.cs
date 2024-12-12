using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormQLS : Form
    {
        public FormQLS()
        {
            InitializeComponent();
            cMSXoa.Items[0].Click += btnXoa_Click;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            switch (tabQLS.SelectedIndex)
            {
                case 0:
                    if (dgvSach.SelectedRows.Count > 0 && dgvSach.DataSource != null && dgvSach.DataSource is List<Sach_QLS>)
                    {
                        var row = dgvSach.SelectedRows[0];
                        bool kq = BUS_Sach.Delete(int.Parse(row.Cells["id"].Value.ToString()), out string msg);
                        if (kq)
                        {
                            dgvSach.DataSource = BUS_Sach.GetAll(out msg);
                            MessageBox.Show("Xóa sách thành công");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi: " + msg);
                        }
                    }
                    break;

                case 1:
                    if (dgvTheLoai.SelectedRows.Count > 0 && dgvTheLoai.DataSource != null && dgvTheLoai.DataSource is List<TheLoai>)
                    {
                        var row = dgvTheLoai.SelectedRows[0];
                        bool kq = BUS_TheLoai.Delete(int.Parse(row.Cells["id2"].Value.ToString()), out string msg);
                        if (kq)
                        {
                            dgvTheLoai.DataSource = BUS_TheLoai.GetAll(out msg);
                            MessageBox.Show("Xóa thể loại thành công");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {msg}");
                        }
                    }
                    break;

                case 2:
                    if (dgvTacGia.SelectedRows.Count > 0 && dgvTacGia.DataSource != null && dgvTacGia.DataSource is List<TacGia>)
                    {
                        var row = dgvTacGia.SelectedRows[0];
                        bool kq = BUS_TacGia.Delete(int.Parse(row.Cells["id3"].Value.ToString()), out string msg);
                        if (kq)
                        {
                            dgvTacGia.DataSource = BUS_TacGia.GetAll(out msg);
                            MessageBox.Show("Xóa tác giả thành công");
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {msg}");
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        //Xử lý các sự kiện của Sách
        private async void FormQLS_Load(object sender, EventArgs e)
        {
            string msg;
            dgvSach.DataSource = BUS_Sach.GetAll(out msg);
            cBTheLoai.DataSource = BUS_TheLoai.GetAll(out msg);
            cBTacGia.DataSource = BUS_TacGia.GetAll(out msg);
            dgvTheLoai.DataSource = BUS_TheLoai.GetAll(out msg);
            dgvTacGia.DataSource = BUS_TacGia.GetAll(out msg);
            cBNhaXB.DataSource = BUS_NhaXuatBan.GetAll(out msg);
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            string tensach = tbTenSach.Text;
            string idtheloai = cBTheLoai.SelectedValue.ToString();
            string idtacgia = cBTacGia.SelectedValue.ToString();
            string giabia = tbGiaBia.Text;
            string soluong = tbSoLuong.Text;
            string namxb = tbNamXB.Text;
            string idnhaxb = cBNhaXB.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(tensach) && !string.IsNullOrEmpty(giabia) && !string.IsNullOrEmpty(namxb) && !string.IsNullOrEmpty(soluong))
            {
                int giabia2 = int.Parse(giabia);
                int soluong2 = int.Parse(soluong);
                int namxb2 = int.Parse(namxb);
                int idtheloai2 = int.Parse(idtheloai);
                int idtacgia2 = int.Parse(idtacgia);
                Sach_QLS sach = new Sach_QLS(tensach, idtheloai2, idtacgia2, idnhaxb, namxb2, soluong2, giabia2);

                bool kq = BUS_Sach.Add(sach, out string msg);
                if (kq)
                {
                    dgvSach.DataSource = BUS_Sach.GetAll(out msg);
                    MessageBox.Show("Thêm sách thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi: " + msg);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
            }
        }


        private void iBtnUpdate_Click(object sender, EventArgs e)
        {
            string tensach = tbTenSach.Text;
            string idtheloai = cBTheLoai.SelectedValue.ToString();
            string idtacgia = cBTacGia.SelectedValue.ToString();
            string giabia = tbGiaBia.Text;
            string soluong = tbSoLuong.Text;
            string namxb = tbNamXB.Text;
            string nhaxb = cBNhaXB.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(tensach) && !string.IsNullOrEmpty(giabia) && !string.IsNullOrEmpty(namxb) && !string.IsNullOrEmpty(soluong))
            {
                int id = int.Parse(dgvSach.SelectedRows[0].Cells["id"].Value.ToString());
                int giabia2 = int.Parse(giabia);
                int soluong2 = int.Parse(soluong);
                int namxb2 = int.Parse(namxb);
                int idtheloai2 = int.Parse(idtheloai);
                int idtacgia2 = int.Parse(idtacgia);
                Sach_QLS sach = new Sach_QLS(id, tensach, idtheloai2, idtacgia2, nhaxb, namxb2, soluong2, giabia2);

                bool kq = BUS_Sach.Update(sach, out string msg);
                if (kq)
                {
                    dgvSach.DataSource = BUS_Sach.GetAll(out msg);
                    MessageBox.Show("Cập nhật sách thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi: " + msg);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
            }
        }


        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0 && dgvSach.DataSource != null && dgvSach.DataSource is List<Sach_QLS>)
            {
                var row = dgvSach.SelectedRows[0];
                tbMaSach.Text = row.Cells["MaSach"].Value.ToString();
                tbTenSach.Text = row.Cells["TenSach"].Value.ToString();
                tbGiaBia.Text = row.Cells["GiaBia"].Value.ToString();
                tbSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                tbNamXB.Text = row.Cells["NamXB"].Value.ToString();
                cBTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
                cBTacGia.Text = row.Cells["TacGia"].Value.ToString();
                cBNhaXB.Text = row.Cells["NhaXuatBan"].Value.ToString();
            }
        }


        private void dgvSach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvSach.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvSach.Rows[hitTestInfo.RowIndex].Selected = true;

                    cMSXoa.Show(dgvSach, e.Location);
                }
            }
        }

        private void btnSearch_Sach_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tBSearch_Sach.Text))
            {
                dgvSach.DataSource = BUS_Sach.Search(tBSearch_Sach.Text, out string msg);
                if (dgvSach.DataSource == null || (dgvSach.DataSource as List<Sach_QLS>).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Error");
            }
        }



        private void iBtnSach_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvSach.DataSource = BUS_Sach.GetAll(out msg);
        }
        //Xử lý các sự kiện của Thể Loại
        private void iBtnAddTL_Click(object sender, EventArgs e)
        {
            string tentheloai = tbTenTheLoai.Text;

            if (!string.IsNullOrEmpty(tentheloai))
            {
                TheLoai theLoai = new TheLoai(tentheloai);

                bool kq = BUS_TheLoai.Add(theLoai, out string msg);
                if (kq)
                {
                    dgvTheLoai.DataSource = BUS_TheLoai.GetAll(out msg);
                    MessageBox.Show("Thêm thể loại thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi: " + msg);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Error");
            }
        }


        private void iBtnUpdateTL_Click(object sender, EventArgs e)
        {
            string tentheloai = tbTenTheLoai.Text;
            string msg;
            if (!string.IsNullOrEmpty(tentheloai))
            {
                int id = int.Parse(dgvTheLoai.SelectedRows[0].Cells["id2"].Value.ToString());
                TheLoai theLoai = new TheLoai(id, tentheloai);

                bool kq = BUS_TheLoai.Update(theLoai, out msg);
                if (kq)
                {
                    dgvTheLoai.DataSource = BUS_TheLoai.GetAll(out msg);
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

        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count > 0 && dgvTheLoai.DataSource != null && dgvTheLoai.DataSource is List<TheLoai>)
            {
                var row = dgvTheLoai.SelectedRows[0];
                tbMaTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                tbTenTheLoai.Text = row.Cells["TenTheLoai"].Value.ToString();
            }
        }

        private void dgvTheLoai_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvTheLoai.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvTheLoai.Rows[hitTestInfo.RowIndex].Selected = true;
                    cMSXoa.Show(dgvTheLoai, e.Location);
                }
            }
        }

        private void btnSearch_TheLoai_Click(object sender, EventArgs e)
        {
            string msg;
            if (!string.IsNullOrWhiteSpace(tbSearch_TheLoai.Text))
            {
                dgvTheLoai.DataSource = BUS_TheLoai.Search(tbSearch_TheLoai.Text, out msg);
            }
        }


        private void iBtnTheLoai_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvTheLoai.DataSource = BUS_TheLoai.GetAll(out msg);
        }
        //Xử lý các sự kiện của Tác Giả
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
                    dgvTacGia.DataSource = BUS_TacGia.GetAll(out msg);
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
        private void iBtn_Update_TacGia_Click(object sender, EventArgs e)
        {
            string tentacgia = tbTenTacGia.Text;
            string msg;
            if (!string.IsNullOrEmpty(tentacgia))
            {
                int id = int.Parse(dgvTacGia.SelectedRows[0].Cells["id3"].Value.ToString());
                TacGia tacGia = new TacGia(id, tentacgia);

                bool kq = BUS_TacGia.Update(tacGia, out msg);
                if (kq)
                {
                    dgvTacGia.DataSource = BUS_TacGia.GetAll(out msg);
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
        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0 && dgvTacGia.DataSource != null && dgvTacGia.DataSource is List<TacGia>)
            {
                var row = dgvTacGia.SelectedRows[0];
                tbMaTacGia.Text = row.Cells["MaTacGia"].Value.ToString();
                tbTenTacGia.Text = row.Cells["TenTacGia"].Value.ToString();
            }
        }

        private void dgvTacGia_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvTacGia.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvTacGia.Rows[hitTestInfo.RowIndex].Selected = true;
                    cMSXoa.Show(dgvTacGia, e.Location);
                }
            }
        }

        private void iBtnTacGia_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvTacGia.DataSource = BUS_TacGia.GetAll(out msg);
        }

        private void tBSearch_Sach_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvSach.DataSource = BUS_Sach.Search(tBSearch_Sach.Text, out msg);
        }

        private void tbSearch_TheLoai_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvTheLoai.DataSource = BUS_TheLoai.Search(tbSearch_TheLoai.Text, out msg);
        }

        private void tBSearch_TacGia_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvTacGia.DataSource = BUS_TacGia.Search(tBSearch_TacGia.Text, out msg);
        }

        private void iBtnAdd_TheLoai_Click(object sender, EventArgs e)
        {
            Form f = new FormThemTL();
            f.ShowDialog();
            FormQLS_Load(sender, e);
        }

        private void iBtnAdd_TacGia_Click(object sender, EventArgs e)
        {
            Form f = new FormThemTG();
            f.ShowDialog();
            FormQLS_Load(sender, e);
        }
    }
}
