namespace POSSystem
{
    partial class GCashQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCashQRCode));
            this.btnDone1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone1
            // 
            this.btnDone1.BackColor = System.Drawing.Color.Lime;
            this.btnDone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone1.ForeColor = System.Drawing.Color.White;
            this.btnDone1.Location = new System.Drawing.Point(130, 347);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(169, 52);
            this.btnDone1.TabIndex = 0;
            this.btnDone1.Text = "Done";
            this.btnDone1.UseVisualStyleBackColor = false;
            this.btnDone1.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // GCashQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 420);
            this.Controls.Add(this.btnDone1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GCashQRCode";
            this.Text = "GCashQRCode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone1;
    }
}