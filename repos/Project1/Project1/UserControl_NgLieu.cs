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
    public partial class UserControl_NgLieu : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader rd;

        public UserControl_NgLieu()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            DGV_NguyenLieu.ReadOnly = false;
        }

        private void btnXuaKho_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            DGV_NguyenLieu.ReadOnly = false;
        }

        private void UserControl_NgLieu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=MSI\\SQLEXPRESS;Initial Catalog = CAFE;User Id=sa;pwd=123456;");
            cmd = new SqlCommand("Select * From NguyenLieu", conn);
            conn.Open();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                DGV_NguyenLieu.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetDecimal(2).ToString(), rd.GetString(3));

            }
            btnCapNhat.Enabled = false;
        }

    }
}
