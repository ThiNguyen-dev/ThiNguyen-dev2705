using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm
{
    public partial class frmMathBasic : Form
    {
        public frmMathBasic()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt_SoThuNhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt_SoThuHai.Text;
                long nSoThuHai = long.Parse(soThuHai);

                var ketQua = nSoThuNhat + nSoThuHai;
                lblKQ.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số.Chi tiết lỗi : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Chi tiết lỗi : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi!!!Chi tiết lỗi : {ex.Message}");
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt_SoThuNhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt_SoThuHai.Text;
                long nSoThuHai = long.Parse(soThuHai);

                var ketQua = nSoThuNhat - nSoThuHai;
                lblKQ.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số.Chi tiết lỗi : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Chi tiết lỗi : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi!!!Chi tiết lỗi : {ex.Message}");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt_SoThuNhat.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt_SoThuHai.Text;
                long nSoThuHai = long.Parse(soThuHai);

                var ketQua = nSoThuNhat * nSoThuHai;
                lblKQ.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số.Chi tiết lỗi : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Chi tiết lỗi : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi!!!Chi tiết lỗi : {ex.Message}");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txt_SoThuNhat.Text;
                float nSoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txt_SoThuHai.Text;
                float nSoThuHai = long.Parse(soThuHai);

                if (nSoThuHai == 0)
                {
                    MessageBox.Show("Vui long nhap so khac 0");
                }
                else
                {
                    float ketQua = nSoThuNhat / nSoThuHai;
                    lblKQ.Text = ketQua.ToString();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Lỗi định dạng. Vui lòng nhập số.Chi tiết lỗi : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi số quá lớn.Chi tiết lỗi : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi!!!Chi tiết lỗi : {ex.Message}");
            }

        }

    }
}
