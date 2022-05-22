namespace _15_04_2022
{
    partial class fCapNhatSinhVien
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
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbMaSinhVien = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.lb_maLop = new System.Windows.Forms.Label();
            this.tb_maLop = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_Dong = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.lvwSV = new System.Windows.Forms.ListView();
            this.clhMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(532, 38);
            this.lbTieuDe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(162, 23);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Cập nhật sinh viên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(380, 180);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(137, 23);
            this.lbNgaySinh.TabIndex = 5;
            this.lbNgaySinh.Text = "Chọn ngày sinh";
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Enabled = false;
            this.tbNgaySinh.Location = new System.Drawing.Point(523, 200);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(298, 32);
            this.tbNgaySinh.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(523, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 32);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbMaSinhVien
            // 
            this.lbMaSinhVien.AutoSize = true;
            this.lbMaSinhVien.Location = new System.Drawing.Point(401, 89);
            this.lbMaSinhVien.Name = "lbMaSinhVien";
            this.lbMaSinhVien.Size = new System.Drawing.Size(116, 23);
            this.lbMaSinhVien.TabIndex = 1;
            this.lbMaSinhVien.Text = "Mã sinh viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(451, 127);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(66, 23);
            this.lbHoTen.TabIndex = 3;
            this.lbHoTen.Text = "Họ tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(523, 124);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(298, 32);
            this.tbHoTen.TabIndex = 4;
            // 
            // tbMaSV
            // 
            this.tbMaSV.Location = new System.Drawing.Point(523, 86);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(298, 32);
            this.tbMaSV.TabIndex = 2;
            this.tbMaSV.TextChanged += new System.EventHandler(this.tbMaSV_TextChanged);
            this.tbMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaSV_KeyPress);
            // 
            // lb_maLop
            // 
            this.lb_maLop.AutoSize = true;
            this.lb_maLop.Location = new System.Drawing.Point(445, 241);
            this.lb_maLop.Name = "lb_maLop";
            this.lb_maLop.Size = new System.Drawing.Size(69, 23);
            this.lb_maLop.TabIndex = 8;
            this.lb_maLop.Text = "Mã lớp";
            // 
            // tb_maLop
            // 
            this.tb_maLop.Location = new System.Drawing.Point(523, 238);
            this.tb_maLop.Name = "tb_maLop";
            this.tb_maLop.Size = new System.Drawing.Size(298, 32);
            this.tb_maLop.TabIndex = 9;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(297, 289);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(79, 30);
            this.bt_them.TabIndex = 10;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(473, 289);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(78, 30);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_Dong
            // 
            this.bt_Dong.Location = new System.Drawing.Point(798, 289);
            this.bt_Dong.Name = "bt_Dong";
            this.bt_Dong.Size = new System.Drawing.Size(130, 30);
            this.bt_Dong.TabIndex = 13;
            this.bt_Dong.Text = "Quay lại";
            this.bt_Dong.UseVisualStyleBackColor = true;
            this.bt_Dong.Click += new System.EventHandler(this.bt_Dong_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(636, 289);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(114, 30);
            this.bt_Sua.TabIndex = 12;
            this.bt_Sua.Text = "Chỉnh sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // lvwSV
            // 
            this.lvwSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhMaSV,
            this.clhTenSV,
            this.clhNgaySinh,
            this.clhMaLop});
            this.lvwSV.Location = new System.Drawing.Point(264, 325);
            this.lvwSV.Name = "lvwSV";
            this.lvwSV.Size = new System.Drawing.Size(716, 229);
            this.lvwSV.TabIndex = 14;
            this.lvwSV.UseCompatibleStateImageBehavior = false;
            this.lvwSV.View = System.Windows.Forms.View.Details;
            this.lvwSV.SelectedIndexChanged += new System.EventHandler(this.lvwSV_SelectedIndexChanged);
            // 
            // clhMaSV
            // 
            this.clhMaSV.Text = "Mã Sinh Viên";
            this.clhMaSV.Width = 140;
            // 
            // clhTenSV
            // 
            this.clhTenSV.Text = "Họ Tên";
            this.clhTenSV.Width = 250;
            // 
            // clhNgaySinh
            // 
            this.clhNgaySinh.Text = "Ngày Sinh";
            this.clhNgaySinh.Width = 120;
            // 
            // clhMaLop
            // 
            this.clhMaLop.Text = "Mã Lớp";
            this.clhMaLop.Width = 130;
            // 
            // fCapNhatSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 921);
            this.Controls.Add(this.lvwSV);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Dong);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_maLop);
            this.Controls.Add(this.lb_maLop);
            this.Controls.Add(this.tbMaSV);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMaSinhVien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fCapNhatSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCapNhatSinhVien_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fCapNhatSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox tbNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbMaSinhVien;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Label lb_maLop;
        private System.Windows.Forms.TextBox tb_maLop;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_Dong;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.ListView lvwSV;
        private System.Windows.Forms.ColumnHeader clhMaSV;
        private System.Windows.Forms.ColumnHeader clhTenSV;
        private System.Windows.Forms.ColumnHeader clhNgaySinh;
        private System.Windows.Forms.ColumnHeader clhMaLop;
    }
}