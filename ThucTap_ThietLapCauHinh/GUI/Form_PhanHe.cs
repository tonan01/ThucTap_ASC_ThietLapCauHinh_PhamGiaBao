using BUS;
using DAO;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_PhanHe : FormBase
    {
        public Form_PhanHe()
        {
            InitializeComponent();
        }
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();

        BUS_PhanHe dt = new BUS_PhanHe();
        //lấy kết quả hiển thị
        public bool LayHienThi()
        {
            if (rdb_hienthi.Checked == true)
            {
                return true;
            }
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            //chưa nhập đủ
            if (dt.BatBuocNhap(txt_id.Text, txt_maPhanHe.Text, txt_tenPhanHe.Text))
            {
                return;
            }
            else
            {
                DTO_PhanHe dTO_PhanHe = new DTO_PhanHe(int.Parse(txt_id.Text), txt_maPhanHe.Text, txt_tenPhanHe.Text, txt_ghichu.Text,
               LayHienThi(), null, DateTime.Now, null, DateTime.Now);
                if (dt.KiemTraTrung_ID(dTO_PhanHe))
                {
                    MessageBox.Show("Thành trùng id vui lòng nhập id khác", "Thông Báo");
                    return;
                }
                //thêm
                if (dt.Them(dTO_PhanHe))
                {
                    MessageBox.Show("Thành công", "Thông Báo");
                    GetData();
                    return;
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông Báo");
                    return;
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            //chưa nhập đủ
            if (dt.BatBuocNhap(txt_id.Text, txt_maPhanHe.Text, txt_tenPhanHe.Text))
            {
                return;
            }
            else
            {
                DTO_PhanHe dTO_PhanHe = new DTO_PhanHe(int.Parse(txt_id.Text), txt_maPhanHe.Text, txt_tenPhanHe.Text, txt_ghichu.Text,
              LayHienThi(), null, DateTime.Now, null, DateTime.Now);
                if (dt.KiemTraTrung_ID(dTO_PhanHe) == false)
                {
                    MessageBox.Show("Id này không tồn tại", "Thông Báo");
                    return;
                }
                //sửa
                if (dt.Sua(dTO_PhanHe))
                {
                    MessageBox.Show("Thành công", "Thông Báo");
                    GetData();
                    return;
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông Báo");
                    return;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn Xóa phân hệ này không?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (txt_id.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập id", "Thông Báo");
                    return;
                }
                DTO_PhanHe dTO_PhanHe = new DTO_PhanHe(int.Parse(txt_id.Text), txt_maPhanHe.Text, txt_tenPhanHe.Text, txt_ghichu.Text,
                 LayHienThi(), null, DateTime.Now, null, DateTime.Now);
                if (dt.KiemTraTrung_ID(dTO_PhanHe) == false)
                {
                    MessageBox.Show("Id này không tồn tại", "Thông Báo");
                    return;
                }
                else
                {
                    //sửa
                    if (dt.Xoa(dTO_PhanHe))
                    {
                        MessageBox.Show("Thành công", "Thông Báo");
                        GetData();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông Báo");
                        return;
                    }
                }
            }
        }
        public void GetData()
        {
            gv_PhanHe.DataSource = db.sp_Show_PhanHe().ToList();
        }

        private void Form_PhanHe_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ChiNhapSo(e);
        }

        private void gv_PhanHe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gv_PhanHe_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_PhanHe.CurrentRow != null)
            {
                txt_id.Text = gv_PhanHe.CurrentRow.Cells[0].Value.ToString();
                txt_maPhanHe.Text = gv_PhanHe.CurrentRow.Cells[1].Value.ToString();
                txt_tenPhanHe.Text = gv_PhanHe.CurrentRow.Cells[2].Value.ToString();
                txt_ghichu.Text = gv_PhanHe.CurrentRow.Cells[3].Value.ToString();
                string s = gv_PhanHe.CurrentRow.Cells[4].Value.ToString();
                if (s == "True")
                {
                    rdb_hienthi.Checked = true;
                }
                else
                {
                    rdb_khonghienthi.Checked = true;
                }

            }
        }
    }
}
