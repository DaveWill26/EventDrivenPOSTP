using System;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {  this.Close();    }

        private void btnConfirm3_Click(object sender, EventArgs e)
        {  Application.Exit(); }
    }
}
