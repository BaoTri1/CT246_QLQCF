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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl_ThanhToan1 = new Project1.UserControl_ThanhToan();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTToolStripMenuItem,
            this.HDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1561, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TTToolStripMenuItem
            // 
            this.TTToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.TTToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTToolStripMenuItem.Name = "TTToolStripMenuItem";
            this.TTToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.TTToolStripMenuItem.Text = "Thanh Toán";
            this.TTToolStripMenuItem.Click += new System.EventHandler(this.TTToolStripMenuItem_Click);
            // 
            // HDToolStripMenuItem
            // 
            this.HDToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.HDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchHóaĐơnToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.HDToolStripMenuItem.Name = "HDToolStripMenuItem";
            this.HDToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.HDToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // danhSáchHóaĐơnToolStripMenuItem
            // 
            this.danhSáchHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchHóaĐơnToolStripMenuItem.Name = "danhSáchHóaĐơnToolStripMenuItem";
            this.danhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.danhSáchHóaĐơnToolStripMenuItem.Text = "Chi Tiết Hóa Đơn";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl_ThanhToan1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 848);
            this.panel1.TabIndex = 2;
            // 
            // userControl_ThanhToan1
            // 
            this.userControl_ThanhToan1.Location = new System.Drawing.Point(0, 1);
            this.userControl_ThanhToan1.Name = "userControl_ThanhToan1";
            this.userControl_ThanhToan1.Size = new System.Drawing.Size(1561, 848);
            this.userControl_ThanhToan1.TabIndex = 0;
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1561, 877);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_HoaDon";
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private UserControl_ThanhToan userControl_ThanhToan1;
    }
}