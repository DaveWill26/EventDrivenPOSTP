using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            confirmation();
        }

        public void confirmation()
        {

            string id = txtAdminID.Text;
            string password = txtPassword.Text;

            string correctID = "2000223150";
            string correctPassword = "jiBs1989";

            if (id == correctID && password == correctPassword)
            {
                
                JibsAdmin jibAdmin = new JibsAdmin();
                jibAdmin.ShowDialog();
                
                this.Close();
                
            }

            else { MessageBox.Show("Incorrect ID or Password"); }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
