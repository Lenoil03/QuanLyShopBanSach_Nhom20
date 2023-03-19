using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopBanSach_Nhom20
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void tsmiDangKy_Click(object sender, EventArgs e)
        {
            var form = new frmDangKy();
            form.ShowDialog();
        }

        private void tsmiTimKiem_Click(object sender, EventArgs e)
        {
            var form = new frmTimKiem();
            form.ShowDialog();
        }

        private void tsmiHienThi_Click(object sender, EventArgs e)
        {
            var form = new frmHienThi();
            form.ShowDialog();
        }
    }
}
