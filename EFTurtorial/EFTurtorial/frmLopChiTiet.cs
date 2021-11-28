using EFTurtorial.BLL;
using EFTurtorial.ViewModel;
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
    public partial class frmLopChiTiet : Form
    {
        LopHocVM lopHocVM;
        public frmLopChiTiet(LopHocVM lopHocVM = null)
        {
            InitializeComponent();
            this.lopHocVM = lopHocVM;
            if (lopHocVM == null)
            {
                this.Text = "Thêm mới lớp học";
            }
            else
            {
                this.Text = "Cập nhật dữ liệu lớp học";
                txtTenLop.Text = lopHocVM.Name;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenLop = txtTenLop.Text;
            if (string.IsNullOrEmpty(tenLop))
            {
                errorProvider1.SetError(txtTenLop, "Lớp học không được để trống");
                return;
            }
            var rs = KETQUA.ThanhCong;
            if (lopHocVM == null)
            {
                //Thêm mới dữ liệu
                rs = LopHocBLL.Add(new LopHocVM { Name = tenLop});
                
            }
            else
            {
                //Cập nhật dữ liệu
                lopHocVM.Name = tenLop;
                rs = LopHocBLL.Update(lopHocVM);
            }

            if (rs == KETQUA.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == KETQUA.TenTrung)
            {
                MessageBox.Show("Tên lớp không được trùng nhau", "Thông báo");
            }
        }
    }
}
