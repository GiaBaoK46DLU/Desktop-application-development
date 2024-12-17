namespace BookLibraryManagementProject.Forms
{
    partial class FormQLPMT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            FontAwesome.Sharp.IconButton iBtnPMT_Reload;
            this.tabQLDG = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableCha = new System.Windows.Forms.TableLayoutPanel();
            this.gBNhanVien = new System.Windows.Forms.GroupBox();
            this.cBNhanVien = new System.Windows.Forms.ComboBox();
            this.cBDocGia = new System.Windows.Forms.ComboBox();
            this.dTPNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.dTPNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.btnLuuPhieuMuon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoPhieuMuonSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gBDSSach = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch_DocGia = new System.Windows.Forms.Button();
            this.tbSearch_DocGia = new System.Windows.Forms.TextBox();
            this.dgvHienThiSach = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSachDuocChon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableCha2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCT_PhieuMuonTra = new System.Windows.Forms.DataGridView();
            this.idCT_SoPhieuMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSachMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSTraSach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trảSáchMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tBSearch_PMT = new System.Windows.Forms.TextBox();
            this.dgvPhieuMuonTra = new System.Windows.Forms.DataGridView();
            this.cMSTraHetSach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trảToànBộSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieuMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iBtnPMT_Reload = new FontAwesome.Sharp.IconButton();
            this.tabQLDG.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableCha.SuspendLayout();
            this.gBNhanVien.SuspendLayout();
            this.gBDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDuocChon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableCha2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuMuonTra)).BeginInit();
            this.cMSTraSach.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonTra)).BeginInit();
            this.cMSTraHetSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQLDG
            // 
            this.tabQLDG.Controls.Add(this.tabPage1);
            this.tabQLDG.Controls.Add(this.tabPage2);
            this.tabQLDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQLDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLDG.ItemSize = new System.Drawing.Size(150, 50);
            this.tabQLDG.Location = new System.Drawing.Point(0, 0);
            this.tabQLDG.Name = "tabQLDG";
            this.tabQLDG.SelectedIndex = 0;
            this.tabQLDG.Size = new System.Drawing.Size(1587, 891);
            this.tabQLDG.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableCha);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1579, 833);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mượn sách";
            // 
            // tableCha
            // 
            this.tableCha.ColumnCount = 2;
            this.tableCha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCha.Controls.Add(this.gBNhanVien, 0, 1);
            this.tableCha.Controls.Add(this.gBDSSach, 0, 0);
            this.tableCha.Controls.Add(this.groupBox3, 1, 0);
            this.tableCha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCha.Location = new System.Drawing.Point(0, 0);
            this.tableCha.Name = "tableCha";
            this.tableCha.RowCount = 1;
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCha.Size = new System.Drawing.Size(1579, 833);
            this.tableCha.TabIndex = 4;
            // 
            // gBNhanVien
            // 
            this.gBNhanVien.Controls.Add(this.cBNhanVien);
            this.gBNhanVien.Controls.Add(this.cBDocGia);
            this.gBNhanVien.Controls.Add(this.dTPNgayHenTra);
            this.gBNhanVien.Controls.Add(this.dTPNgayLapPhieu);
            this.gBNhanVien.Controls.Add(this.btnLuuPhieuMuon);
            this.gBNhanVien.Controls.Add(this.label12);
            this.gBNhanVien.Controls.Add(this.label1);
            this.gBNhanVien.Controls.Add(this.tbSoPhieuMuonSach);
            this.gBNhanVien.Controls.Add(this.label5);
            this.gBNhanVien.Controls.Add(this.label6);
            this.gBNhanVien.Controls.Add(this.label7);
            this.gBNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBNhanVien.Location = new System.Drawing.Point(792, 403);
            this.gBNhanVien.Name = "gBNhanVien";
            this.gBNhanVien.Size = new System.Drawing.Size(784, 849);
            this.gBNhanVien.TabIndex = 6;
            this.gBNhanVien.TabStop = false;
            this.gBNhanVien.Text = "Lập phiếu mượn sách";
            // 
            // cBNhanVien
            // 
            this.cBNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBNhanVien.DisplayMember = "HoTenNhanVien";
            this.cBNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNhanVien.FormattingEnabled = true;
            this.cBNhanVien.Location = new System.Drawing.Point(352, 180);
            this.cBNhanVien.Name = "cBNhanVien";
            this.cBNhanVien.Size = new System.Drawing.Size(269, 33);
            this.cBNhanVien.TabIndex = 52;
            this.cBNhanVien.ValueMember = "id";
            // 
            // cBDocGia
            // 
            this.cBDocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBDocGia.DisplayMember = "TenDocGia";
            this.cBDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDocGia.FormattingEnabled = true;
            this.cBDocGia.Location = new System.Drawing.Point(352, 124);
            this.cBDocGia.Name = "cBDocGia";
            this.cBDocGia.Size = new System.Drawing.Size(269, 33);
            this.cBDocGia.TabIndex = 51;
            this.cBDocGia.ValueMember = "id";
            // 
            // dTPNgayHenTra
            // 
            this.dTPNgayHenTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTPNgayHenTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayHenTra.Location = new System.Drawing.Point(352, 298);
            this.dTPNgayHenTra.Name = "dTPNgayHenTra";
            this.dTPNgayHenTra.Size = new System.Drawing.Size(269, 31);
            this.dTPNgayHenTra.TabIndex = 50;
            // 
            // dTPNgayLapPhieu
            // 
            this.dTPNgayLapPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dTPNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayLapPhieu.Location = new System.Drawing.Point(352, 240);
            this.dTPNgayLapPhieu.Name = "dTPNgayLapPhieu";
            this.dTPNgayLapPhieu.Size = new System.Drawing.Size(269, 31);
            this.dTPNgayLapPhieu.TabIndex = 49;
            this.dTPNgayLapPhieu.ValueChanged += new System.EventHandler(this.dTPNgayLapPhieu_ValueChanged);
            // 
            // btnLuuPhieuMuon
            // 
            this.btnLuuPhieuMuon.BackColor = System.Drawing.Color.White;
            this.btnLuuPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuMuon.Location = new System.Drawing.Point(320, 369);
            this.btnLuuPhieuMuon.Name = "btnLuuPhieuMuon";
            this.btnLuuPhieuMuon.Size = new System.Drawing.Size(183, 40);
            this.btnLuuPhieuMuon.TabIndex = 47;
            this.btnLuuPhieuMuon.Text = "Lưu phiếu mượn";
            this.btnLuuPhieuMuon.UseVisualStyleBackColor = false;
            this.btnLuuPhieuMuon.Click += new System.EventHandler(this.btnLuuPhieuMuon_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 26);
            this.label12.TabIndex = 41;
            this.label12.Text = "Số phiếu mượn sách";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày hẹn trả";
            // 
            // tbSoPhieuMuonSach
            // 
            this.tbSoPhieuMuonSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSoPhieuMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoPhieuMuonSach.Location = new System.Drawing.Point(352, 70);
            this.tbSoPhieuMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.tbSoPhieuMuonSach.Name = "tbSoPhieuMuonSach";
            this.tbSoPhieuMuonSach.ReadOnly = true;
            this.tbSoPhieuMuonSach.Size = new System.Drawing.Size(269, 31);
            this.tbSoPhieuMuonSach.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày lập phiếu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nhân viên lập phiếu";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "Độc giả mượn sách";
            // 
            // gBDSSach
            // 
            this.gBDSSach.AutoSize = true;
            this.gBDSSach.BackColor = System.Drawing.Color.White;
            this.gBDSSach.Controls.Add(this.label9);
            this.gBDSSach.Controls.Add(this.btnSearch_DocGia);
            this.gBDSSach.Controls.Add(this.tbSearch_DocGia);
            this.gBDSSach.Controls.Add(this.dgvHienThiSach);
            this.gBDSSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBDSSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDSSach.ForeColor = System.Drawing.Color.Black;
            this.gBDSSach.Location = new System.Drawing.Point(3, 3);
            this.gBDSSach.Name = "gBDSSach";
            this.tableCha.SetRowSpan(this.gBDSSach, 2);
            this.gBDSSach.Size = new System.Drawing.Size(783, 1249);
            this.gBDSSach.TabIndex = 3;
            this.gBDSSach.TabStop = false;
            this.gBDSSach.Text = "Tìm kiếm sách";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tìm kiếm";
            // 
            // btnSearch_DocGia
            // 
            this.btnSearch_DocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch_DocGia.BackColor = System.Drawing.Color.White;
            this.btnSearch_DocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_DocGia.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_DocGia.Location = new System.Drawing.Point(487, 38);
            this.btnSearch_DocGia.Name = "btnSearch_DocGia";
            this.btnSearch_DocGia.Size = new System.Drawing.Size(119, 31);
            this.btnSearch_DocGia.TabIndex = 25;
            this.btnSearch_DocGia.Text = "Tìm";
            this.btnSearch_DocGia.UseVisualStyleBackColor = false;
            // 
            // tbSearch_DocGia
            // 
            this.tbSearch_DocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch_DocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch_DocGia.Location = new System.Drawing.Point(206, 36);
            this.tbSearch_DocGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch_DocGia.Name = "tbSearch_DocGia";
            this.tbSearch_DocGia.Size = new System.Drawing.Size(276, 31);
            this.tbSearch_DocGia.TabIndex = 24;
            // 
            // dgvHienThiSach
            // 
            this.dgvHienThiSach.AllowUserToAddRows = false;
            this.dgvHienThiSach.AllowUserToDeleteRows = false;
            this.dgvHienThiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThiSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHienThiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MaSach,
            this.TenSach});
            this.dgvHienThiSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHienThiSach.Location = new System.Drawing.Point(0, 84);
            this.dgvHienThiSach.MultiSelect = false;
            this.dgvHienThiSach.Name = "dgvHienThiSach";
            this.dgvHienThiSach.ReadOnly = true;
            this.dgvHienThiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThiSach.Size = new System.Drawing.Size(786, 750);
            this.dgvHienThiSach.TabIndex = 0;
            this.dgvHienThiSach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHienThiSach_MouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 50.76142F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 105.471F;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 105.471F;
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSachDuocChon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(792, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 394);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dgvSachDuocChon
            // 
            this.dgvSachDuocChon.AllowUserToAddRows = false;
            this.dgvSachDuocChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachDuocChon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSachDuocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDuocChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSachDuocChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachDuocChon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSachDuocChon.Location = new System.Drawing.Point(3, 34);
            this.dgvSachDuocChon.Name = "dgvSachDuocChon";
            this.dgvSachDuocChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachDuocChon.Size = new System.Drawing.Size(778, 357);
            this.dgvSachDuocChon.TabIndex = 1;
            this.dgvSachDuocChon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSachDuocChon_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSach";
            this.dataGridViewTextBoxColumn2.FillWeight = 105.471F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn3.FillWeight = 105.471F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tableCha2);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1579, 833);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trả sách";
            // 
            // tableCha2
            // 
            this.tableCha2.ColumnCount = 2;
            this.tableCha2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCha2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCha2.Controls.Add(this.dgvCT_PhieuMuonTra, 1, 1);
            this.tableCha2.Controls.Add(this.groupBox2, 1, 0);
            this.tableCha2.Controls.Add(this.groupBox11, 0, 0);
            this.tableCha2.Controls.Add(this.dgvPhieuMuonTra, 0, 1);
            this.tableCha2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCha2.Location = new System.Drawing.Point(3, 3);
            this.tableCha2.Name = "tableCha2";
            this.tableCha2.RowCount = 2;
            this.tableCha2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableCha2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableCha2.Size = new System.Drawing.Size(1573, 827);
            this.tableCha2.TabIndex = 0;
            // 
            // dgvCT_PhieuMuonTra
            // 
            this.dgvCT_PhieuMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_PhieuMuonTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCT_PhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCT_SoPhieuMuonTra,
            this.TenSachMuon,
            this.NgayTra});
            this.dgvCT_PhieuMuonTra.ContextMenuStrip = this.cMSTraSach;
            this.dgvCT_PhieuMuonTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCT_PhieuMuonTra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCT_PhieuMuonTra.Location = new System.Drawing.Point(789, 143);
            this.dgvCT_PhieuMuonTra.MultiSelect = false;
            this.dgvCT_PhieuMuonTra.Name = "dgvCT_PhieuMuonTra";
            this.dgvCT_PhieuMuonTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_PhieuMuonTra.Size = new System.Drawing.Size(781, 681);
            this.dgvCT_PhieuMuonTra.TabIndex = 8;
            this.dgvCT_PhieuMuonTra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCT_PhieuMuonTra_MouseDown);
            // 
            // idCT_SoPhieuMuonTra
            // 
            this.idCT_SoPhieuMuonTra.DataPropertyName = "ID";
            this.idCT_SoPhieuMuonTra.HeaderText = "ID";
            this.idCT_SoPhieuMuonTra.Name = "idCT_SoPhieuMuonTra";
            // 
            // TenSachMuon
            // 
            this.TenSachMuon.DataPropertyName = "TenSach";
            this.TenSachMuon.HeaderText = "Tên sách mượn";
            this.TenSachMuon.Name = "TenSachMuon";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả sách";
            this.NgayTra.Name = "NgayTra";
            // 
            // cMSTraSach
            // 
            this.cMSTraSach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảSáchMượnToolStripMenuItem});
            this.cMSTraSach.Name = "cMSTraSach";
            this.cMSTraSach.Size = new System.Drawing.Size(152, 26);
            // 
            // trảSáchMượnToolStripMenuItem
            // 
            this.trảSáchMượnToolStripMenuItem.Name = "trảSáchMượnToolStripMenuItem";
            this.trảSáchMượnToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.trảSáchMượnToolStripMenuItem.Text = "Trả sách mượn";
            this.trảSáchMượnToolStripMenuItem.Click += new System.EventHandler(this.trảSáchMượnToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(789, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 134);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(iBtnPMT_Reload);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.tBSearch_PMT);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(780, 134);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(66, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 26);
            this.label21.TabIndex = 21;
            this.label21.Text = "Tìm kiếm";
            // 
            // tBSearch_PMT
            // 
            this.tBSearch_PMT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBSearch_PMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch_PMT.Location = new System.Drawing.Point(172, 51);
            this.tBSearch_PMT.Margin = new System.Windows.Forms.Padding(2);
            this.tBSearch_PMT.Name = "tBSearch_PMT";
            this.tBSearch_PMT.Size = new System.Drawing.Size(452, 31);
            this.tBSearch_PMT.TabIndex = 21;
            this.tBSearch_PMT.TextChanged += new System.EventHandler(this.tBSearch_PMT_TextChanged);
            // 
            // dgvPhieuMuonTra
            // 
            this.dgvPhieuMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhieuMuonTra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.SoPhieuMuonTra,
            this.DocGia,
            this.NhanVien,
            this.NgayMuon,
            this.HanTra,
            this.TrangThaiSach,
            this.TienPhat});
            this.dgvPhieuMuonTra.ContextMenuStrip = this.cMSTraHetSach;
            this.dgvPhieuMuonTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuMuonTra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPhieuMuonTra.Location = new System.Drawing.Point(3, 143);
            this.dgvPhieuMuonTra.MultiSelect = false;
            this.dgvPhieuMuonTra.Name = "dgvPhieuMuonTra";
            this.dgvPhieuMuonTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuonTra.Size = new System.Drawing.Size(780, 681);
            this.dgvPhieuMuonTra.TabIndex = 6;
            this.dgvPhieuMuonTra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhieuMuonTra_MouseDoubleClick);
            this.dgvPhieuMuonTra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPhieuMuonTra_MouseDown);
            // 
            // cMSTraHetSach
            // 
            this.cMSTraHetSach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảToànBộSáchToolStripMenuItem});
            this.cMSTraHetSach.Name = "cMSTraHetSach";
            this.cMSTraHetSach.Size = new System.Drawing.Size(164, 26);
            // 
            // trảToànBộSáchToolStripMenuItem
            // 
            this.trảToànBộSáchToolStripMenuItem.Name = "trảToànBộSáchToolStripMenuItem";
            this.trảToànBộSáchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.trảToànBộSáchToolStripMenuItem.Text = "Trả toàn bộ sách ";
            this.trảToànBộSáchToolStripMenuItem.Click += new System.EventHandler(this.trảToànBộSáchToolStripMenuItem_Click);
            // 
            // iBtnPMT_Reload
            // 
            iBtnPMT_Reload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            iBtnPMT_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iBtnPMT_Reload.ForeColor = System.Drawing.Color.White;
            iBtnPMT_Reload.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iBtnPMT_Reload.IconColor = System.Drawing.Color.Black;
            iBtnPMT_Reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnPMT_Reload.IconSize = 25;
            iBtnPMT_Reload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iBtnPMT_Reload.Location = new System.Drawing.Point(647, 51);
            iBtnPMT_Reload.Name = "iBtnPMT_Reload";
            iBtnPMT_Reload.Size = new System.Drawing.Size(34, 31);
            iBtnPMT_Reload.TabIndex = 24;
            iBtnPMT_Reload.UseVisualStyleBackColor = true;
            iBtnPMT_Reload.Click += new System.EventHandler(this.iBtnPMT_Reload_Click);
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID";
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.Width = 69;
            // 
            // SoPhieuMuonTra
            // 
            this.SoPhieuMuonTra.DataPropertyName = "SoPhieuMuonTra";
            this.SoPhieuMuonTra.HeaderText = "Số phiếu mượn trả";
            this.SoPhieuMuonTra.Name = "SoPhieuMuonTra";
            this.SoPhieuMuonTra.Width = 218;
            // 
            // DocGia
            // 
            this.DocGia.DataPropertyName = "TenDocGia";
            this.DocGia.HeaderText = "Tên độc giả";
            this.DocGia.Name = "DocGia";
            this.DocGia.Width = 139;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "HoTenNhanVien";
            this.NhanVien.HeaderText = "Tên nhân viên";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Width = 203;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 169;
            // 
            // HanTra
            // 
            this.HanTra.DataPropertyName = "HanTra";
            this.HanTra.HeaderText = "Hạn trả";
            this.HanTra.Name = "HanTra";
            this.HanTra.Width = 92;
            // 
            // TrangThaiSach
            // 
            this.TrangThaiSach.DataPropertyName = "TrangThaiSach";
            this.TrangThaiSach.HeaderText = "Trạng thái sách";
            this.TrangThaiSach.Name = "TrangThaiSach";
            this.TrangThaiSach.Width = 163;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "TienPhat";
            this.TienPhat.HeaderText = "Tiền phạt";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.Width = 96;
            // 
            // FormQLPMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 891);
            this.Controls.Add(this.tabQLDG);
            this.Name = "FormQLPMT";
            this.Text = "Quản Lý Phiếu Mượn Trả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQLPMT_Load);
            this.tabQLDG.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableCha.ResumeLayout(false);
            this.tableCha.PerformLayout();
            this.gBNhanVien.ResumeLayout(false);
            this.gBNhanVien.PerformLayout();
            this.gBDSSach.ResumeLayout(false);
            this.gBDSSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDuocChon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableCha2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuMuonTra)).EndInit();
            this.cMSTraSach.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonTra)).EndInit();
            this.cMSTraHetSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQLDG;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableCha;
        private System.Windows.Forms.GroupBox gBDSSach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch_DocGia;
        private System.Windows.Forms.TextBox tbSearch_DocGia;
        private System.Windows.Forms.DataGridView dgvHienThiSach;
        private System.Windows.Forms.TableLayoutPanel tableCha2;
        private System.Windows.Forms.DataGridView dgvCT_PhieuMuonTra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tBSearch_PMT;
        private System.Windows.Forms.DataGridView dgvPhieuMuonTra;
        private System.Windows.Forms.GroupBox gBNhanVien;
        private System.Windows.Forms.DateTimePicker dTPNgayHenTra;
        private System.Windows.Forms.DateTimePicker dTPNgayLapPhieu;
        private System.Windows.Forms.Button btnLuuPhieuMuon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoPhieuMuonSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSachDuocChon;
        private System.Windows.Forms.ComboBox cBNhanVien;
        private System.Windows.Forms.ComboBox cBDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip cMSTraSach;
        private System.Windows.Forms.ToolStripMenuItem trảSáchMượnToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCT_SoPhieuMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.ContextMenuStrip cMSTraHetSach;
        private System.Windows.Forms.ToolStripMenuItem trảToànBộSáchToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
    }
}