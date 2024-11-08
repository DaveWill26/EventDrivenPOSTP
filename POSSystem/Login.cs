using System;
using System.Drawing;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccountId.Text == "EventDriven101")
            {              
                POS POS = new POS();

                POS.Show();
              
                this.Hide(); 
            }
            else
            {               
                MessageBox.Show("Invalid Account ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
