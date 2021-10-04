using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_DangNhap
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if(this.txt_TenDangNhap.Text == "ndungithue" && this.txt_MatKhau.Text == "Abc@123")
            {
                MessageBox.Show("Đang nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
