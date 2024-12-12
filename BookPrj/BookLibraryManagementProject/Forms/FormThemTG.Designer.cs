namespace BookLibraryManagementProject.Forms
{
    partial class FormThemTG
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
            this.label1 = new System.Windows.Forms.Label();
            this.iBtnAddTG = new FontAwesome.Sharp.IconButton();
            this.tbTenTacGia = new System.Windows.Forms.TextBox();
            this.tbMaTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thêm tác giả";
            // 
            // iBtnAddTG
            // 
            this.iBtnAddTG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iBtnAddTG.BackColor = System.Drawing.Color.White;
            this.iBtnAddTG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iBtnAddTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAddTG.ForeColor = System.Drawing.Color.Black;
            this.iBtnAddTG.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iBtnAddTG.IconColor = System.Drawing.Color.Black;
            this.iBtnAddTG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAddTG.IconSize = 28;
            this.iBtnAddTG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAddTG.Location = new System.Drawing.Point(187, 328);
            this.iBtnAddTG.Name = "iBtnAddTG";
            this.iBtnAddTG.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iBtnAddTG.Size = new System.Drawing.Size(139, 41);
            this.iBtnAddTG.TabIndex = 35;
            this.iBtnAddTG.Text = "Thêm";
            this.iBtnAddTG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnAddTG.UseVisualStyleBackColor = false;
            this.iBtnAddTG.Click += new System.EventHandler(this.iBtnAddTG_Click);
            // 
            // tbTenTacGia
            // 
            this.tbTenTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTacGia.Location = new System.Drawing.Point(206, 244);
            this.tbTenTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenTacGia.Name = "tbTenTacGia";
            this.tbTenTacGia.Size = new System.Drawing.Size(185, 31);
            this.tbTenTacGia.TabIndex = 34;
            // 
            // tbMaTacGia
            // 
            this.tbMaTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaTacGia.Enabled = false;
            this.tbMaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTacGia.Location = new System.Drawing.Point(206, 164);
            this.tbMaTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaTacGia.Name = "tbMaTacGia";
            this.tbMaTacGia.ReadOnly = true;
            this.tbMaTacGia.Size = new System.Drawing.Size(185, 31);
            this.tbMaTacGia.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên tác giả";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 26);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mã tác giả";
            // 
            // FormThemTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iBtnAddTG);
            this.Controls.Add(this.tbTenTacGia);
            this.Controls.Add(this.tbMaTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "FormThemTG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemTG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iBtnAddTG;
        private System.Windows.Forms.TextBox tbTenTacGia;
        private System.Windows.Forms.TextBox tbMaTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}