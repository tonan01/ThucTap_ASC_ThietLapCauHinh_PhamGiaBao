using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTiet_PhanHe_Truong
    {
        DAO_ChiTiet_PhanHe_Truong dt = new DAO_ChiTiet_PhanHe_Truong();

        //Thêm
        public bool Them(DTO_ChiTiet_PhanHe_Truong pPHT)
        {
            return dt.Them(pPHT); 
        }

        //sửa
        public bool Sua(DTO_ChiTiet_PhanHe_Truong pPHT)
        {
            return dt.Sua(pPHT);
        }

        //Xóa
        public bool Xoa(int pId)
        {
            return dt.Xoa(pId);
        }
    }
}
