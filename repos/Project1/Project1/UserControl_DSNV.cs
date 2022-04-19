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
    public partial class UserControl_DSNV : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;

        public UserControl_DSNV()
        {
            InitializeComponent();
        }

        private void UserControl_DSNV_Load(object sender, EventArgs e)
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

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            conn.Open();

            String value = cmbHienThi.SelectedItem.ToString();

            if(value.Equals("Tất Cả"))
            {
                cmd = new SqlCommand("Select * from NhanVien", conn);
            }
            else
            {
                cmd = new SqlCommand("Select * from NhanVien where ChucVu = '" + value + "';", conn);
            }

            //Chuyển dữ liệu về data
            SqlDataAdapter data = new SqlDataAdapter(cmd);

            //Tạo kho ảo để lưu trữ dữ liệu
            DataTable dt = new DataTable();

            //Đỗ dữ liệu vào kho
            data.Fill(dt);

            conn.Close();

            //Đõ dữ liệu vào Bảng DataGirdViews
            DGV_BangDS.DataSource = dt;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }
    }
}
