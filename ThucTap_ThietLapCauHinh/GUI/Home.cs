using DAO;
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
    public partial class Home : FormBase
    {
        ThietLapCauHinhDataContext db = new ThietLapCauHinhDataContext();
        public Home()
        {
            InitializeComponent();
        }
        #region Đổi form
        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_main.Controls.Add(childForm);
            this.pn_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        //load dữ liệu danh sách phân hệ
        public void HienThiPhanHe()
        {
            treeView1.Nodes.Clear();
            List<MB_Truong> mB_Truongs = db.MB_Truongs.ToList();
            {
                foreach (MB_Truong t in mB_Truongs)
                {
                    TreeNode node = new TreeNode(t.MaTruong);
                    treeView1.Nodes.Add(node);
                    List<MB_Truong_PhanHe> listPhanheTruong = db.MB_Truong_PhanHes.Where(c => c.IDTruong == t.Id).ToList();
                    foreach (MB_Truong_PhanHe item in listPhanheTruong)
                    {
                        MB_PhanHe mB_PhanHe = db.MB_PhanHes.FirstOrDefault(s => s.Id == item.IDPhanHe);
                        TreeNode node_child = new TreeNode(mB_PhanHe.TenPhanHe);
                        node.Nodes.Add(node_child);
                    }
                }
            }
            treeView1.ExpandAll();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            HienThiPhanHe();
        }

        private void btn_PhanHe_Click(object sender, EventArgs e)
        {
            Form_PhanHe form_PhanHe = new Form_PhanHe();
            OpenChildForm(form_PhanHe, sender);
        }

        private void btn_Truong_Click(object sender, EventArgs e)
        {
            Form_Truong form_Truong = new Form_Truong();
            OpenChildForm(form_Truong, sender);
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            Form_ChiTiet_PhanHe_Truong _ChiTiet_PhanHe_Truong = new Form_ChiTiet_PhanHe_Truong();
            OpenChildForm(_ChiTiet_PhanHe_Truong, sender);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiPhanHe();
        }
    }
}
