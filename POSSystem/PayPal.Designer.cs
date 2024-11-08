namespace POSSystem
{
    partial class PayPal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPal));
            this.btnDone2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone2
            // 
            this.btnDone2.BackColor = System.Drawing.Color.Lime;
            this.btnDone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone2.ForeColor = System.Drawing.Color.White;
            this.btnDone2.Location = new System.Drawing.Point(131, 346);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(165, 52);
            this.btnDone2.TabIndex = 1;
            this.btnDone2.Text = "Done";
            this.btnDone2.UseVisualStyleBackColor = false;
            this.btnDone2.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // PayPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 420);
            this.Controls.Add(this.btnDone2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayPal";
            this.Text = "PayPal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone2;
    }
}