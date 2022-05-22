namespace _15_04_2022
{
    partial class fCapNhatKhoa
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.lbNhapMaKhoa = new System.Windows.Forms.Label();
            this.lbNhapTenKhoa = new System.Windows.Forms.Label();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.tbTenKhoa = new System.Windows.Forms.TextBox();
            this.btDong = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SoKhoa = new System.Windows.Forms.TextBox();
            this.lvHienThiDL = new System.Windows.Forms.ListView();
            this.clh_MaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_TenKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_DemSoKhoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Location = new System.Drawing.Point(544, 31);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(138, 23);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Cập Nhật Khoa";
            // 
            // lbNhapMaKhoa
            // 
            this.lbNhapMaKhoa.AutoSize = true;
            this.lbNhapMaKhoa.Location = new System.Drawing.Point(431, 70);
            this.lbNhapMaKhoa.Name = "lbNhapMaKhoa";
            this.lbNhapMaKhoa.Size = new System.Drawing.Size(87, 23);
            this.lbNhapMaKhoa.TabIndex = 1;
            this.lbNhapMaKhoa.Text = "Mã Khoa";
            // 
            // lbNhapTenKhoa
            // 
            this.lbNhapTenKhoa.AutoSize = true;
            this.lbNhapTenKhoa.Location = new System.Drawing.Point(427, 108);
            this.lbNhapTenKhoa.Name = "lbNhapTenKhoa";
            this.lbNhapTenKhoa.Size = new System.Drawing.Size(91, 23);
            this.lbNhapTenKhoa.TabIndex = 3;
            this.lbNhapTenKhoa.Text = "Tên Khoa";
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.Location = new System.Drawing.Point(524, 67);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.Size = new System.Drawing.Size(261, 32);
            this.tbMaKhoa.TabIndex = 2;
            this.tbMaKhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaKhoa_KeyPress);
            // 
            // tbTenKhoa
            // 
            this.tbTenKhoa.Location = new System.Drawing.Point(524, 105);
            this.tbTenKhoa.Name = "tbTenKhoa";
            this.tbTenKhoa.Size = new System.Drawing.Size(261, 32);
            this.tbTenKhoa.TabIndex = 4;
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(766, 154);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(89, 35);
            this.btDong.TabIndex = 8;
            this.btDong.Text = "Quay lại";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(392, 154);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(71, 35);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(516, 154);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(64, 35);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(627, 154);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 35);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Chỉnh sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số khoa";
            // 
            // tb_SoKhoa
            // 
            this.tb_SoKhoa.Location = new System.Drawing.Point(457, 210);
            this.tb_SoKhoa.Name = "tb_SoKhoa";
            this.tb_SoKhoa.Size = new System.Drawing.Size(261, 32);
            this.tb_SoKhoa.TabIndex = 10;
            // 
            // lvHienThiDL
            // 
            this.lvHienThiDL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_MaKhoa,
            this.clh_TenKhoa});
            this.lvHienThiDL.HideSelection = false;
            this.lvHienThiDL.Location = new System.Drawing.Point(261, 267);
            this.lvHienThiDL.Name = "lvHienThiDL";
            this.lvHienThiDL.Size = new System.Drawing.Size(716, 289);
            this.lvHienThiDL.TabIndex = 12;
            this.lvHienThiDL.UseCompatibleStateImageBehavior = false;
            this.lvHienThiDL.View = System.Windows.Forms.View.Details;
            this.lvHienThiDL.SelectedIndexChanged += new System.EventHandler(this.lvHienThiDL_SelectedIndexChanged);
            // 
            // clh_MaKhoa
            // 
            this.clh_MaKhoa.Text = "Mã Khoa";
            this.clh_MaKhoa.Width = 234;
            // 
            // clh_TenKhoa
            // 
            this.clh_TenKhoa.Text = "Tên Khoa";
            this.clh_TenKhoa.Width = 466;
            // 
            // bt_DemSoKhoa
            // 
            this.bt_DemSoKhoa.Location = new System.Drawing.Point(748, 210);
            this.bt_DemSoKhoa.Name = "bt_DemSoKhoa";
            this.bt_DemSoKhoa.Size = new System.Drawing.Size(128, 35);
            this.bt_DemSoKhoa.TabIndex = 11;
            this.bt_DemSoKhoa.Text = "Đếm số khoa";
            this.bt_DemSoKhoa.UseVisualStyleBackColor = true;
            this.bt_DemSoKhoa.Click += new System.EventHandler(this.bt_DemSoKhoa_Click);
            // 
            // fCapNhatKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 921);
            this.Controls.Add(this.bt_DemSoKhoa);
            this.Controls.Add(this.lvHienThiDL);
            this.Controls.Add(this.tb_SoKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.tbTenKhoa);
            this.Controls.Add(this.tbMaKhoa);
            this.Controls.Add(this.lbNhapTenKhoa);
            this.Controls.Add(this.lbNhapMaKhoa);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fCapNhatKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCapNhatKhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbNhapMaKhoa;
        private System.Windows.Forms.Label lbNhapTenKhoa;
        private System.Windows.Forms.TextBox tbMaKhoa;
        private System.Windows.Forms.TextBox tbTenKhoa;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SoKhoa;
        private System.Windows.Forms.ListView lvHienThiDL;
        private System.Windows.Forms.ColumnHeader clh_MaKhoa;
        private System.Windows.Forms.ColumnHeader clh_TenKhoa;
        private System.Windows.Forms.Button bt_DemSoKhoa;
    }
}