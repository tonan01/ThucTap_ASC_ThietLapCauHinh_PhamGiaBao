using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_PhanHe
    {
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();
        #region Kiểm tra
        //Kiểm tra trùng mã
        public bool KiemTraTrung_ID(DTO_PhanHe pPhanHe)
        {
            var kt = db.MB_PhanHes.Where(p=>p.Id==pPhanHe.Id).ToList();
            if(kt.Count>0)
            {
                return true;
            }
            return false;
        }
        //Bắt Buộc nhập
        public bool BatBuocNhap(string pId, string pMaPhanHe, string pTenPhanHe)
        {
            if (pId.Length == 0)
            {
                MessageBox.Show("Chưa Nhập Id", "Thông Báo");
                return true;
            }
            if (pMaPhanHe.Length == 0)
            {
                MessageBox.Show("Chưa Nhập mã phân hệ", "Thông Báo");
                return true;
            }
            if (pTenPhanHe.Length == 0)
            {
                MessageBox.Show("Chưa Nhập tên phân hệ", "Thông Báo");
                return true;
            }
            return false;
        }
        #endregion

        #region Xử lý
        //Thêm
        public bool Them(DTO_PhanHe pPhanHe)
        {
            try
            {
                db.sp_Them_PhanHe(pPhanHe.Id, pPhanHe.MaPhanHe, pPhanHe.TenPhanHe, pPhanHe.GhiChu);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Thêm
        public bool Sua(DTO_PhanHe pPhanHe)
        {
            try
            {
                db.sp_Sua_PhanHe(pPhanHe.Id, pPhanHe.TenPhanHe, pPhanHe.GhiChu, pPhanHe.IsHienThi);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xóa
        public bool Xoa(DTO_PhanHe pPhanHe)
        {
            try
            {
                db.sp_Xoa_PhanHe(pPhanHe.Id);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
