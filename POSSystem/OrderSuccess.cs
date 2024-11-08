using System;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class OrderSuccess : Form
    {       
        public OrderSuccess()
            {
                InitializeComponent();              
            }
            private void btnCloseOrderSuccess_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void btnConfirmOrderSuccess_Click(object sender, EventArgs e)
            {
            // Get the current order number from settings
            int currentOrderNumber = Properties.Settings.Default.OrderNumber;
            // Format the order number to 4 digits (e.g., 0001, 0002, etc.)
            string formattedOrderNumber = currentOrderNumber.ToString("D4");
            // Display the order number in lblOrderNo
            lblOrderNo.Text = formattedOrderNumber;
            // Increment the order number for next use
            Properties.Settings.Default.OrderNumber = currentOrderNumber + 1;
            Properties.Settings.Default.Save();  // Save the new order number to settings

            POS mainForm = new POS();           
            mainForm.Show();  // Show the POS form again
            this.Close();  // Close the current form
        }
        private void OrderSuccess_Load(object sender, EventArgs e)
        {
            // Ensure the order number is retrieved when the form loads
            int currentOrderNumber = Properties.Settings.Default.OrderNumber;
            // Format the order number to 4 digits (e.g., 0001, 0002, etc.)
            string formattedOrderNumber = currentOrderNumber.ToString("D4");
            // Display the formatted order number in the lblOrderNo
            lblOrderNo.Text = formattedOrderNumber;
        }

    }   
}
