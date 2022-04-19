using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
          

        }

        private void TTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_ThanhToan1.BringToFront();
        }
    }
}
