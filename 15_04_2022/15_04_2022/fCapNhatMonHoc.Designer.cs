namespace _15_04_2022
{
    partial class fCapNhatMonHoc
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
            this.lb_TD = new System.Windows.Forms.Label();
            this.lb_maMH = new System.Windows.Forms.Label();
            this.tb_maMH = new System.Windows.Forms.TextBox();
            this.lb_tenMH = new System.Windows.Forms.Label();
            this.tb_tenMH = new System.Windows.Forms.TextBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_dong = new System.Windows.Forms.Button();
            this.lvwMH = new System.Windows.Forms.ListView();
            this.clh_maMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh_tenMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_TD
            // 
            this.lb_TD.AutoSize = true;
            this.lb_TD.Location = new System.Drawing.Point(533, 33);
            this.lb_TD.Name = "lb_TD";
            this.lb_TD.Size = new System.Drawing.Size(160, 23);
            this.lb_TD.TabIndex = 0;
            this.lb_TD.Text = "Cập nhật môn học";
            // 
            // lb_maMH
            // 
            this.lb_maMH.AutoSize = true;
            this.lb_maMH.Location = new System.Drawing.Point(424, 93);
            this.lb_maMH.Name = "lb_maMH";
            this.lb_maMH.Size = new System.Drawing.Size(114, 23);
            this.lb_maMH.TabIndex = 1;
            this.lb_maMH.Text = "Mã môn học";
            // 
            // tb_maMH
            // 
            this.tb_maMH.Location = new System.Drawing.Point(544, 90);
            this.tb_maMH.Name = "tb_maMH";
            this.tb_maMH.Size = new System.Drawing.Size(234, 32);
            this.tb_maMH.TabIndex = 2;
            this.tb_maMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_maMH_KeyPress);
            // 
            // lb_tenMH
            // 
            this.lb_tenMH.AutoSize = true;
            this.lb_tenMH.Location = new System.Drawing.Point(420, 131);
            this.lb_tenMH.Name = "lb_tenMH";
            this.lb_tenMH.Size = new System.Drawing.Size(118, 23);
            this.lb_tenMH.TabIndex = 3;
            this.lb_tenMH.Text = "Tên môn học";
            // 
            // tb_tenMH
            // 
            this.tb_tenMH.Location = new System.Drawing.Point(544, 128);
            this.tb_tenMH.Name = "tb_tenMH";
            this.tb_tenMH.Size = new System.Drawing.Size(234, 32);
            this.tb_tenMH.TabIndex = 4;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(245, 186);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(83, 32);
            this.bt_them.TabIndex = 5;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(463, 186);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 32);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(660, 186);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(127, 32);
            this.bt_sua.TabIndex = 7;
            this.bt_sua.Text = "Chỉnh sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_dong
            // 
            this.bt_dong.Location = new System.Drawing.Point(881, 186);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(123, 32);
            this.bt_dong.TabIndex = 8;
            this.bt_dong.Text = "Quay lại";
            this.bt_dong.UseVisualStyleBackColor = true;
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // lvwMH
            // 
            this.lvwMH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clh_maMH,
            this.clh_tenMH});
            this.lvwMH.Location = new System.Drawing.Point(302, 251);
            this.lvwMH.Name = "lvwMH";
            this.lvwMH.Size = new System.Drawing.Size(652, 281);
            this.lvwMH.TabIndex = 9;
            this.lvwMH.UseCompatibleStateImageBehavior = false;
            this.lvwMH.View = System.Windows.Forms.View.Details;
            this.lvwMH.SelectedIndexChanged += new System.EventHandler(this.lvwMH_SelectedIndexChanged);
            // 
            // clh_maMH
            // 
            this.clh_maMH.Text = "Mã môn học";
            this.clh_maMH.Width = 181;
            // 
            // clh_tenMH
            // 
            this.clh_tenMH.Text = "Tên môn học";
            this.clh_tenMH.Width = 453;
            // 
            // fCapNhatMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 921);
            this.Controls.Add(this.lvwMH);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_tenMH);
            this.Controls.Add(this.lb_tenMH);
            this.Controls.Add(this.tb_maMH);
            this.Controls.Add(this.lb_maMH);
            this.Controls.Add(this.lb_TD);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fCapNhatMonHoc";
            this.Text = "fCapNhatMonHoc";
            this.Load += new System.EventHandler(this.fCapNhatMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TD;
        private System.Windows.Forms.Label lb_maMH;
        private System.Windows.Forms.TextBox tb_maMH;
        private System.Windows.Forms.Label lb_tenMH;
        private System.Windows.Forms.TextBox tb_tenMH;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_dong;
        private System.Windows.Forms.ListView lvwMH;
        private System.Windows.Forms.ColumnHeader clh_maMH;
        private System.Windows.Forms.ColumnHeader clh_tenMH;
    }
}