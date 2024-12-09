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
    public partial class AdminAuthentication : Form
    {
        private POS posForm;
        public AdminAuthentication(POS posForm)
        {
            InitializeComponent();
            this.posForm = posForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminID.Text == "2000223150" && txtPassword.Text == "jiBs1989")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

               
            }
            else
            {
                MessageBox.Show("Invalid Account ID. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }  
}
