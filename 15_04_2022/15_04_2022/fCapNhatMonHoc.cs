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
    public partial class fCapNhatMonHoc : Form
    {
        SqlConnection conn;
        public fCapNhatMonHoc()
        {
            InitializeComponent();
        }

        private void fCapNhatMonHoc_Load(object sender, EventArgs e)
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
            str = "select * from MONHOC";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvwMH.Items.Add(rd["MaMonHoc"].ToString());
                lvwMH.Items[i].SubItems.Add(rd["TenMonHoc"].ToString());
                i++;
            }
            rd.Close();
        }

        private void tb_maMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ hiển thị kí tự và backspace
            if (!Char.IsLetterOrDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
            //viết hoa
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int dem;

            str = "select count (*) from MONHOC where MaMonHoc = ('" + tb_maMH.Text + "')";
            cmd = new SqlCommand(str, conn);
            dem = (int)cmd.ExecuteScalar();
            
            if (tb_maMH.Text.Trim().Length == 0 || tb_tenMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_maMH.Text.Trim().Length >=11)
            {
                MessageBox.Show("Mã môn học yêu cầu nhập không quá 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dem >= 1)
                {
                    MessageBox.Show("Trùng mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "insert into MONHOC (MaMonHoc, TenMonHoc) values ('" + tb_maMH.Text + "', N'" + tb_tenMH.Text + "')";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_maMH.Text = null;
                    tb_tenMH.Text = null;
                }
            }

            //refresh
            lvwMH.Items.Clear();
            int i = 0;
            SqlDataReader rd;
            str = "select * from MONHOC";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvwMH.Items.Add(rd["MaMonHoc"].ToString());
                lvwMH.Items[i].SubItems.Add(rd["TenMonHoc"].ToString());
                i++;
            }
            rd.Close();
            
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

            //ktra môn học có tồn tại
            str1 = "select count (*) from MONHOC where MaMonHoc = '" + tb_maMH.Text + "'";
            cmd1 = new SqlCommand(str1, conn);
            dem1 = (int)cmd1.ExecuteScalar();

            if (tb_maMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dem1 <= 0)
            {
                MessageBox.Show("Môn học không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (xoa == DialogResult.OK)
                {
                    str = "delete from MONHOC where MaMonHoc = '" + tb_maMH.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_maMH.Text = null;
                    tb_tenMH.Text = null;
                }

                //refresh
                lvwMH.Items.Clear();
                int i = 0;
                SqlDataReader rd;
                str = "select * from MONHOC";
                cmd = new SqlCommand(str, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lvwMH.Items.Add(rd["MaMonHoc"].ToString());
                    lvwMH.Items[i].SubItems.Add(rd["TenMonHoc"].ToString());
                    i++;
                }
                rd.Close();
            }
            
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            conn.Close();
            Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd, cmd1;
            string str, str1;
            int dem1;

            //ktra môn học có tồn tại
            str1 = "select count (*) from MONHOC where MaMonHoc = ('" + tb_maMH.Text + "')";
            cmd1 = new SqlCommand(str1, conn);
            dem1 = (int)cmd1.ExecuteScalar();

            if (tb_maMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dem1 <= 0)
            {
                MessageBox.Show("Môn học không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bt_sua.Text == "Chỉnh sửa")
            {
                bt_sua.Text = "Cập nhật";
                tb_maMH.Enabled = false;
                lvwMH.Enabled = false;
            }
            else
            {
                if (tb_tenMH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "update MONHOC set TenMonHoc = N'" + tb_tenMH.Text + "' where MaMonHoc = '" + tb_maMH.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    bt_sua.Text = "Chỉnh sửa";
                    tb_maMH.Enabled = true;
                    lvwMH.Enabled = true;
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_maMH.Text = null;
                    tb_tenMH.Text = null;

                    //refresh
                    lvwMH.Items.Clear();
                    int i = 0;
                    SqlDataReader rd;
                    str = "select * from MONHOC";
                    cmd = new SqlCommand(str, conn);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lvwMH.Items.Add(rd["MaMonHoc"].ToString());
                        lvwMH.Items[i].SubItems.Add(rd["TenMonHoc"].ToString());
                        i++;
                    }
                    rd.Close();
                }
            }
        }

        private void lvwMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iViTri;
            if (lvwMH.FocusedItem.Index >= 0)
            {
                tb_maMH.Text = lvwMH.FocusedItem.Text;
                iViTri = lvwMH.FocusedItem.Index;
                tb_tenMH.Text = lvwMH.Items[iViTri].SubItems[1].Text;
            }
        }
    }
}
