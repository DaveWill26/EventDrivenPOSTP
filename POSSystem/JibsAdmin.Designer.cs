namespace POSSystem
{
    partial class JibsAdmin
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panelAdmin.BackgroundImage = global::POSSystem.Properties.Resources.Admin;
            this.panelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdmin.Controls.Add(this.btnCustomer);
            this.panelAdmin.Controls.Add(this.btnInventory);
            this.panelAdmin.Controls.Add(this.btnSales);
            this.panelAdmin.Controls.Add(this.AdminLabel);
            this.panelAdmin.Location = new System.Drawing.Point(1, 1);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1337, 882);
            this.panelAdmin.TabIndex = 67;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = global::POSSystem.Properties.Resources.customer_page__1_;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Location = new System.Drawing.Point(981, 214);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(282, 126);
            this.btnCustomer.TabIndex = 64;
            this.btnCustomer.Text = "button3";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.BackgroundImage = global::POSSystem.Properties.Resources.inventory_page__1_;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.ForeColor = System.Drawing.Color.Transparent;
            this.btnInventory.Location = new System.Drawing.Point(693, 214);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(282, 126);
            this.btnInventory.TabIndex = 63;
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.BackgroundImage = global::POSSystem.Properties.Resources.sales_page__1_;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.Color.Transparent;
            this.btnSales.Location = new System.Drawing.Point(405, 214);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(282, 126);
            this.btnSales.TabIndex = 62;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.White;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(379, 156);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(261, 25);
            this.AdminLabel.TabIndex = 61;
            this.AdminLabel.Text = "Welcome, Gabriel Salazar";
            // 
            // JibsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 792);
            this.Controls.Add(this.panelAdmin);
            this.DoubleBuffered = true;
            this.Name = "JibsAdmin";
            this.Text = "JibsAdmin";
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label AdminLabel;
    }
}