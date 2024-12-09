using System;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class ConfirmationWindow : Form
    {
        private POS mainForm;

        public ConfirmationWindow()
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void btnCancelConfirmation_Click(object sender, EventArgs e)
        {            
            mainForm.ClearPanel6(); 
            mainForm.Show();         
            this.Close();
        }
        private void btnConfirmConfirmation_Click(object sender, EventArgs e)
        {
            OrderSuccess orderSuccess = new OrderSuccess();
            orderSuccess.Show();
            this.Close();
        }
    }
}
