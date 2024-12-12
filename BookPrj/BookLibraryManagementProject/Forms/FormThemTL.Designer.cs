namespace BookLibraryManagementProject.Forms
{
    partial class FormThemTL
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
            this.iBtnAddTL = new FontAwesome.Sharp.IconButton();
            this.tbTenTheLoai = new System.Windows.Forms.TextBox();
            this.tbMaTheLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iBtnAddTL
            // 
            this.iBtnAddTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iBtnAddTL.BackColor = System.Drawing.Color.White;
            this.iBtnAddTL.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnAddTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAddTL.ForeColor = System.Drawing.Color.Black;
            this.iBtnAddTL.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iBtnAddTL.IconColor = System.Drawing.Color.Black;
            this.iBtnAddTL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddTL.IconSize = 28;
            this.iBtnAddTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddTL.Location = new System.Drawing.Point(184, 329);
            this.iBtnAddTL.Name = "iBtnAddTL";
            this.iBtnAddTL.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iBtnAddTL.Size = new System.Drawing.Size(139, 41);
            this.iBtnAddTL.TabIndex = 29;
            this.iBtnAddTL.Text = "Thêm";
            this.iBtnAddTL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddTL.UseVisualStyleBackColor = false;
            this.iBtnAddTL.Click += new System.EventHandler(this.iBtnAddTL_Click);
            // 
            // tbTenTheLoai
            // 
            this.tbTenTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTheLoai.Location = new System.Drawing.Point(203, 245);
            this.tbTenTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenTheLoai.Name = "tbTenTheLoai";
            this.tbTenTheLoai.Size = new System.Drawing.Size(185, 31);
            this.tbTenTheLoai.TabIndex = 28;
            // 
            // tbMaTheLoai
            // 
            this.tbMaTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaTheLoai.Enabled = false;
            this.tbMaTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTheLoai.Location = new System.Drawing.Point(203, 165);
            this.tbMaTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaTheLoai.Name = "tbMaTheLoai";
            this.tbMaTheLoai.ReadOnly = true;
            this.tbMaTheLoai.Size = new System.Drawing.Size(185, 31);
            this.tbMaTheLoai.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên thể loại";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "Thêm thể loại";
            // 
            // FormThemTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iBtnAddTL);
            this.Controls.Add(this.tbTenTheLoai);
            this.Controls.Add(this.tbMaTheLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "FormThemTL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thể loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnAddTL;
        private System.Windows.Forms.TextBox tbTenTheLoai;
        private System.Windows.Forms.TextBox tbMaTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}