using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormQLPMT : Form
    {
        public FormQLPMT()
        {
            InitializeComponent();
        }

        private void FormQLPMT_Load(object sender, EventArgs e)
        {
            string msg;
            dgvHienThiSach.DataSource = BUS_Sach.GetAll2(out msg);

            var suggest = new AutoCompleteStringCollection();
            var dsDocGia = BUS_DocGia.GetAll(out msg);
            cBDocGia.DataSource = dsDocGia;
            suggest.AddRange(dsDocGia.Select(s => s.TenDocGia).ToArray());
            cBDocGia.AutoCompleteCustomSource = suggest;

            cBNhanVien.DataSource = BUS_TaiKhoan.GetAll(out msg);
            if (UserInfo.idLoaiTaiKhoan == 2) // Neu la nhan vien
            {
                cBNhanVien.Enabled = false;
                cBNhanVien.SelectedValue = UserInfo.id;
            }

            dgvPhieuMuonTra.DataSource = BUS_PhieuMuonTra.GetAll(out msg);
            dTPNgayHenTra.Value = dTPNgayLapPhieu.Value.AddMonths(1);
        }
        private void dTPNgayLapPhieu_ValueChanged(object sender, EventArgs e)
        {
            dTPNgayHenTra.Value = dTPNgayLapPhieu.Value.AddMonths(1);
        }

        private void btnLuuPhieuMuon_Click(object sender, EventArgs e)
        {
            string msg;
            if (dgvSachDuocChon.Rows.Count > 0)
            {
                string docgia = cBDocGia.SelectedValue.ToString();
                string nhanvien = cBNhanVien.SelectedValue.ToString();
                DateTime ngaylapphieu = dTPNgayLapPhieu.Value;
                DateTime ngayhethan = dTPNgayHenTra.Value;

                int docgia2 = int.Parse(docgia);
                int nhanvien2 = int.Parse(nhanvien);
                PhieuMuonTra phieuMuonTra = new PhieuMuonTra(docgia2, nhanvien2, ngaylapphieu, ngayhethan, false, "Chưa trả", 0);
                int idPMT = BUS_PhieuMuonTra.Add(phieuMuonTra, out msg);
                if (idPMT > 0)
                {
                    dgvPhieuMuonTra.DataSource = BUS_PhieuMuonTra.GetAll(out msg);
                    foreach (DataGridViewRow row in dgvSachDuocChon.Rows)
                    {
                        CT_PhieuMuonTra ct = new CT_PhieuMuonTra(idPMT, int.Parse(row.Cells[0].Value.ToString()), "");
                        BUS_CTPhieuMuonTra.Add(ct, out msg);
                    }
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách muốn mượn");
            }
        }

        private void dgvHienThiSach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvHienThiSach.SelectedRows.Count > 0 && dgvHienThiSach.DataSource != null && dgvHienThiSach.DataSource is List<Sach_PMT>)
            {
                var lrow = dgvHienThiSach.SelectedRows[0];
                var newRow = new DataGridViewRow();
                foreach (DataGridViewCell cell in lrow.Cells)
                {
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell.Value });
                }
                var lid = newRow.Cells[0].Value;
                foreach (DataGridViewRow rrow in dgvSachDuocChon.Rows)
                {
                    var rid = rrow.Cells[0].Value;
                    if (lid.ToString() == rid.ToString())
                        return;
                }
                dgvSachDuocChon.Rows.Add(newRow);
            }
        }

        private void dgvSachDuocChon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSachDuocChon.CurrentRow != null)
            {
                var selectedRow = dgvSachDuocChon.CurrentRow;
                dgvSachDuocChon.Rows.Remove(selectedRow);
            }
        }

        private void dgvPhieuMuonTra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string msg;

            if (dgvPhieuMuonTra.SelectedRows.Count > 0 && dgvPhieuMuonTra.DataSource != null && dgvPhieuMuonTra.DataSource is List<PhieuMuonTra>)
            {
                var row = dgvPhieuMuonTra.SelectedRows[0];
                var idPMT = row.Cells["ID2"].Value;
                int id = int.Parse(idPMT.ToString());
                dgvCT_PhieuMuonTra.DataSource = BUS_CTPhieuMuonTra.SearchByID_PMT(id, out msg);
            }
        }

        private void trảSáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;

            if (dgvCT_PhieuMuonTra.SelectedRows.Count > 0 && dgvCT_PhieuMuonTra.DataSource != null && dgvCT_PhieuMuonTra.DataSource is List<CT_PhieuMuonTra>)
            {
                var rrow = dgvCT_PhieuMuonTra.SelectedRows[0];
                var idCT_PMT = rrow.Cells["idCT_SoPhieuMuonTra"].Value;
                int rid = int.Parse(idCT_PMT.ToString());
                var lrow = dgvPhieuMuonTra.SelectedRows[0];
                var idPMT = lrow.Cells["ID2"].Value;
                int lid = int.Parse(idPMT.ToString());
                bool kq = BUS_CTPhieuMuonTra.TraSach(rid, out msg);
                if (kq)
                {
                    dgvCT_PhieuMuonTra.DataSource = BUS_CTPhieuMuonTra.SearchByID_PMT(lid, out msg);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void dgvCT_PhieuMuonTra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvCT_PhieuMuonTra.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvCT_PhieuMuonTra.Rows[hitTestInfo.RowIndex].Selected = true;

                    cMSTraSach.Show(dgvCT_PhieuMuonTra, e.Location);
                }
            }
        }

        private void trảToànBộSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg;
            if (dgvPhieuMuonTra.SelectedRows.Count > 0 && dgvPhieuMuonTra.DataSource != null && dgvPhieuMuonTra.DataSource is List<PhieuMuonTra>)
            {
                var row = dgvPhieuMuonTra.SelectedRows[0];
                var id = row.Cells["ID2"].Value.ToString();
                int id2 = int.Parse(id);
                bool kq = BUS_PhieuMuonTra.Update(id2, out msg);
                if (kq)
                {
                    dgvPhieuMuonTra.DataSource = BUS_PhieuMuonTra.GetAll(out msg);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void dgvPhieuMuonTra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvPhieuMuonTra.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvPhieuMuonTra.Rows[hitTestInfo.RowIndex].Selected = true;

                    cMSTraHetSach.Show(dgvPhieuMuonTra, e.Location);
                }
            }
        }

        private void tBSearch_PMT_TextChanged(object sender, EventArgs e)
        {
            string msg;
            dgvPhieuMuonTra.DataSource = BUS_PhieuMuonTra.Search(tBSearch_PMT.Text, out msg);
        }

        private void iBtnPMT_Reload_Click(object sender, EventArgs e)
        {
            string msg;
            dgvPhieuMuonTra.DataSource = BUS_PhieuMuonTra.GetAll(out msg);
        }
    }
}
