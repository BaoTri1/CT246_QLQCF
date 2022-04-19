namespace Project1
{
    partial class NhapKho_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapKho_Form));
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.DTPNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTenVP = new System.Windows.Forms.Label();
            this.grBCV = new System.Windows.Forms.GroupBox();
            this.rbtnXK = new System.Windows.Forms.RadioButton();
            this.rbtnNK = new System.Windows.Forms.RadioButton();
            this.txtTenVP = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grBCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.BackColor = System.Drawing.Color.Transparent;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(65, 131);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(156, 25);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã Nhân Viên:";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(261, 128);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(295, 30);
            this.txtMa.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(65, 214);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(164, 25);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên Nhân Viên:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(261, 209);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(411, 30);
            this.txtTen.TabIndex = 4;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(65, 294);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(174, 25);
            this.lblNgay.TabIndex = 5;
            this.lblNgay.Text = "Ngày Thực Hiện:";
            // 
            // DTPNgay
            // 
            this.DTPNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNgay.Location = new System.Drawing.Point(261, 289);
            this.DTPNgay.Name = "DTPNgay";
            this.DTPNgay.Size = new System.Drawing.Size(411, 30);
            this.DTPNgay.TabIndex = 6;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(339, 748);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(169, 45);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Window;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(596, 748);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 45);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(299, 34);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(285, 42);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Xuất/Nhập Kho";
            // 
            // lblTenVP
            // 
            this.lblTenVP.AutoSize = true;
            this.lblTenVP.BackColor = System.Drawing.Color.Transparent;
            this.lblTenVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenVP.Location = new System.Drawing.Point(65, 552);
            this.lblTenVP.Name = "lblTenVP";
            this.lblTenVP.Size = new System.Drawing.Size(157, 25);
            this.lblTenVP.TabIndex = 14;
            this.lblTenVP.Text = "Tên Vật Phẩm:";
            // 
            // grBCV
            // 
            this.grBCV.BackColor = System.Drawing.Color.White;
            this.grBCV.Controls.Add(this.rbtnNK);
            this.grBCV.Controls.Add(this.rbtnXK);
            this.grBCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBCV.Location = new System.Drawing.Point(184, 385);
            this.grBCV.Name = "grBCV";
            this.grBCV.Size = new System.Drawing.Size(517, 119);
            this.grBCV.TabIndex = 15;
            this.grBCV.TabStop = false;
            this.grBCV.Text = "Công Việc:";
            // 
            // rbtnXK
            // 
            this.rbtnXK.AutoSize = true;
            this.rbtnXK.Checked = true;
            this.rbtnXK.Location = new System.Drawing.Point(77, 57);
            this.rbtnXK.Name = "rbtnXK";
            this.rbtnXK.Size = new System.Drawing.Size(115, 29);
            this.rbtnXK.TabIndex = 0;
            this.rbtnXK.TabStop = true;
            this.rbtnXK.Text = "Xuất Kho";
            this.rbtnXK.UseVisualStyleBackColor = true;
            // 
            // rbtnNK
            // 
            this.rbtnNK.AutoSize = true;
            this.rbtnNK.Location = new System.Drawing.Point(324, 57);
            this.rbtnNK.Name = "rbtnNK";
            this.rbtnNK.Size = new System.Drawing.Size(121, 29);
            this.rbtnNK.TabIndex = 1;
            this.rbtnNK.TabStop = true;
            this.rbtnNK.Text = "Nhập Kho";
            this.rbtnNK.UseVisualStyleBackColor = true;
            // 
            // txtTenVP
            // 
            this.txtTenVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVP.Location = new System.Drawing.Point(261, 547);
            this.txtTenVP.Name = "txtTenVP";
            this.txtTenVP.Size = new System.Drawing.Size(368, 30);
            this.txtTenVP.TabIndex = 16;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(65, 643);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(112, 25);
            this.lblSoLuong.TabIndex = 17;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(261, 638);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(157, 30);
            this.txtSoLuong.TabIndex = 18;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(83, 748);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(169, 45);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // NhapKho_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 866);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtTenVP);
            this.Controls.Add(this.grBCV);
            this.Controls.Add(this.lblTenVP);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.DTPNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NhapKho_Form";
            this.Text = "NhapKho_Form";
            this.grBCV.ResumeLayout(false);
            this.grBCV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker DTPNgay;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTenVP;
        private System.Windows.Forms.GroupBox grBCV;
        private System.Windows.Forms.RadioButton rbtnNK;
        private System.Windows.Forms.RadioButton rbtnXK;
        private System.Windows.Forms.TextBox txtTenVP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnLamMoi;
    }
}