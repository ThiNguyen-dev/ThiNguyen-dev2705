using EFTurtorial.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFTurtorial.ViewModel;

namespace EFTurtorial.BLL
{
    public enum KETQUA
    {
        ThanhCong, TenTrung
    }
    internal class LopHocBLL
    {
        public static List<LopHoc> GetList()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            return model.LopHoc.OrderByDescending(e => e.Name).ToList();
        }

        public static List<LopHocVM> GetListVM()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.LopHoc.Select(e => new LopHocVM
            {
                ID = e.ID,
                Name = e.Name,
                TotalStudent = e.SinhViens.Count() //select count(*)
            }).ToList();
            return ls;
        }
        public static void Delete(long idLop)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHoc.Where(e => e.ID == idLop).FirstOrDefault();
            if (lop != null)
                model.LopHoc.Remove(lop);
            else
                throw new Exception("Lớp học không tồn tại!");
            model.SaveChanges();
        }

        public static KETQUA Add(LopHocVM lopHocVM)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHoc.Where(e => e.Name == lopHocVM.Name).FirstOrDefault();
            if (lop != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                lop = new LopHoc
                {
                    Name = lopHocVM.Name
                };
                model.LopHoc.Add(lop);
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
        public static KETQUA Update(LopHocVM lopHocVM)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHoc.Where(e =>
                e.ID != lopHocVM.ID && e.Name == lopHocVM.Name).FirstOrDefault();
            if (lop != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                lop = model.LopHoc.Where(e => e.ID == lopHocVM.ID).FirstOrDefault();

                lop.Name = lopHocVM.Name;
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
    }
}
