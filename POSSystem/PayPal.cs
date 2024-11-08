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
    public partial class PayPal : Form
    {
        public PayPal()
        {
            InitializeComponent();
        }

        private void btnDone1_Click(object sender, EventArgs e)
        {
            ConfirmationWindow confirmation = new ConfirmationWindow();
            confirmation.Show();
            this.Close();
        }
    }
}
