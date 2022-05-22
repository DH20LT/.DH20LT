namespace _15_04_2022
{
    partial class fCapNhatDiem
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
            this.lb_td = new System.Windows.Forms.Label();
            this.lb_maSV = new System.Windows.Forms.Label();
            this.lb_maMH = new System.Windows.Forms.Label();
            this.lb_diem = new System.Windows.Forms.Label();
            this.tb_diem = new System.Windows.Forms.TextBox();
            this.lvwDiem = new System.Windows.Forms.ListView();
            this.clh_tenMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_tenSV = new System.Windows.Forms.Label();
            this.tb_tenSV = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.cbb_maSV = new System.Windows.Forms.ComboBox();
            this.cbb_maMH = new System.Windows.Forms.ComboBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_td
            // 
            this.lb_td.AutoSize = true;
            this.lb_td.Location = new System.Drawing.Point(540, 21);
            this.lb_td.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_td.Name = "lb_td";
            this.lb_td.Size = new System.Drawing.Size(130, 23);
            this.lb_td.TabIndex = 0;
            this.lb_td.Text = "Cập nhật điểm";
            // 
            // lb_maSV
            // 
            this.lb_maSV.AutoSize = true;
            this.lb_maSV.Location = new System.Drawing.Point(408, 60);
            this.lb_maSV.Name = "lb_maSV";
            this.lb_maSV.Size = new System.Drawing.Size(116, 23);
            this.lb_maSV.TabIndex = 1;
            this.lb_maSV.Text = "Mã sinh viên";
            // 
            // lb_maMH
            // 
            this.lb_maMH.AutoSize = true;
            this.lb_maMH.Location = new System.Drawing.Point(410, 98);
            this.lb_maMH.Name = "lb_maMH";
            this.lb_maMH.Size = new System.Drawing.Size(114, 23);
            this.lb_maMH.TabIndex = 3;
            this.lb_maMH.Text = "Mã môn học";
            // 
            // lb_diem
            // 
            this.lb_diem.AutoSize = true;
            this.lb_diem.Location = new System.Drawing.Point(468, 136);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(56, 23);
            this.lb_diem.TabIndex = 5;
            this.lb_diem.Text = "Điểm";
            // 
            // tb_diem
            // 
            this.tb_diem.Location = new System.Drawing.Point(530, 133);
            this.tb_diem.Name = "tb_diem";
            this.tb_diem.Size = new System.Drawing.Size(302, 32);
            this.tb_diem.TabIndex = 6;
            this.tb_diem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diem_KeyPress);
            // 
            // lvwDiem
            // 
            this.lvwDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_tenMH,
            this.clh_diem});
            this.lvwDiem.Enabled = false;
            this.lvwDiem.Location = new System.Drawing.Point(318, 296);
            this.lvwDiem.Name = "lvwDiem";
            this.lvwDiem.Size = new System.Drawing.Size(625, 308);
            this.lvwDiem.TabIndex = 14;
            this.lvwDiem.UseCompatibleStateImageBehavior = false;
            this.lvwDiem.View = System.Windows.Forms.View.Details;
            this.lvwDiem.SelectedIndexChanged += new System.EventHandler(this.lvwDiem_SelectedIndexChanged);
            // 
            // clh_tenMH
            // 
            this.clh_tenMH.Text = "Môn học";
            this.clh_tenMH.Width = 347;
            // 
            // clh_diem
            // 
            this.clh_diem.Text = "Điểm";
            this.clh_diem.Width = 84;
            // 
            // lb_tenSV
            // 
            this.lb_tenSV.AutoSize = true;
            this.lb_tenSV.Location = new System.Drawing.Point(404, 248);
            this.lb_tenSV.Name = "lb_tenSV";
            this.lb_tenSV.Size = new System.Drawing.Size(120, 23);
            this.lb_tenSV.TabIndex = 12;
            this.lb_tenSV.Text = "Tên sinh viên";
            // 
            // tb_tenSV
            // 
            this.tb_tenSV.Enabled = false;
            this.tb_tenSV.Location = new System.Drawing.Point(530, 245);
            this.tb_tenSV.Name = "tb_tenSV";
            this.tb_tenSV.Size = new System.Drawing.Size(302, 32);
            this.tb_tenSV.TabIndex = 13;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(445, 194);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(94, 36);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(572, 194);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(98, 36);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(693, 194);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(115, 36);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Chỉnh sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Location = new System.Drawing.Point(836, 194);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(107, 36);
            this.bt_dong.TabIndex = 11;
            this.bt_dong.Text = "Quay lại";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // cbb_maSV
            // 
            this.cbb_maSV.FormattingEnabled = true;
            this.cbb_maSV.Location = new System.Drawing.Point(530, 57);
            this.cbb_maSV.Name = "cbb_maSV";
            this.cbb_maSV.Size = new System.Drawing.Size(302, 31);
            this.cbb_maSV.TabIndex = 2;
            this.cbb_maSV.SelectedIndexChanged += new System.EventHandler(this.cbb_maSV_SelectedIndexChanged);
            this.cbb_maSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_maSV_KeyPress);
            // 
            // cbb_maMH
            // 
            this.cbb_maMH.FormattingEnabled = true;
            this.cbb_maMH.Location = new System.Drawing.Point(530, 95);
            this.cbb_maMH.Name = "cbb_maMH";
            this.cbb_maMH.Size = new System.Drawing.Size(302, 31);
            this.cbb_maMH.TabIndex = 4;
            this.cbb_maMH.SelectedIndexChanged += new System.EventHandler(this.cbb_maMH_SelectedIndexChanged);
            this.cbb_maMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_maMH_KeyPress);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(318, 194);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(97, 36);
            this.bt_clear.TabIndex = 7;
            this.bt_clear.Text = "Đặt lại";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // fCapNhatDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 921);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.cbb_maMH);
            this.Controls.Add(this.cbb_maSV);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_tenSV);
            this.Controls.Add(this.lb_tenSV);
            this.Controls.Add(this.lvwDiem);
            this.Controls.Add(this.tb_diem);
            this.Controls.Add(this.lb_diem);
            this.Controls.Add(this.lb_maMH);
            this.Controls.Add(this.lb_maSV);
            this.Controls.Add(this.lb_td);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fCapNhatDiem";
            this.Text = "fCapNhatDiem";
            this.Load += new System.EventHandler(this.fCapNhatDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_td;
        private System.Windows.Forms.Label lb_maSV;
        private System.Windows.Forms.Label lb_maMH;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.TextBox tb_diem;
        private System.Windows.Forms.ListView lvwDiem;
        private System.Windows.Forms.ColumnHeader clh_tenMH;
        private System.Windows.Forms.ColumnHeader clh_diem;
        private System.Windows.Forms.Label lb_tenSV;
        private System.Windows.Forms.TextBox tb_tenSV;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.ComboBox cbb_maSV;
        private System.Windows.Forms.ComboBox cbb_maMH;
        private System.Windows.Forms.Button bt_clear;
    }
}