using BUS;
using DAO;
using DTO;
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
    public partial class Form_Truong : FormBase
    {
        public Form_Truong()
        {
            InitializeComponent();
        }
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();
        BUS_Truong dt = new BUS_Truong();
        #region xử lý thêm
        //lấy kết quả hiển thị
        public bool LayHienThi()
        {
            if (rdb_hienthi.Checked == true)
            {
                return true;
            }
            return false;
        }

        //lấy kết quả thông tin riêng
        public bool LayThongTinRieng()
        {
            if (rdb_sudungrieng_co.Checked == true)
            {
                return true;
            }
            return false;
        }

        //load dữ liệu tường
        public void GetData()
        {
            gv_truong.DataSource = db.sp_Show_Truong().ToList();
        }

        #endregion

        private void Form_Truong_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void gv_truong_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_truong.CurrentRow != null)
            {
                txt_id.Text = gv_truong.CurrentRow.Cells[0].Value.ToString();
                txt_matruong.Text = gv_truong.CurrentRow.Cells[1].Value.ToString();
                txt_tentruong.Text = gv_truong.CurrentRow.Cells[2].Value.ToString();
                //txt_truocthuocbo.Text = gv_truong.CurrentRow.Cells[3].Value.ToString();
                //txt_duonganlogo.Text = gv_truong.CurrentRow.Cells[4].Value.ToString();
                //hiển thị
                if (gv_truong.CurrentRow.Cells[5].Value.ToString() == "True")
                {
                    rdb_hienthi.Checked = true;
                }
                else
                {
                    rdb_khonghienthi.Checked = true;
                }
                //thông tin riêng
                if (gv_truong.CurrentRow.Cells[6].Value.ToString() == "True")
                {
                    rdb_sudungrieng_co.Checked = true;
                }
                else
                {
                    rdb_sudungrieng_khong.Checked = true;
                }
                // txt_thongtinrieng.Text = gv_truong.CurrentRow.Cells[7].Value.ToString();
                //txt_ghichu.Text = gv_truong.CurrentRow.Cells[8].Value.ToString();
                //txt_loai.Text = gv_truong.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //chưa nhập đủ
            if (dt.BatBuocNhap(txt_id.Text, txt_matruong.Text, txt_tentruong.Text))
            {
                return;
            }
            else
            {
                DTO_Truong dTO_Truong = new DTO_Truong(int.Parse(txt_id.Text), txt_matruong.Text, txt_tentruong.Text, txt_truocthuocbo.Text,
                txt_duonganlogo.Text, LayHienThi(), LayThongTinRieng(), txt_thongtinrieng.Text, txt_ghichu.Text, _NhapSo(txt_loai.Text),
                null, DateTime.Now, null, DateTime.Now);
                if (dt.KiemTraTrung_ID(dTO_Truong))
                {
                    MessageBox.Show("Thành trùng id vui lòng nhập id khác", "Thông Báo");
                    return;
                }
                //thêm
                if (dt.Them(dTO_Truong))
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
            if (dt.BatBuocNhap(txt_id.Text, txt_matruong.Text, txt_tentruong.Text))
            {
                return;
            }
            else
            {
                DTO_Truong dTO_Truong = new DTO_Truong(int.Parse(txt_id.Text), txt_matruong.Text, txt_tentruong.Text, txt_truocthuocbo.Text,
                txt_duonganlogo.Text, LayHienThi(), LayThongTinRieng(), txt_thongtinrieng.Text, txt_ghichu.Text, _NhapSo(txt_loai.Text),
                null, DateTime.Now, null, DateTime.Now);
                if (dt.KiemTraTrung_ID(dTO_Truong) == false)
                {
                    MessageBox.Show("Id này không tồn tại", "Thông Báo");
                    return;
                }
                //thêm
                if (dt.Sua(dTO_Truong))
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
            DialogResult dlr = MessageBox.Show("Bạn muốn Xóa trường này không?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (txt_id.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập id", "Thông Báo");
                    return;
                }
                DTO_Truong dTO_Truong = new DTO_Truong(int.Parse(txt_id.Text), txt_matruong.Text, txt_tentruong.Text, txt_truocthuocbo.Text,
                txt_duonganlogo.Text, LayHienThi(), LayThongTinRieng(), txt_thongtinrieng.Text, txt_ghichu.Text, _NhapSo(txt_loai.Text),
                null, DateTime.Now, null, DateTime.Now);
                if (dt.KiemTraTrung_ID(dTO_Truong) == false)
                {
                    MessageBox.Show("Id này không tồn tại", "Thông Báo");
                    return;
                }
                else
                {
                    //sửa
                    if (dt.Xoa(dTO_Truong))
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

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ChiNhapSo(e);
        }

        private void txt_loai_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ChiNhapSo(e);
        }
    }
}
