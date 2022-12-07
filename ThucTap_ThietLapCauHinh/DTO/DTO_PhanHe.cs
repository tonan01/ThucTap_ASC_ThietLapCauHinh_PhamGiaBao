using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhanHe:DTO_Base
    {
        private string maPhanHe;
        private string tenPhanHe;
        private string ghiChu;
        private bool isHienThi;

        public string MaPhanHe { get => maPhanHe; set => maPhanHe = value; }
        public string TenPhanHe { get => tenPhanHe; set => tenPhanHe = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public bool IsHienThi { get => isHienThi; set => isHienThi = value; }


        public DTO_PhanHe()
        {
        }

        public DTO_PhanHe(int id, string maPhanHe, string tenPhanHe, string ghiChu, bool isHienThi, string nguoiTao, DateTime ngayTao, string nguoiCapNhat, DateTime ngayCapNhat) : base(id, nguoiTao, ngayTao, nguoiCapNhat, ngayCapNhat)
        {
            MaPhanHe = maPhanHe;
            TenPhanHe = tenPhanHe;
            GhiChu = ghiChu;
            IsHienThi = isHienThi;
        }

    }
}
