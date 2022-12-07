using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Truong
    {
        DAO_Truong dt = new DAO_Truong();
        //Kiểm tra nhập đủ
        public bool BatBuocNhap(string pId, string pMaTruong, string pTenTruong)
        {
            return dt.BatBuocNhap(pId, pMaTruong, pTenTruong);
        }
        //Thêm
        public bool Them(DTO_Truong dTO_Truong)
        {
            return dt.Them(dTO_Truong);
        }
        //Sửa
        public bool Sua(DTO_Truong dTO_Truong)
        {
            return dt.Sua(dTO_Truong);
        }
        //Xóa
        public bool Xoa(DTO_Truong dTO_Truong)
        {
            return dt.Xoa(dTO_Truong);
        }
        //Kiểm tra trùng mã
        public bool KiemTraTrung_ID(DTO_Truong dTO_Truong)
        {
            return dt.KiemTraTrung_ID(dTO_Truong);
        }
    }
}
