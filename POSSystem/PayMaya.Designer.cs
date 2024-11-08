namespace POSSystem
{
    partial class PayMaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayMaya));
            this.btnDone3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone3
            // 
            this.btnDone3.BackColor = System.Drawing.Color.Lime;
            this.btnDone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone3.ForeColor = System.Drawing.Color.White;
            this.btnDone3.Location = new System.Drawing.Point(121, 317);
            this.btnDone3.Name = "btnDone3";
            this.btnDone3.Size = new System.Drawing.Size(165, 52);
            this.btnDone3.TabIndex = 2;
            this.btnDone3.Text = "Done";
            this.btnDone3.UseVisualStyleBackColor = false;
            this.btnDone3.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // PayMaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.btnDone3);
            this.DoubleBuffered = true;
            this.Name = "PayMaya";
            this.Text = "PayMaya";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone3;
    }
}