namespace Project1
{
    partial class UserControl_DCDTP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_DCDTP));
            this.panelContain = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.DGV_DCDTP = new System.Windows.Forms.DataGridView();
            this.ColumnTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DCDTP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.Color.Transparent;
            this.panelContain.Controls.Add(this.btnCapNhat);
            this.panelContain.Controls.Add(this.btnXuatKho);
            this.panelContain.Controls.Add(this.btnNhapKho);
            this.panelContain.Controls.Add(this.DGV_DCDTP);
            this.panelContain.Controls.Add(this.lblTitle);
            this.panelContain.Location = new System.Drawing.Point(0, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1166, 851);
            this.panelContain.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.Window;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(764, 733);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 50);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Visible = false;
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.BackColor = System.Drawing.SystemColors.Window;
            this.btnXuatKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKho.Location = new System.Drawing.Point(166, 733);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(200, 50);
            this.btnXuatKho.TabIndex = 3;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.UseVisualStyleBackColor = false;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.SystemColors.Window;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.Location = new System.Drawing.Point(166, 637);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(200, 50);
            this.btnNhapKho.TabIndex = 2;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            // 
            // DGV_DCDTP
            // 
            this.DGV_DCDTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DCDTP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_DCDTP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_DCDTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DCDTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTen,
            this.ColumnLoai,
            this.ColumnSize,
            this.ColumnSoLuong,
            this.ColumnNgayNK});
            this.DGV_DCDTP.Location = new System.Drawing.Point(76, 114);
            this.DGV_DCDTP.Name = "DGV_DCDTP";
            this.DGV_DCDTP.RowHeadersWidth = 51;
            this.DGV_DCDTP.RowTemplate.Height = 24;
            this.DGV_DCDTP.Size = new System.Drawing.Size(1006, 500);
            this.DGV_DCDTP.TabIndex = 1;
            // 
            // ColumnTen
            // 
            this.ColumnTen.HeaderText = "Tên Vật Phẩm";
            this.ColumnTen.MinimumWidth = 6;
            this.ColumnTen.Name = "ColumnTen";
            this.ColumnTen.ReadOnly = true;
            // 
            // ColumnLoai
            // 
            this.ColumnLoai.HeaderText = "Phân Loại";
            this.ColumnLoai.MinimumWidth = 6;
            this.ColumnLoai.Name = "ColumnLoai";
            this.ColumnLoai.ReadOnly = true;
            // 
            // ColumnSize
            // 
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.MinimumWidth = 6;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.ReadOnly = true;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.ReadOnly = true;
            // 
            // ColumnNgayNK
            // 
            this.ColumnNgayNK.HeaderText = "Ngày Nhập Kho";
            this.ColumnNgayNK.MinimumWidth = 6;
            this.ColumnNgayNK.Name = "ColumnNgayNK";
            this.ColumnNgayNK.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(330, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(513, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dụng Cụ Đựng Thành Phẩm";
            // 
            // UserControl_DCDTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelContain);
            this.Name = "UserControl_DCDTP";
            this.Size = new System.Drawing.Size(1166, 851);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DCDTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.DataGridView DGV_DCDTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayNK;
        private System.Windows.Forms.Label lblTitle;
    }
}
