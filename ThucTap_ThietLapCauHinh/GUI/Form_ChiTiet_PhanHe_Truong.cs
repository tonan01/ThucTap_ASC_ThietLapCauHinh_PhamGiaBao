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
    public partial class Form_ChiTiet_PhanHe_Truong : FormBase
    {
        public Form_ChiTiet_PhanHe_Truong()
        {
            InitializeComponent();
        }
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();
        BUS_ChiTiet_PhanHe_Truong dt = new BUS_ChiTiet_PhanHe_Truong();
        #region Xử lý thêm

        //lấy kết quả HasAds
        public bool LayHasAds()
        {
            if (rdb_hasads_co.Checked == true)
            {
                return true;
            }
            return false;
        }

        //lấy kết quả UseHTMLSalaryView
        public bool LayUseHTMLSalaryView()
        {
            if (rdb_userhtml_co.Checked == true)
            {
                return true;
            }
            return false;
        }

        //hiển thị
        public void GetData()
        {
            gv_phanhe_Truong.DataSource = db.sp_Show_Truong_PhanHe().ToList();
        } 
        #endregion
        private void Form_ChiTiet_PhanHe_Truong_Load(object sender, EventArgs e)
        {
            txt_id.Enabled = false;
            GetData();
            //id trường
            cbb_idtruong.DataSource = db.sp_Show_Truong();
            cbb_idtruong.DisplayMember = "MaTruong";
            cbb_idtruong.ValueMember = "Id";
            //phân hệ
            cbb_idPhanhe.DataSource = db.sp_Show_PhanHe();
            cbb_idPhanhe.DisplayMember = "MaPhanHe";
            cbb_idPhanhe.ValueMember = "Id";
        }

        private void gv_phanhe_Truong_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_phanhe_Truong.CurrentRow != null)
            {
                txt_id.Text = gv_phanhe_Truong.CurrentRow.Cells[0].Value.ToString();
                cbb_idtruong.SelectedValue= gv_phanhe_Truong.CurrentRow.Cells[1].Value;
                cbb_idPhanhe.SelectedValue = gv_phanhe_Truong.CurrentRow.Cells[2].Value;
                if (gv_phanhe_Truong.CurrentRow.Cells[22].Value.ToString() == "True")
                {
                    rdb_hasads_co.Checked = true;
                }
                else
                {
                    rdb_hasads_khong.Checked = true;
                }

                if (gv_phanhe_Truong.CurrentRow.Cells[24].Value.ToString() == "True")
                {
                    rdb_userhtml_co.Checked = true;
                }
                else
                {
                    rdb_userhtml_khong.Checked = true;
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_ChiTiet_PhanHe_Truong dTO_ChiTiet = new DTO_ChiTiet_PhanHe_Truong(0, int.Parse(cbb_idtruong.SelectedValue.ToString()),
                int.Parse(cbb_idPhanhe.SelectedValue.ToString()), txt_url1.Text,
               txt_url2.Text, txt_url3.Text, txt_urlsocket.Text, txt_subapi1.Text, txt_subapi2.Text, txt_subapi3.Text,
               txt_ghichu.Text, txt_war_rs.Text, txt_featureRS.Text, _NhapSo(txt_versionEgovAPI.Text), txt_UrlPayment.Text,
               _NhapSo(txt_versionstudent.Text), txt_warmessage.Text, LayHasAds(), txt_weburl.Text, _NhapSo(txt_sersionwweb.Text),
               LayUseHTMLSalaryView(), null, DateTime.Now, null, DateTime.Now);
            //thêm
            if (dt.Them(dTO_ChiTiet))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txt_id.Text.Length==0)
            {
                MessageBox.Show("Vui lòng chọn vào phân hệ cần sửa");
                return;
            }    
            DTO_ChiTiet_PhanHe_Truong dTO_ChiTiet = new DTO_ChiTiet_PhanHe_Truong(int.Parse(txt_id.Text), int.Parse(cbb_idtruong.SelectedValue.ToString()),
                int.Parse(cbb_idPhanhe.SelectedValue.ToString()), txt_url1.Text,
               txt_url2.Text, txt_url3.Text, txt_urlsocket.Text, txt_subapi1.Text, txt_subapi2.Text, txt_subapi3.Text,
               txt_ghichu.Text, txt_war_rs.Text, txt_featureRS.Text, _NhapSo(txt_versionEgovAPI.Text), txt_UrlPayment.Text,
               _NhapSo(txt_versionstudent.Text), txt_warmessage.Text, LayHasAds(), txt_weburl.Text, _NhapSo(txt_sersionwweb.Text),
               LayUseHTMLSalaryView(), null, DateTime.Now, null, DateTime.Now);
            //thêm
            if (dt.Sua(dTO_ChiTiet))
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn vào phân hệ cần xóa");
                return;
            }
           
            //sửa
            if (dt.Xoa(int.Parse(txt_id.Text)))
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
