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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        
        private void FormBase_Load(object sender, EventArgs e)
        {

        }
        #region dialog
        public void _Frm_Exit()
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region Kiểm tra nhập
        //nhập số
        public void _ChiNhapSo(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region mặc định giá trị nhập
        //nhập số
        public int _NhapSo(string pInput)
        {
            if (pInput.Length==0)
            {
                return 0;
            }
            return int.Parse(pInput);
        }
        #endregion
    }
}
