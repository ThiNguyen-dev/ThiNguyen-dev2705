using EFTurtorial.BLL;
using EFTurtorial.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTurtorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ls = LopHocBLL.GetList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lopHoc = comboBox1.SelectedItem as LopHoc;
            if (lopHoc != null)
            {
                var ls = SinhVienBLL.GetList(lopHoc.ID);
                sinhVienBindingSource.DataSource = ls;
                dataGridView1.DataSource = sinhVienBindingSource;
            }
        }
    }
}
