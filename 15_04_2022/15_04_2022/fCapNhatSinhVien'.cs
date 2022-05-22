using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _15_04_2022
{
    public partial class fCapNhatSinhVien : Form
    {
        SqlConnection conn;
        public fCapNhatSinhVien()
        {
            InitializeComponent();
        }
    private void fCapNhatSinhVien_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection("Data Source = MAY07; Initial Catalog = QLSV; Integrated Security = True");//kết nối csdl khi mở form (máy trường)
            conn = new SqlConnection("Data Source = LAPTOP-80KHMJNS; Initial Catalog = QLSV; Integrated Security = True");//kết nối csdl khi mở form (máy nhà)

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int i = 0;
            SqlDataReader rd;
            str = "select * from SINHVIEN";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvwSV.Items.Add(rd["MaSinhVien"].ToString());
                lvwSV.Items[i].SubItems.Add(rd["HoTen"].ToString());
                lvwSV.Items[i].SubItems.Add(rd["NgaySinh"].ToString().Replace("12:00:00 AM", ""));
                lvwSV.Items[i].SubItems.Add(rd["MaLop"].ToString());
                i++;
            }
            rd.Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string str, strNgay, strThang, strNam;
            strNgay = dateTimePicker1.Value.Day.ToString();
            strThang = dateTimePicker1.Value.Month.ToString();
            strNam = dateTimePicker1.Value.Year.ToString();
            str = strThang +"/"+ strNgay +"/"+ strNam;
            //str = strNgay +"/"+ strThang +"/"+ strNam;
            tbNgaySinh.Text = str;
        }

        private void bt_them_Click(object sender, EventArgs e) // cần ktra xem điểm có tồn tại
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd, cmd1;
            string str, str1;
            int dem,dem1;

            str = "select count (*) from SINHVIEN where MaSinhVien = ('" + tbMaSV.Text + "')";
            cmd = new SqlCommand(str, conn);
            dem = (int)cmd.ExecuteScalar();

            //ktra lớp có tồn tại
            str1 = "select count (*) from LOP where MaLop = ('" + tb_maLop.Text + "')";
            cmd1 = new SqlCommand(str1, conn);
            dem1 = (int)cmd1.ExecuteScalar();

            if (tbMaSV.Text.Trim().Length == 0 || tb_maLop.Text.Trim().Length == 0 || tbHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tbMaSV.Text.Trim().Length <= 3 || tbMaSV.Text.Trim().Length >= 9)
            {
                MessageBox.Show("Mã sinh viên yêu cầu nhập 4 đến 8 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tb_maLop.Text.Trim().Length >= 7 || tb_maLop.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Mã lớp yêu cầu nhập 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dem >= 1)
                {
                    MessageBox.Show("Trùng mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dem1 <=0 )
                {
                    MessageBox.Show("Lớp không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "insert into SINHVIEN (MaSinhVien, HoTen, NgaySinh, MaLop) values ('" + tbMaSV.Text + "', N'" + tbHoTen.Text + "','" + tbNgaySinh.Text + "', N'" + tb_maLop.Text + "')";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_maLop.Text = null;
                    tbMaSV.Text = null;
                    tbHoTen.Text = null;
                    tbNgaySinh.Text = null;
                }
            }

            //refresh
            lvwSV.Items.Clear();
            int i = 0;
            SqlDataReader rd;
            str = "select * from SINHVIEN";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvwSV.Items.Add(rd["MaSinhVien"].ToString());
                lvwSV.Items[i].SubItems.Add(rd["HoTen"].ToString());
                lvwSV.Items[i].SubItems.Add(rd["NgaySinh"].ToString().Replace("12:00:00 AM", ""));
                lvwSV.Items[i].SubItems.Add(rd["MaLop"].ToString());
                i++;
            }
            rd.Close();
            
        }

        /*private void bt_refresh_Click(object sender, EventArgs e)
        {
            lvwSV.Items.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int i = 0;
            SqlDataReader rd;
            str = "select * from SINHVIEN";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvwSV.Items.Add(rd["MaSinhVien"].ToString());
                lvwSV.Items[i].SubItems.Add(rd["HoTen"].ToString());
                lvwSV.Items[i].SubItems.Add(rd["NgaySinh"].ToString().Replace("12:00:00 AM", ""));
                lvwSV.Items[i].SubItems.Add(rd["MaLop"].ToString());
                i++;
            }
            rd.Close();
        }*/

        private void lvwSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iViTri;
            if (lvwSV.FocusedItem.Index >= 0)
            {
                tbMaSV.Text = lvwSV.FocusedItem.Text;
                iViTri = lvwSV.FocusedItem.Index;
                tbHoTen.Text = lvwSV.Items[iViTri].SubItems[1].Text;
                tbNgaySinh.Text = lvwSV.Items[iViTri].SubItems[2].Text;
                tb_maLop.Text = lvwSV.Items[iViTri].SubItems[3].Text;
            }
        }

        private void bt_Dong_Click(object sender, EventArgs e)
        {
            conn.Close();
            Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd, cmd1;
            string str, str1;
            int dem1;

            //ktra sinh viên có tồn tại
            str1 = "select count(*) from SINHVIEN where MaSinhVien = '" + tbMaSV.Text + "'";
            cmd1 = new SqlCommand(str1, conn);
            dem1 = (int)cmd1.ExecuteScalar();

            if (tbMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dem1 <= 0)
            {
                MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (xoa == DialogResult.OK)
                {
                    str = "delete from SINHVIEN where MaSinhVien = '" + tbMaSV.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_maLop.Text = null;
                    tbMaSV.Text = null;
                    tbHoTen.Text = null;
                    tbNgaySinh.Text = null;
                }

                //refresh
                lvwSV.Items.Clear();
                int i = 0;
                SqlDataReader rd;
                str = "select * from SINHVIEN";
                cmd = new SqlCommand(str, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lvwSV.Items.Add(rd["MaSinhVien"].ToString());
                    lvwSV.Items[i].SubItems.Add(rd["HoTen"].ToString());
                    lvwSV.Items[i].SubItems.Add(rd["NgaySinh"].ToString().Replace("12:00:00 AM", ""));
                    lvwSV.Items[i].SubItems.Add(rd["MaLop"].ToString());
                    i++;
                }
                rd.Close();
                
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //ktra sv có tồn tại
            SqlCommand cmdSV;
            string strSV;
            int demSV;
            strSV = "select count(*) from SINHVIEN where MaSinhVien = '" + tbMaSV.Text + "' ";
            cmdSV = new SqlCommand(strSV, conn);
            demSV = (int)cmdSV.ExecuteScalar();

            if(tbMaSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (demSV <= 0)
            {
                MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bt_Sua.Text == "Chỉnh sửa")
            {
                bt_Sua.Text = "Cập nhật";
                tbMaSV.Enabled = false;
                lvwSV.Enabled = false;
            }
            else
            {
                
                SqlCommand cmd, cmd1;
                string str, str1;
                int dem1;

                //ktra lớp có tồn tại
                str1 = "select count (*) from LOP where MaLop = ('" + tb_maLop.Text + "')";
                cmd1 = new SqlCommand(str1, conn);
                dem1 = (int)cmd1.ExecuteScalar();
                if (tb_maLop.Text.Trim().Length == 0 || tbHoTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(tb_maLop.Text.Trim().Length >=7|| tb_maLop.Text.Trim().Length <= 5)
                {
                    MessageBox.Show("Mã lớp yêu cầu nhập 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dem1 <= 0)
                {
                    MessageBox.Show("Lớp này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                else
                {
                    str = "update SINHVIEN set HoTen = N'" + tbHoTen.Text + "', NgaySinh = '" + tbNgaySinh.Text + "', MaLop = '" + tb_maLop.Text + "' where MaSinhVien = '" + tbMaSV.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    bt_Sua.Text = "Cập nhật";
                    tbMaSV.Enabled = true;
                    lvwSV.Enabled = true;
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_maLop.Text = null;
                    tbMaSV.Text = null;
                    tbHoTen.Text = null;
                    tbNgaySinh.Text = null;

                    //refresh
                    lvwSV.Items.Clear();
                    int i = 0;
                    SqlDataReader rd;
                    str = "select * from SINHVIEN";
                    cmd = new SqlCommand(str, conn);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lvwSV.Items.Add(rd["MaSinhVien"].ToString());
                        lvwSV.Items[i].SubItems.Add(rd["HoTen"].ToString());
                        lvwSV.Items[i].SubItems.Add(rd["NgaySinh"].ToString().Replace("12:00:00 AM", ""));
                        lvwSV.Items[i].SubItems.Add(rd["MaLop"].ToString());
                        i++;
                    }
                    rd.Close();

                    tb_maLop.Text = null;
                    tbMaSV.Text = null;
                    tbHoTen.Text = null;
                    tbNgaySinh.Text = null;
                }
                
            }
        }

        private void tbMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
