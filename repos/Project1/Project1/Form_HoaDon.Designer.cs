namespace Project1
{
    partial class Form_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HoaDon));
            this.panelContain = new System.Windows.Forms.Panel();
            this.userControl_ThanhToan1 = new Project1.UserControl_ThanhToan();
            this.panelContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.Controls.Add(this.userControl_ThanhToan1);
            this.panelContain.Location = new System.Drawing.Point(-5, 1);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1950, 1032);
            this.panelContain.TabIndex = 1;
            // 
            // userControl_ThanhToan1
            // 
            this.userControl_ThanhToan1.Location = new System.Drawing.Point(0, 3);
            this.userControl_ThanhToan1.Name = "userControl_ThanhToan1";
            this.userControl_ThanhToan1.Size = new System.Drawing.Size(1942, 1102);
            this.userControl_ThanhToan1.TabIndex = 0;
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.panelContain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_HoaDon";
            this.Text = "Thanh Toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelContain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContain;
        private UserControl_ThanhToan userControl_ThanhToan1;
    }
}