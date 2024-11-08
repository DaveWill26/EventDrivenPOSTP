namespace POSSystem
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.btnConfirm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel3
            // 
            this.btnCancel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel3.Location = new System.Drawing.Point(80, 152);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(101, 33);
            this.btnCancel3.TabIndex = 0;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // btnConfirm3
            // 
            this.btnConfirm3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm3.Location = new System.Drawing.Point(203, 152);
            this.btnConfirm3.Name = "btnConfirm3";
            this.btnConfirm3.Size = new System.Drawing.Size(101, 33);
            this.btnConfirm3.TabIndex = 1;
            this.btnConfirm3.Text = "Confirm";
            this.btnConfirm3.UseVisualStyleBackColor = true;
            this.btnConfirm3.Click += new System.EventHandler(this.btnConfirm3_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 217);
            this.Controls.Add(this.btnConfirm3);
            this.Controls.Add(this.btnCancel3);
            this.DoubleBuffered = true;
            this.Name = "Logout";
            this.Text = "Logout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button btnConfirm3;
    }
}