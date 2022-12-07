using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Truong:DTO_Base
    {
        private string maTruong;
        private string tenTruong;
        private string truocThuocBo;
        private string duongDanLogo;
        private bool isHienThi;
        private bool isSuDungRieng;
        private string thongTinRieng;
        private string ghiChu;
        private int loai;

        public string MaTruong { get => maTruong; set => maTruong = value; }
        public string TenTruong { get => tenTruong; set => tenTruong = value; }
        public string TruocThuocBo { get => truocThuocBo; set => truocThuocBo = value; }
        public string DuongDanLogo { get => duongDanLogo; set => duongDanLogo = value; }
        public bool IsHienThi { get => isHienThi; set => isHienThi = value; }
        public bool IsSuDungRieng { get => isSuDungRieng; set => isSuDungRieng = value; }
        public string ThongTinRieng { get => thongTinRieng; set => thongTinRieng = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int Loai { get => loai; set => loai = value; }

        public DTO_Truong()
        {

        }

        public DTO_Truong(int id, string maTruong, string tenTruong, string truocThuocBo, string duongDanLogo, bool isHienThi, bool isSuDungRieng, string thongTinRieng, string ghiChu, int loai, string nguoiTao, DateTime ngayTao, string nguoiCapNhat, DateTime ngayCapNhat) : base(id, nguoiTao, ngayTao, nguoiCapNhat, ngayCapNhat)
        {
            MaTruong = maTruong;
            TenTruong = tenTruong;
            TruocThuocBo = truocThuocBo;
            DuongDanLogo = duongDanLogo;
            IsHienThi = isHienThi;
            IsSuDungRieng = isSuDungRieng;
            ThongTinRieng = thongTinRieng;
            GhiChu = ghiChu;
            Loai = loai;
        }
    }
}
