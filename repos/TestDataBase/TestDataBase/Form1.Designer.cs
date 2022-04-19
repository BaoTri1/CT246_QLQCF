namespace TestDataBase
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cAFEDataSet = new TestDataBase.CAFEDataSet();
            this.cAFEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAFEDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new TestDataBase.CAFEDataSetTableAdapters.NhanVienTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // cAFEDataSet
            // 
            this.cAFEDataSet.DataSetName = "CAFEDataSet";
            this.cAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAFEDataSetBindingSource
            // 
            this.cAFEDataSetBindingSource.DataSource = this.cAFEDataSet;
            this.cAFEDataSetBindingSource.Position = 0;
            // 
            // cAFEDataSetBindingSource1
            // 
            this.cAFEDataSetBindingSource1.DataSource = this.cAFEDataSet;
            this.cAFEDataSetBindingSource1.Position = 0;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.cAFEDataSetBindingSource1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 647);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAFEDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cAFEDataSetBindingSource;
        private CAFEDataSet cAFEDataSet;
        private System.Windows.Forms.BindingSource cAFEDataSetBindingSource1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private CAFEDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
    }
}