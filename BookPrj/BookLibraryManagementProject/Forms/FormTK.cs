using System;
using System.Windows.Forms;

namespace BookLibraryManagementProject.Forms
{
    public partial class FormTK : Form
    {
        public FormTK()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form f = new FormDoiMK();
            f.ShowDialog();
        }
    }
}
