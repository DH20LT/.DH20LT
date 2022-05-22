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
    public partial class fCapNhatKhoa : Form
    {
        SqlConnection conn;// biến kết nối csdl
        public fCapNhatKhoa()
        {
            InitializeComponent();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            conn.Close();
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int dem;
            str = "select count (*) from KHOA where MaKhoa = ('" + tbMaKhoa.Text + "')";
            cmd = new SqlCommand(str, conn);
            dem = (int)cmd.ExecuteScalar();
            if (tbMaKhoa.Text.Trim().Length == 0 || tbTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tbMaKhoa.Text.Trim().Length >= 5)
            {
                MessageBox.Show("Mã khoa không được nhiều hơn 4 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dem >= 1)
                {
                    MessageBox.Show("Trùng khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "insert into KHOA (MaKhoa, TenKhoa) values ('" + tbMaKhoa.Text + "', N'" + tbTenKhoa.Text + "')";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMaKhoa.Text = null;
                    tbTenKhoa.Text = null;
                    tb_SoKhoa.Text = null;
                }
            }

            //refresh
            lvHienThiDL.Items.Clear();
            int i = 0;
            SqlDataReader rd;
            str = "select * from KHOA";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvHienThiDL.Items.Add(rd["MaKhoa"].ToString());
                lvHienThiDL.Items[i].SubItems.Add(rd["TenKhoa"].ToString());
                i++;
            }
            rd.Close();

            
        }
        

        private void fCapNhatKhoa_Load(object sender, EventArgs e)
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
            str = "select * from KHOA";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvHienThiDL.Items.Add(rd["MaKhoa"].ToString());
                lvHienThiDL.Items[i].SubItems.Add(rd["TenKhoa"].ToString());
                i++;
            }
            rd.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd, cmd1;
            string str, str1;
            int dem, dem1;

            //ktra lớp có tồn tại
            str = "select count (*) from LOP where MaKhoa = ('" + tbMaKhoa.Text + "')";
            cmd = new SqlCommand(str, conn);
            dem = (int)cmd.ExecuteScalar();

            //ktra khoa có tồn tại
            str1 = "select count(*) from KHOA where MaKhoa = ('" + tbMaKhoa.Text + "')";
            cmd1 = new SqlCommand(str1, conn);
            dem1 = (int)cmd1.ExecuteScalar();

            if (tbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dem1 <= 0)
            {
                MessageBox.Show("Khoa này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dem >= 1)
            {
                MessageBox.Show("Đã có lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                DialogResult dele;
                dele =  MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dele == DialogResult.OK)
                {
                    str = "delete from Khoa where MaKhoa = '" + tbMaKhoa.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbMaKhoa.Text = null;
                    tbTenKhoa.Text = null;
                    tb_SoKhoa.Text = null;
                }
            }

            //refresh
            lvHienThiDL.Items.Clear();
            int i = 0;
            SqlDataReader rd;
            str = "select * from KHOA";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvHienThiDL.Items.Add(rd["MaKhoa"].ToString());
                lvHienThiDL.Items[i].SubItems.Add(rd["TenKhoa"].ToString());
                i++;
            }
            rd.Close();
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd1;
            string str1;
            int dem1;

            str1 = "select count(*) from KHOA where MaKhoa ='" + tbMaKhoa.Text + "'";
            cmd1 = new SqlCommand(str1, conn);
            dem1 = (int)cmd1.ExecuteScalar();

            if (tbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dem1 <= 0)
            {
                MessageBox.Show("Khoa này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (btSua.Text == "Chỉnh sửa")
            {
                btSua.Text = "Cập nhật";
                tbMaKhoa.Enabled = false;
                lvHienThiDL.Enabled = false;
            }
            else
            {
                SqlCommand cmd;
                string str;

                if (tbTenKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "update KHOA set TenKhoa = N'" + tbTenKhoa.Text + "' where MaKhoa = '" + tbMaKhoa.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();//thực thi trực tiếp ko trả về
                    btSua.Text = "Chỉnh sửa";
                    tbMaKhoa.Enabled = true;
                    lvHienThiDL.Enabled = true;
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbMaKhoa.Text = null;
                    tbTenKhoa.Text = null;
                    tb_SoKhoa.Text = null;

                    //refresh
                    lvHienThiDL.Items.Clear();
                    int i = 0;
                    SqlDataReader rd;
                    str = "select * from KHOA";
                    cmd = new SqlCommand(str, conn);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lvHienThiDL.Items.Add(rd["MaKhoa"].ToString());
                        lvHienThiDL.Items[i].SubItems.Add(rd["TenKhoa"].ToString());
                        i++;
                    }
                    rd.Close();
                    
                }
            }

        }
        private void bt_DemSoKhoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int dem;
            str = "select count (*) from KHOA";
            cmd = new SqlCommand(str, conn);
            dem = (int)cmd.ExecuteScalar();
            tb_SoKhoa.Text = dem.ToString();
        }
        
        // Refresh dữ liệu
        /*private void bt_hienDuLieu_Click(object sender, EventArgs e)
        {
            lvHienThiDL.Items.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int i = 0;
            SqlDataReader rd;
            str = "select * from KHOA";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lvHienThiDL.Items.Add(rd["MaKhoa"].ToString());
                lvHienThiDL.Items[i].SubItems.Add(rd["TenKhoa"].ToString());
                i++;
            }
            rd.Close();
        }*/

        private void lvHienThiDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iViTri;
            if (lvHienThiDL.FocusedItem.Index >= 0)
            {
                tbMaKhoa.Text = lvHienThiDL.FocusedItem.Text;
                iViTri = lvHienThiDL.FocusedItem.Index;
                tbTenKhoa.Text = lvHienThiDL.Items[iViTri].SubItems[1].Text;
            }
        }

        private void tbMaKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nếu ko phải kí tự và khác backspace thì không hiển thị lên màn hình
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
    }
}
