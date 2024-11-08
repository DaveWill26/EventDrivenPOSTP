namespace POSSystem
{
    partial class ConfirmationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationWindow));
            this.btnCancelConfirmation = new System.Windows.Forms.Button();
            this.btnConfirmConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelConfirmation
            // 
            this.btnCancelConfirmation.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnCancelConfirmation.Location = new System.Drawing.Point(124, 254);
            this.btnCancelConfirmation.Name = "btnCancelConfirmation";
            this.btnCancelConfirmation.Size = new System.Drawing.Size(153, 56);
            this.btnCancelConfirmation.TabIndex = 0;
            this.btnCancelConfirmation.Text = "Cancel";
            this.btnCancelConfirmation.UseVisualStyleBackColor = false;
            this.btnCancelConfirmation.Click += new System.EventHandler(this.btnCancelConfirmation_Click);
            // 
            // btnConfirmConfirmation
            // 
            this.btnConfirmConfirmation.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmConfirmation.Location = new System.Drawing.Point(310, 254);
            this.btnConfirmConfirmation.Name = "btnConfirmConfirmation";
            this.btnConfirmConfirmation.Size = new System.Drawing.Size(153, 56);
            this.btnConfirmConfirmation.TabIndex = 1;
            this.btnConfirmConfirmation.Text = "Confirm";
            this.btnConfirmConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmConfirmation.Click += new System.EventHandler(this.btnConfirmConfirmation_Click);
            // 
            // ConfirmationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 364);
            this.Controls.Add(this.btnConfirmConfirmation);
            this.Controls.Add(this.btnCancelConfirmation);
            this.DoubleBuffered = true;
            this.Name = "ConfirmationWindow";
            this.Text = "ConfirmationWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelConfirmation;
        private System.Windows.Forms.Button btnConfirmConfirmation;
    }
}