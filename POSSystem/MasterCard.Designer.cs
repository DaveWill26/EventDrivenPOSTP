namespace POSSystem
{
    partial class MasterCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterCard));
            this.btnDone4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone4
            // 
            this.btnDone4.BackColor = System.Drawing.Color.Lime;
            this.btnDone4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone4.ForeColor = System.Drawing.Color.White;
            this.btnDone4.Location = new System.Drawing.Point(121, 317);
            this.btnDone4.Name = "btnDone4";
            this.btnDone4.Size = new System.Drawing.Size(165, 52);
            this.btnDone4.TabIndex = 3;
            this.btnDone4.Text = "Done";
            this.btnDone4.UseVisualStyleBackColor = false;
            this.btnDone4.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // MasterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.btnDone4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterCard";
            this.Text = "MasterCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone4;
    }
}