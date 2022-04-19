using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class UserControl_DiemDanh : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private String ten;
        private String SDT;

        public UserControl_DiemDanh()
        {
            InitializeComponent();
        }

        private void UserControl_DiemDanh_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = MSI\\SQLEXPRESS; Initial Catalog = CAFE; User Id = sa; pwd = 123456;");
                cmd = new SqlCommand("Select * from NhanVien", conn);
                //              conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select TenNV, SDT from NhanVien where MaNV = '" + txtMaNV.Text + "';", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                ten = rd.GetString(0);
                SDT = rd.GetString(1);
            }
            txtHoTen.Text = ten;
            conn.Close();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            String Ma = txtMaNV.Text;
            String Ten = txtHoTen.Text;
            String CaLV = cbo_CaLV.Text;
            String NgayLV = DTP_Ngaylamviec.Text;

            DGV_BangCLV.Rows.Add(Ma, Ten, SDT, CaLV, NgayLV);

            resetFiled();
        }

        private void resetFiled()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cbo_CaLV.Text = "";
            SDT = null;
            txtMaNV.Focus();
        }

        private void ChinhSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DGV_BangCLV.Rows[e.RowIndex];

            String ma = Convert.ToString(row.Cells[0].Value);
            String calv = Convert.ToString(row.Cells[3].Value);
            String ngay = Convert.ToString(row.Cells[4].Value);

            txtMaNV.Text = ma;
            cbo_CaLV.Text = calv;
            DTP_Ngaylamviec.Text = ngay;

            DGV_BangCLV.Rows.RemoveAt(DGV_BangCLV.CurrentRow.Index);
            
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            
        }
    }
}
