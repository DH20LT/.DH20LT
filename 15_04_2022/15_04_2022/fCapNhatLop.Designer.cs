namespace _15_04_2022
{
    partial class fCapNhatLop
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
            this.lb_maLop = new System.Windows.Forms.Label();
            this.lb_tenLop = new System.Windows.Forms.Label();
            this.lb_maKhoa = new System.Windows.Forms.Label();
            this.tb_maLop = new System.Windows.Forms.TextBox();
            this.tb_tenLop = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.cbbMakhoa = new System.Windows.Forms.ComboBox();
            this.lv_HienThiDL_fLop = new System.Windows.Forms.ListView();
            this.clhMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Location = new System.Drawing.Point(558, 35);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(121, 23);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Cập nhật Lớp";
            // 
            // lb_maLop
            // 
            this.lb_maLop.AutoSize = true;
            this.lb_maLop.Location = new System.Drawing.Point(444, 113);
            this.lb_maLop.Name = "lb_maLop";
            this.lb_maLop.Size = new System.Drawing.Size(69, 23);
            this.lb_maLop.TabIndex = 3;
            this.lb_maLop.Text = "Mã lớp";
            // 
            // lb_tenLop
            // 
            this.lb_tenLop.AutoSize = true;
            this.lb_tenLop.Location = new System.Drawing.Point(440, 148);
            this.lb_tenLop.Name = "lb_tenLop";
            this.lb_tenLop.Size = new System.Drawing.Size(73, 23);
            this.lb_tenLop.TabIndex = 5;
            this.lb_tenLop.Text = "Tên lớp";
            // 
            // lb_maKhoa
            // 
            this.lb_maKhoa.AutoSize = true;
            this.lb_maKhoa.Location = new System.Drawing.Point(431, 81);
            this.lb_maKhoa.Name = "lb_maKhoa";
            this.lb_maKhoa.Size = new System.Drawing.Size(82, 23);
            this.lb_maKhoa.TabIndex = 1;
            this.lb_maKhoa.Text = "Mã khoa";
            // 
            // tb_maLop
            // 
            this.tb_maLop.Location = new System.Drawing.Point(519, 110);
            this.tb_maLop.Name = "tb_maLop";
            this.tb_maLop.Size = new System.Drawing.Size(280, 32);
            this.tb_maLop.TabIndex = 4;
            this.tb_maLop.TextChanged += new System.EventHandler(this.tb_maLop_TextChanged);
            this.tb_maLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_maLop_KeyPress);
            // 
            // tb_tenLop
            // 
            this.tb_tenLop.Location = new System.Drawing.Point(519, 145);
            this.tb_tenLop.Name = "tb_tenLop";
            this.tb_tenLop.Size = new System.Drawing.Size(280, 32);
            this.tb_tenLop.TabIndex = 6;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(341, 199);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 30);
            this.bt_them.TabIndex = 7;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(519, 199);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 30);
            this.bt_Xoa.TabIndex = 8;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(673, 199);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(117, 30);
            this.bt_sua.TabIndex = 9;
            this.bt_sua.Text = "Chỉnh sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Location = new System.Drawing.Point(867, 199);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(107, 30);
            this.bt_dong.TabIndex = 10;
            this.bt_dong.Text = "Quay lại";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // cbbMakhoa
            // 
            this.cbbMakhoa.FormattingEnabled = true;
            this.cbbMakhoa.Location = new System.Drawing.Point(519, 73);
            this.cbbMakhoa.Name = "cbbMakhoa";
            this.cbbMakhoa.Size = new System.Drawing.Size(280, 31);
            this.cbbMakhoa.TabIndex = 2;
            this.cbbMakhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMakhoa_SelectedIndexChanged);
            this.cbbMakhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMakhoa_KeyPress);
            // 
            // lv_HienThiDL_fLop
            // 
            this.lv_HienThiDL_fLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhMaLop,
            this.clhTenLop,
            this.clhMaKhoa});
            this.lv_HienThiDL_fLop.HideSelection = false;
            this.lv_HienThiDL_fLop.Location = new System.Drawing.Point(314, 252);
            this.lv_HienThiDL_fLop.Name = "lv_HienThiDL_fLop";
            this.lv_HienThiDL_fLop.Size = new System.Drawing.Size(660, 326);
            this.lv_HienThiDL_fLop.TabIndex = 11;
            this.lv_HienThiDL_fLop.UseCompatibleStateImageBehavior = false;
            this.lv_HienThiDL_fLop.View = System.Windows.Forms.View.Details;
            this.lv_HienThiDL_fLop.SelectedIndexChanged += new System.EventHandler(this.lv_HienThiDL_fLop_SelectedIndexChanged);
            // 
            // clhMaLop
            // 
            this.clhMaLop.Text = "Mã lớp";
            this.clhMaLop.Width = 116;
            // 
            // clhTenLop
            // 
            this.clhTenLop.Text = "Tên lớp";
            this.clhTenLop.Width = 398;
            // 
            // clhMaKhoa
            // 
            this.clhMaKhoa.Text = "Mã khoa";
            this.clhMaKhoa.Width = 135;
            // 
            // fCapNhatLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 921);
            this.Controls.Add(this.lv_HienThiDL_fLop);
            this.Controls.Add(this.cbbMakhoa);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_tenLop);
            this.Controls.Add(this.tb_maLop);
            this.Controls.Add(this.lb_maKhoa);
            this.Controls.Add(this.lb_tenLop);
            this.Controls.Add(this.lb_maLop);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fCapNhatLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCapNhatLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lb_maLop;
        private System.Windows.Forms.Label lb_tenLop;
        private System.Windows.Forms.Label lb_maKhoa;
        private System.Windows.Forms.TextBox tb_maLop;
        private System.Windows.Forms.TextBox tb_tenLop;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.ComboBox cbbMakhoa;
        private System.Windows.Forms.ListView lv_HienThiDL_fLop;
        private System.Windows.Forms.ColumnHeader clhMaLop;
        private System.Windows.Forms.ColumnHeader clhTenLop;
        private System.Windows.Forms.ColumnHeader clhMaKhoa;
    }
}