namespace Project1
{
    partial class UserControl_NgLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_NgLieu));
            this.panelContain = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuaKho = new System.Windows.Forms.Button();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.DGV_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.Column_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgayNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panelContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.Color.Transparent;
            this.panelContain.Controls.Add(this.btnXem);
            this.panelContain.Controls.Add(this.btnCapNhat);
            this.panelContain.Controls.Add(this.btnXuaKho);
            this.panelContain.Controls.Add(this.btnNhapKho);
            this.panelContain.Controls.Add(this.DGV_NguyenLieu);
            this.panelContain.Controls.Add(this.lbl_Title);
            this.panelContain.Location = new System.Drawing.Point(3, 3);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1166, 905);
            this.panelContain.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(716, 648);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(200, 50);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem Danh Sách";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Snow;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(716, 737);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 50);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXuaKho
            // 
            this.btnXuaKho.BackColor = System.Drawing.Color.Snow;
            this.btnXuaKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuaKho.Location = new System.Drawing.Point(185, 737);
            this.btnXuaKho.Name = "btnXuaKho";
            this.btnXuaKho.Size = new System.Drawing.Size(200, 50);
            this.btnXuaKho.TabIndex = 3;
            this.btnXuaKho.Text = "Xuất Kho";
            this.btnXuaKho.UseVisualStyleBackColor = false;
            this.btnXuaKho.Click += new System.EventHandler(this.btnXuaKho_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.Snow;
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.Location = new System.Drawing.Point(185, 648);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(200, 50);
            this.btnNhapKho.TabIndex = 2;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // DGV_NguyenLieu
            // 
            this.DGV_NguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_NguyenLieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_NguyenLieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_NguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_NguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Ten,
            this.Column_Loai,
            this.Column_SoLuong,
            this.Column_NgayNK});
            this.DGV_NguyenLieu.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_NguyenLieu.Location = new System.Drawing.Point(99, 123);
            this.DGV_NguyenLieu.Name = "DGV_NguyenLieu";
            this.DGV_NguyenLieu.RowHeadersWidth = 51;
            this.DGV_NguyenLieu.RowTemplate.Height = 24;
            this.DGV_NguyenLieu.Size = new System.Drawing.Size(954, 500);
            this.DGV_NguyenLieu.TabIndex = 1;
            // 
            // Column_Ten
            // 
            this.Column_Ten.HeaderText = "Tên Vật Phẩm";
            this.Column_Ten.MinimumWidth = 6;
            this.Column_Ten.Name = "Column_Ten";
            this.Column_Ten.ReadOnly = true;
            // 
            // Column_Loai
            // 
            this.Column_Loai.HeaderText = "Phân Loại";
            this.Column_Loai.MinimumWidth = 6;
            this.Column_Loai.Name = "Column_Loai";
            this.Column_Loai.ReadOnly = true;
            // 
            // Column_SoLuong
            // 
            this.Column_SoLuong.HeaderText = "Số Lượng";
            this.Column_SoLuong.MinimumWidth = 6;
            this.Column_SoLuong.Name = "Column_SoLuong";
            this.Column_SoLuong.ReadOnly = true;
            // 
            // Column_NgayNK
            // 
            this.Column_NgayNK.HeaderText = "Ngày Nhập Kho";
            this.Column_NgayNK.MinimumWidth = 6;
            this.Column_NgayNK.Name = "Column_NgayNK";
            this.Column_NgayNK.ReadOnly = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(441, 26);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(240, 42);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Nguyên Liệu";
            // 
            // UserControl_NgLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelContain);
            this.Name = "UserControl_NgLieu";
            this.Size = new System.Drawing.Size(1166, 905);
            this.Load += new System.EventHandler(this.UserControl_NgLieu_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.DataGridView DGV_NguyenLieu;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayNK;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXuaKho;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Button btnXem;
    }
}
