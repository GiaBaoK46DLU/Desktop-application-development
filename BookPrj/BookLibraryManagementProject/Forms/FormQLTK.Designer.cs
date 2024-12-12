namespace BookLibraryManagementProject.Forms
{
    partial class FormQLTK
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
            FontAwesome.Sharp.IconButton iBtnTaiKhoan_Reload;
            this.cMSXoa_TaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabQLTK = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableCha = new System.Windows.Forms.TableLayoutPanel();
            this.gBDSDocGia = new System.Windows.Forms.GroupBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBTTTaiKhoan = new System.Windows.Forms.GroupBox();
            this.cBLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.tbHoTenNhanVien = new System.Windows.Forms.TextBox();
            this.tbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbTenDangNhap = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iBtnUpdate_TaiKhoan = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd_TaiKhoan = new FontAwesome.Sharp.IconButton();
            this.tbMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            iBtnTaiKhoan_Reload = new FontAwesome.Sharp.IconButton();
            this.cMSXoa_TaiKhoan.SuspendLayout();
            this.tabQLTK.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableCha.SuspendLayout();
            this.gBDSDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.gBTTTaiKhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iBtnTaiKhoan_Reload
            // 
            iBtnTaiKhoan_Reload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            iBtnTaiKhoan_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iBtnTaiKhoan_Reload.ForeColor = System.Drawing.Color.White;
            iBtnTaiKhoan_Reload.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iBtnTaiKhoan_Reload.IconColor = System.Drawing.Color.Black;
            iBtnTaiKhoan_Reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnTaiKhoan_Reload.IconSize = 25;
            iBtnTaiKhoan_Reload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            iBtnTaiKhoan_Reload.Location = new System.Drawing.Point(555, 22);
            iBtnTaiKhoan_Reload.Name = "iBtnTaiKhoan_Reload";
            iBtnTaiKhoan_Reload.Size = new System.Drawing.Size(34, 31);
            iBtnTaiKhoan_Reload.TabIndex = 24;
            iBtnTaiKhoan_Reload.UseVisualStyleBackColor = true;
            iBtnTaiKhoan_Reload.Click += new System.EventHandler(this.iBtnTaiKhoan_Reload_Click);
            // 
            // cMSXoa_TaiKhoan
            // 
            this.cMSXoa_TaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.cMSXoa_TaiKhoan.Name = "contextMenuStrip1";
            this.cMSXoa_TaiKhoan.Size = new System.Drawing.Size(181, 48);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // tabQLTK
            // 
            this.tabQLTK.Controls.Add(this.tabPage1);
            this.tabQLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLTK.ItemSize = new System.Drawing.Size(150, 50);
            this.tabQLTK.Location = new System.Drawing.Point(0, 0);
            this.tabQLTK.Name = "tabQLTK";
            this.tabQLTK.SelectedIndex = 0;
            this.tabQLTK.Size = new System.Drawing.Size(1287, 841);
            this.tabQLTK.TabIndex = 3;
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
            this.tabPage1.Size = new System.Drawing.Size(1279, 783);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài khoản";
            // 
            // tableCha
            // 
            this.tableCha.ColumnCount = 2;
            this.tableCha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCha.Controls.Add(this.gBDSDocGia, 0, 1);
            this.tableCha.Controls.Add(this.gBTTTaiKhoan, 0, 2);
            this.tableCha.Controls.Add(this.panel1, 0, 0);
            this.tableCha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCha.Location = new System.Drawing.Point(0, 0);
            this.tableCha.Name = "tableCha";
            this.tableCha.RowCount = 3;
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableCha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCha.Size = new System.Drawing.Size(1279, 783);
            this.tableCha.TabIndex = 3;
            // 
            // gBDSDocGia
            // 
            this.gBDSDocGia.BackColor = System.Drawing.Color.White;
            this.tableCha.SetColumnSpan(this.gBDSDocGia, 2);
            this.gBDSDocGia.Controls.Add(this.dgvTaiKhoan);
            this.gBDSDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBDSDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDSDocGia.ForeColor = System.Drawing.Color.Black;
            this.gBDSDocGia.Location = new System.Drawing.Point(3, 83);
            this.gBDSDocGia.Name = "gBDSDocGia";
            this.gBDSDocGia.Size = new System.Drawing.Size(1273, 394);
            this.gBDSDocGia.TabIndex = 3;
            this.gBDSDocGia.TabStop = false;
            this.gBDSDocGia.Text = "Danh sách tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MaTaiKhoan,
            this.TenTaiKhoan,
            this.TenDangNhap,
            this.MatKhau,
            this.HoTenNhanVien,
            this.LoaiTaiKhoan});
            this.dgvTaiKhoan.ContextMenuStrip = this.cMSXoa_TaiKhoan;
            this.dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 34);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1267, 357);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            this.dgvTaiKhoan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTaiKhoan_MouseDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 36.00733F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.FillWeight = 74.81524F;
            this.MaTaiKhoan.HeaderText = "Mã tài khoản";
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.FillWeight = 161.6635F;
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.FillWeight = 74.81524F;
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.FillWeight = 74.81524F;
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // HoTenNhanVien
            // 
            this.HoTenNhanVien.DataPropertyName = "HoTenNhanVien";
            this.HoTenNhanVien.FillWeight = 74.81524F;
            this.HoTenNhanVien.HeaderText = "Họ tên nhân viên";
            this.HoTenNhanVien.Name = "HoTenNhanVien";
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "TenLoaiTaiKhoan";
            this.LoaiTaiKhoan.FillWeight = 74.81524F;
            this.LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            // 
            // gBTTTaiKhoan
            // 
            this.gBTTTaiKhoan.BackColor = System.Drawing.Color.White;
            this.tableCha.SetColumnSpan(this.gBTTTaiKhoan, 2);
            this.gBTTTaiKhoan.Controls.Add(this.cBLoaiTaiKhoan);
            this.gBTTTaiKhoan.Controls.Add(this.tbHoTenNhanVien);
            this.gBTTTaiKhoan.Controls.Add(this.tbTenTaiKhoan);
            this.gBTTTaiKhoan.Controls.Add(this.tbTenDangNhap);
            this.gBTTTaiKhoan.Controls.Add(this.tbMatKhau);
            this.gBTTTaiKhoan.Controls.Add(this.label12);
            this.gBTTTaiKhoan.Controls.Add(this.label1);
            this.gBTTTaiKhoan.Controls.Add(this.iBtnUpdate_TaiKhoan);
            this.gBTTTaiKhoan.Controls.Add(this.iBtnAdd_TaiKhoan);
            this.gBTTTaiKhoan.Controls.Add(this.tbMaTaiKhoan);
            this.gBTTTaiKhoan.Controls.Add(this.label4);
            this.gBTTTaiKhoan.Controls.Add(this.label5);
            this.gBTTTaiKhoan.Controls.Add(this.label6);
            this.gBTTTaiKhoan.Controls.Add(this.label7);
            this.gBTTTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBTTTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBTTTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.gBTTTaiKhoan.Location = new System.Drawing.Point(3, 483);
            this.gBTTTaiKhoan.Name = "gBTTTaiKhoan";
            this.gBTTTaiKhoan.Size = new System.Drawing.Size(1273, 394);
            this.gBTTTaiKhoan.TabIndex = 1;
            this.gBTTTaiKhoan.TabStop = false;
            this.gBTTTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // cBLoaiTaiKhoan
            // 
            this.cBLoaiTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBLoaiTaiKhoan.DisplayMember = "TenLoaiTaiKhoan";
            this.cBLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBLoaiTaiKhoan.FormattingEnabled = true;
            this.cBLoaiTaiKhoan.Location = new System.Drawing.Point(911, 148);
            this.cBLoaiTaiKhoan.Name = "cBLoaiTaiKhoan";
            this.cBLoaiTaiKhoan.Size = new System.Drawing.Size(269, 33);
            this.cBLoaiTaiKhoan.TabIndex = 37;
            this.cBLoaiTaiKhoan.ValueMember = "id";
            // 
            // tbHoTenNhanVien
            // 
            this.tbHoTenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHoTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTenNhanVien.Location = new System.Drawing.Point(911, 97);
            this.tbHoTenNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.tbHoTenNhanVien.Name = "tbHoTenNhanVien";
            this.tbHoTenNhanVien.Size = new System.Drawing.Size(269, 31);
            this.tbHoTenNhanVien.TabIndex = 34;
            // 
            // tbTenTaiKhoan
            // 
            this.tbTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTaiKhoan.Location = new System.Drawing.Point(320, 102);
            this.tbTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenTaiKhoan.Name = "tbTenTaiKhoan";
            this.tbTenTaiKhoan.Size = new System.Drawing.Size(269, 31);
            this.tbTenTaiKhoan.TabIndex = 29;
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDangNhap.Location = new System.Drawing.Point(320, 155);
            this.tbTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.Size = new System.Drawing.Size(269, 31);
            this.tbTenDangNhap.TabIndex = 28;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(911, 46);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(269, 31);
            this.tbMatKhau.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(139, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Họ tên nhân viên";
            // 
            // iBtnUpdate_TaiKhoan
            // 
            this.iBtnUpdate_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iBtnUpdate_TaiKhoan.BackColor = System.Drawing.Color.White;
            this.iBtnUpdate_TaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnUpdate_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdate_TaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.iBtnUpdate_TaiKhoan.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iBtnUpdate_TaiKhoan.IconColor = System.Drawing.Color.Black;
            this.iBtnUpdate_TaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdate_TaiKhoan.IconSize = 28;
            this.iBtnUpdate_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnUpdate_TaiKhoan.Location = new System.Drawing.Point(656, 236);
            this.iBtnUpdate_TaiKhoan.Name = "iBtnUpdate_TaiKhoan";
            this.iBtnUpdate_TaiKhoan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iBtnUpdate_TaiKhoan.Size = new System.Drawing.Size(154, 41);
            this.iBtnUpdate_TaiKhoan.TabIndex = 25;
            this.iBtnUpdate_TaiKhoan.Text = "Cập nhật";
            this.iBtnUpdate_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnUpdate_TaiKhoan.UseVisualStyleBackColor = false;
            this.iBtnUpdate_TaiKhoan.Click += new System.EventHandler(this.iBtnUpdate_TaiKhoan_Click);
            // 
            // iBtnAdd_TaiKhoan
            // 
            this.iBtnAdd_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iBtnAdd_TaiKhoan.BackColor = System.Drawing.Color.White;
            this.iBtnAdd_TaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnAdd_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAdd_TaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.iBtnAdd_TaiKhoan.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iBtnAdd_TaiKhoan.IconColor = System.Drawing.Color.Black;
            this.iBtnAdd_TaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdd_TaiKhoan.IconSize = 28;
            this.iBtnAdd_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdd_TaiKhoan.Location = new System.Drawing.Point(494, 236);
            this.iBtnAdd_TaiKhoan.Name = "iBtnAdd_TaiKhoan";
            this.iBtnAdd_TaiKhoan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iBtnAdd_TaiKhoan.Size = new System.Drawing.Size(139, 41);
            this.iBtnAdd_TaiKhoan.TabIndex = 23;
            this.iBtnAdd_TaiKhoan.Text = "Thêm";
            this.iBtnAdd_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAdd_TaiKhoan.UseVisualStyleBackColor = false;
            this.iBtnAdd_TaiKhoan.Click += new System.EventHandler(this.iBtnAdd_TaiKhoan_Click);
            // 
            // tbMaTaiKhoan
            // 
            this.tbMaTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTaiKhoan.Location = new System.Drawing.Point(320, 46);
            this.tbMaTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaTaiKhoan.Name = "tbMaTaiKhoan";
            this.tbMaTaiKhoan.ReadOnly = true;
            this.tbMaTaiKhoan.Size = new System.Drawing.Size(269, 31);
            this.tbMaTaiKhoan.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(718, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại tài khoản";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên đăng nhập";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên tài khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iBtnTaiKhoan_Reload);
            this.panel1.Controls.Add(this.tbSearch_TaiKhoan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 74);
            this.panel1.TabIndex = 4;
            // 
            // tbSearch_TaiKhoan
            // 
            this.tbSearch_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch_TaiKhoan.Location = new System.Drawing.Point(160, 22);
            this.tbSearch_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch_TaiKhoan.Name = "tbSearch_TaiKhoan";
            this.tbSearch_TaiKhoan.Size = new System.Drawing.Size(376, 31);
            this.tbSearch_TaiKhoan.TabIndex = 21;
            this.tbSearch_TaiKhoan.TextChanged += new System.EventHandler(this.tbSearch_TaiKhoan_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tìm kiếm";
            // 
            // FormQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 841);
            this.Controls.Add(this.tabQLTK);
            this.Name = "FormQLTK";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.FormQLTK_Load);
            this.cMSXoa_TaiKhoan.ResumeLayout(false);
            this.tabQLTK.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableCha.ResumeLayout(false);
            this.gBDSDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.gBTTTaiKhoan.ResumeLayout(false);
            this.gBTTTaiKhoan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cMSXoa_TaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabQLTK;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableCha;
        private System.Windows.Forms.GroupBox gBDSDocGia;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.GroupBox gBTTTaiKhoan;
        private System.Windows.Forms.TextBox tbHoTenNhanVien;
        private System.Windows.Forms.TextBox tbTenTaiKhoan;
        private System.Windows.Forms.TextBox tbTenDangNhap;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iBtnUpdate_TaiKhoan;
        private FontAwesome.Sharp.IconButton iBtnAdd_TaiKhoan;
        private System.Windows.Forms.TextBox tbMaTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSearch_TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.ComboBox cBLoaiTaiKhoan;
        private System.Windows.Forms.Panel panel1;
    }
}