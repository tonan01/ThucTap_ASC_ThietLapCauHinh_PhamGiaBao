using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhanHe
    {
        DAO_PhanHe dt = new DAO_PhanHe();
        //Kiểm tra nhập đủ
        public bool BatBuocNhap(string pId, string pMaPhanHe, string pTenPhanHe)
        {
            return dt.BatBuocNhap(pId, pMaPhanHe, pTenPhanHe);
        }
        //Thêm
        public bool Them(DTO_PhanHe pPhanHe)
        {
            return dt.Them(pPhanHe);
        }
        //Sửa
        public bool Sua(DTO_PhanHe pPhanHe)
        {
            return dt.Sua(pPhanHe);
        }
        //Xóa
        public bool Xoa(DTO_PhanHe pPhanHe)
        {
            return dt.Xoa(pPhanHe);
        }
        //Kiểm tra trùng mã
        public bool KiemTraTrung_ID(DTO_PhanHe pPhanHe)
        {
            return dt.KiemTraTrung_ID(pPhanHe);
        }
    }
}
