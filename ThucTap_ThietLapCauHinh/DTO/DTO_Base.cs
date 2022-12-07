using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Base
    {
        private int id;
        private string nguoiTao;
        private DateTime ngayTao;
        private string nguoiCapNhat;
        private DateTime ngayCapNhat;

        public int Id { get => id; set => id = value; }
        public string NguoiTao { get => nguoiTao; set => nguoiTao = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public string NguoiCapNhat { get => nguoiCapNhat; set => nguoiCapNhat = value; }
        public DateTime NgayCapNhat { get => ngayCapNhat; set => ngayCapNhat = value; }

        public DTO_Base()
        {

        }

        public DTO_Base(int id, string nguoiTao, DateTime ngayTao, string nguoiCapNhat, DateTime ngayCapNhat)
        {
            Id = id;
            NguoiTao = nguoiTao;
            NgayTao = ngayTao;
            NguoiCapNhat = nguoiCapNhat;
            NgayCapNhat = ngayCapNhat;
        }
    }
}
