using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_Truong
    {
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();
        #region Kiểm tra
        //Kiểm tra trùng mã
        public bool KiemTraTrung_ID(DTO_Truong dTO_Truong)
        {
            var kt = db.MB_Truongs.Where(p => p.Id == dTO_Truong.Id).ToList();
            if (kt.Count > 0)
            {
                return true;
            }
            return false;
        }
        //Bắt Buộc nhập
        public bool BatBuocNhap(string pId, string pMaTruong, string pTenTruong)
        {
            if (pId.Length == 0)
            {
                MessageBox.Show("Chưa Nhập Id", "Thông Báo");
                return true;
            }
            if (pMaTruong.Length == 0)
            {
                MessageBox.Show("Chưa Nhập mã trường", "Thông Báo");
                return true;
            }
            if (pTenTruong.Length == 0)
            {
                MessageBox.Show("Chưa Nhập tên trường", "Thông Báo");
                return true;
            }
            return false;
        }
        #endregion

        #region Xử lý
        //Thêm
        public bool Them(DTO_Truong dTO_Truong)
        {
            try
            {
                db.sp_Them_Truong(dTO_Truong.Id,dTO_Truong.MaTruong,dTO_Truong.TenTruong,dTO_Truong.TruocThuocBo
                    ,dTO_Truong.DuongDanLogo,dTO_Truong.IsHienThi,dTO_Truong.IsSuDungRieng,dTO_Truong.ThongTinRieng,
                    dTO_Truong.GhiChu,dTO_Truong.Loai);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Thêm
        public bool Sua(DTO_Truong dTO_Truong)
        {
            try
            {
                db.sp_Sua_Truong(dTO_Truong.Id, dTO_Truong.MaTruong, dTO_Truong.TenTruong, dTO_Truong.TruocThuocBo
                     , dTO_Truong.DuongDanLogo, dTO_Truong.IsHienThi, dTO_Truong.IsSuDungRieng, dTO_Truong.ThongTinRieng,
                     dTO_Truong.GhiChu, dTO_Truong.Loai);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xóa
        public bool Xoa(DTO_Truong dTO_Truong)
        {
            try
            {
                db.sp_Xoa_Truong(dTO_Truong.Id);
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
