namespace GUI
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.btn_Truong = new System.Windows.Forms.Button();
            this.btn_PhanHe = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(351, 567);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LamMoi);
            this.panel1.Controls.Add(this.btn_ChiTiet);
            this.panel1.Controls.Add(this.btn_Truong);
            this.panel1.Controls.Add(this.btn_PhanHe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(351, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 63);
            this.panel1.TabIndex = 1;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderRadius = 20;
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(15, 12);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(180, 45);
            this.btn_LamMoi.TabIndex = 3;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.Location = new System.Drawing.Point(549, 22);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(152, 23);
            this.btn_ChiTiet.TabIndex = 2;
            this.btn_ChiTiet.Text = "Chi tiết phân hệ trường";
            this.btn_ChiTiet.UseVisualStyleBackColor = true;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_Truong
            // 
            this.btn_Truong.Location = new System.Drawing.Point(399, 22);
            this.btn_Truong.Name = "btn_Truong";
            this.btn_Truong.Size = new System.Drawing.Size(103, 23);
            this.btn_Truong.TabIndex = 1;
            this.btn_Truong.Text = "Trường";
            this.btn_Truong.UseVisualStyleBackColor = true;
            this.btn_Truong.Click += new System.EventHandler(this.btn_Truong_Click);
            // 
            // btn_PhanHe
            // 
            this.btn_PhanHe.Location = new System.Drawing.Point(238, 22);
            this.btn_PhanHe.Name = "btn_PhanHe";
            this.btn_PhanHe.Size = new System.Drawing.Size(103, 23);
            this.btn_PhanHe.TabIndex = 0;
            this.btn_PhanHe.Text = "Phân Hệ";
            this.btn_PhanHe.UseVisualStyleBackColor = true;
            this.btn_PhanHe.Click += new System.EventHandler(this.btn_PhanHe_Click);
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(351, 63);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(957, 504);
            this.pn_main.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 567);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PhanHe;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Button btn_Truong;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
    }
}