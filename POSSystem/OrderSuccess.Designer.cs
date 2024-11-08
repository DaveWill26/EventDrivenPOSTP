namespace POSSystem
{
    partial class OrderSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSuccess));
            this.btnCloseOrderSuccess = new System.Windows.Forms.Button();
            this.btnConfirmOrderSuccess = new System.Windows.Forms.Button();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseOrderSuccess
            // 
            this.btnCloseOrderSuccess.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCloseOrderSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOrderSuccess.ForeColor = System.Drawing.Color.White;
            this.btnCloseOrderSuccess.Location = new System.Drawing.Point(222, 387);
            this.btnCloseOrderSuccess.Name = "btnCloseOrderSuccess";
            this.btnCloseOrderSuccess.Size = new System.Drawing.Size(128, 44);
            this.btnCloseOrderSuccess.TabIndex = 2;
            this.btnCloseOrderSuccess.Text = "Logout";
            this.btnCloseOrderSuccess.UseVisualStyleBackColor = false;
            this.btnCloseOrderSuccess.Click += new System.EventHandler(this.btnCloseOrderSuccess_Click);
            // 
            // btnConfirmOrderSuccess
            // 
            this.btnConfirmOrderSuccess.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmOrderSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrderSuccess.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrderSuccess.Location = new System.Drawing.Point(356, 387);
            this.btnConfirmOrderSuccess.Name = "btnConfirmOrderSuccess";
            this.btnConfirmOrderSuccess.Size = new System.Drawing.Size(128, 44);
            this.btnConfirmOrderSuccess.TabIndex = 3;
            this.btnConfirmOrderSuccess.Text = "Confirm";
            this.btnConfirmOrderSuccess.UseVisualStyleBackColor = false;
            this.btnConfirmOrderSuccess.Click += new System.EventHandler(this.btnConfirmOrderSuccess_Click);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.Location = new System.Drawing.Point(401, 271);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(118, 35);
            this.lblOrderNo.TabIndex = 4;
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.btnConfirmOrderSuccess);
            this.Controls.Add(this.btnCloseOrderSuccess);
            this.DoubleBuffered = true;
            this.Name = "OrderSuccess";
            this.Text = "OrderSuccess";
            this.Load += new System.EventHandler(this.OrderSuccess_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseOrderSuccess;
        private System.Windows.Forms.Button btnConfirmOrderSuccess;
        private System.Windows.Forms.Label lblOrderNo;
    }
}