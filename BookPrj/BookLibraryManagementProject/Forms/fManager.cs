using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookLibraryManagementProject
{
    public partial class fManager : Form
    {
        //Fields
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;

        public fManager()
        {
            InitializeComponent();
        }

        //Methods

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTK(), sender);
        }

        private void btnQLDG_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLDG(), sender);
        }

        private void btnQLS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLS(), sender);
        }

        private void btnQLPMT_Click(object sender, EventArgs e)
        {
            var form = new Forms.FormQLPMT();
            OpenChildForm(form, sender);
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBCTK(), sender);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLTK(), sender);
        }
        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            if (UserInfo.idLoaiTaiKhoan != 1)
            {
                btnQLS.Enabled = false;
                btnQLDG.Enabled = false;
                btnQLTK.Enabled = false;
                btnBCTK.Enabled = false;
            }
        }
    }
}
