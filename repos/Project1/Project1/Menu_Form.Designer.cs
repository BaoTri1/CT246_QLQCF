namespace Project1
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuatNhap = new System.Windows.Forms.Button();
            this.btnTongket = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_manage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("VNI-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 167);
            this.button1.TabIndex = 0;
            this.button1.Text = "QuảnLý";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXuatNhap
            // 
            this.btnXuatNhap.BackColor = System.Drawing.SystemColors.Window;
            this.btnXuatNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatNhap.Location = new System.Drawing.Point(510, 111);
            this.btnXuatNhap.Name = "btnXuatNhap";
            this.btnXuatNhap.Size = new System.Drawing.Size(307, 167);
            this.btnXuatNhap.TabIndex = 1;
            this.btnXuatNhap.Text = "Xuất/Nhập Kho";
            this.btnXuatNhap.UseVisualStyleBackColor = false;
            // 
            // btnTongket
            // 
            this.btnTongket.BackColor = System.Drawing.SystemColors.Window;
            this.btnTongket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongket.Location = new System.Drawing.Point(936, 110);
            this.btnTongket.Name = "btnTongket";
            this.btnTongket.Size = new System.Drawing.Size(307, 167);
            this.btnTongket.TabIndex = 2;
            this.btnTongket.Text = "Tổng Kết Kho";
            this.btnTongket.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(84, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(307, 167);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("VNI-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(102, 110);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(289, 167);
            this.button7.TabIndex = 0;
            this.button7.Text = "QuảnLý";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_manage
            // 
            this.btn_manage.BackColor = System.Drawing.SystemColors.Window;
            this.btn_manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.Location = new System.Drawing.Point(84, 110);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(307, 167);
            this.btn_manage.TabIndex = 0;
            this.btn_manage.Text = "Quản lý Kho";
            this.btn_manage.UseVisualStyleBackColor = false;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1335, 739);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTongket);
            this.Controls.Add(this.btnXuatNhap);
            this.Controls.Add(this.btn_manage);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_Form";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXuatNhap;
        private System.Windows.Forms.Button btnTongket;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_manage;
    }
}