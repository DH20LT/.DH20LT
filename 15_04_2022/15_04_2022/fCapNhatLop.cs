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
    public partial class fCapNhatLop : Form
    {
        SqlConnection conn;// biến kết nối csdl
        public fCapNhatLop()
        {
            InitializeComponent();
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            conn.Close();
            Close();
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
            str = "select count (*) from LOP where MaLop = ('" + tb_maLop.Text + "')";
            cmd = new SqlCommand(str, conn);
            dem = (int)cmd.ExecuteScalar();

            if (tb_maLop.Text.Trim().Length == 0 || tb_tenLop.Text.Trim().Length == 0 || cbbMakhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (tb_maLop.Text.Trim().Length >= 7 || tb_maLop.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Mã lớp yêu cầu nhập 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dem >= 1)
            {
                MessageBox.Show("Trùng lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                str = "insert into LOP (MaLop, TenLop, MaKhoa) values ('" + tb_maLop.Text + "', N'" + tb_tenLop.Text + "', '" + cbbMakhoa.Text +"')";
                cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbbMakhoa.Text = null;
                tb_maLop.Text = null;
                tb_tenLop.Text = null;
            }

            lv_HienThiDL_fLop.Items.Clear();
            int i = 0;
            SqlDataReader rd;
            str = "select * from LOP";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lv_HienThiDL_fLop.Items.Add(rd["MaLop"].ToString());
                lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["TenLop"].ToString());
                lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["Makhoa"].ToString());
                i++;
            }
            rd.Close();
            

            /*if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            {
                SqlCommand cmd;
                string str;
                str = "Select Count(*) from Lop where MaLop = '" + tb_maLop.Text + "'";
                cmd = new SqlCommand(str, conn);
                int dem = (int)cmd.ExecuteScalar();

                if (dem >= 1)
                {
                    MessageBox.Show("Trùng mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbbMakhoa.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "INSERT INTO Lop(MaLop,TenLop,MaKhoa) VALUES ('" + tb_maLop.Text + "', N'" + tb_tenLop.Text + "', N'" + cbbMakhoa.Text + "')";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                }

            }*/

        }

        private void fCapNhatLop_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection("Data Source = MAY07; Initial Catalog = QLSV; Integrated Security = True");// kết nối csdl khi mở form
            conn = new SqlConnection("Data Source = LAPTOP-80KHMJNS; Initial Catalog = QLSV; Integrated Security = True");//kết nối csdl khi mở form (máy nhà)
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd, cmd1;
            string str, str1;
            int i = 0;
            SqlDataReader rd, rd1;

            //hiển thị lên listview
            str = "select * from LOP";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lv_HienThiDL_fLop.Items.Add(rd["MaLop"].ToString());
                lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["TenLop"].ToString());
                lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["Makhoa"].ToString());
                i++;
            }
            rd.Close();

            //hiển thị mã khoa lên comboBox
            str1 = "select * from KHOA";
            cmd1 = new SqlCommand(str1, conn);
            rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                cbbMakhoa.Items.Add(rd1["MaKhoa"].ToString());
            }
            rd1.Close();
            

        }
        /*private void cbbmakhoa()
        {
            //conn = new SqlConnection("Data Source = MAY07; Initial Catalog = QLSV; Integrated Security = True");// kết nối csdl khi mở form
            conn = new SqlConnection("Data Source = LAPTOP-80KHMJNS; Initial Catalog = QLSV; Integrated Security = True");//kết nối csdl khi mở form (máy nhà)
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            SqlDataReader rd;
            str = "select MaKhoa from LOP";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cbbMakhoa.Items.Add(rd["MaKhoa"].ToString());
            }
            rd.Close();
        }*/
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd, cmd1, cmdL;
            string str, strSV, strL;
            int demL;

            strL = "select count (*) from LOP where MaLop = '" + tb_maLop.Text + "'";
            cmdL = new SqlCommand(strL, conn);
            demL = (int)cmdL.ExecuteScalar();


            if (tb_maLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (demL <= 0)
            {
                MessageBox.Show("Lớp này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dele;
                dele = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dele == DialogResult.OK)
                {
                    //phải xóa tất cả sinh viên khỏi lớp trước
                    strSV = "delete from SINHVIEN where MaLop ='" + tb_maLop.Text + "'";
                    cmd1 = new SqlCommand(strSV, conn);
                    cmd1.ExecuteNonQuery();

                    //xóa lớp
                    str = "delete from LOP where MaLop = '" + tb_maLop.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    cbbMakhoa.Text = null;
                    tb_maLop.Text = null;
                    tb_tenLop.Text = null;
                }
                lv_HienThiDL_fLop.Items.Clear();
                int i = 0;
                SqlDataReader rd;
                str = "select * from LOP";
                cmd = new SqlCommand(str, conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lv_HienThiDL_fLop.Items.Add(rd["MaLop"].ToString());
                    lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["TenLop"].ToString());
                    lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["Makhoa"].ToString());
                    i++;
                }
                rd.Close();
                
            }
                
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //ktra sv có tồn tại
            SqlCommand cmdL;
            string strL;
            int demL;
            strL = "select count(*) from LOP where MaLop = '" + tb_maLop.Text + "' ";
            cmdL = new SqlCommand(strL, conn);
            demL = (int)cmdL.ExecuteScalar();

            if (tb_maLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (demL <= 0)
            {
                MessageBox.Show("Lớp này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bt_sua.Text == "Chỉnh sửa")
            {
                bt_sua.Text = "Cập nhật";
                tb_maLop.Enabled = false;
                cbbMakhoa.Enabled = false;
                lv_HienThiDL_fLop.Enabled = false;
            }
            else
            {
                
                SqlCommand cmd;
                string str;
                if (tb_tenLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    str = "update LOP set TenLop = N'" + tb_tenLop.Text + "' where MaLop = '" + tb_maLop.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    bt_sua.Text = "Chỉnh sửa";
                    tb_maLop.Enabled = true;
                    cbbMakhoa.Enabled = true;
                    lv_HienThiDL_fLop.Enabled = true;
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cbbMakhoa.Text = null;
                    tb_maLop.Text = null;
                    tb_tenLop.Text = null;

                    lv_HienThiDL_fLop.Items.Clear();
                    if (conn.State == ConnectionState.Closed) ;
                    int i = 0;
                    SqlDataReader rd;
                    str = "select * from LOP";
                    cmd = new SqlCommand(str, conn);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        lv_HienThiDL_fLop.Items.Add(rd["MaLop"].ToString());
                        lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["TenLop"].ToString());
                        lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["Makhoa"].ToString());
                        i++;
                    }
                    rd.Close();
                }
            }
        }

        private void lv_HienThiDL_fLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iViTri;
            if (lv_HienThiDL_fLop.FocusedItem.Index >= 0)
            {
                tb_maLop.Text = lv_HienThiDL_fLop.FocusedItem.Text;
                iViTri = lv_HienThiDL_fLop.FocusedItem.Index;
                tb_tenLop.Text = lv_HienThiDL_fLop.Items[iViTri].SubItems[1].Text;
                cbbMakhoa.Text = lv_HienThiDL_fLop.Items[iViTri].SubItems[2].Text;
            }
        }

        private void cbbMakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_maLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_maLop_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbbMakhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //không được nhập bất kì phím nào
            e.Handled = true;
        }

        /*private void bt_refresh_fLop_Click(object sender, EventArgs e)
        {
            lv_HienThiDL_fLop.Items.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int i = 0;
            SqlDataReader rd;
            str = "select * from LOP";
            cmd = new SqlCommand(str, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lv_HienThiDL_fLop.Items.Add(rd["MaLop"].ToString());
                lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["TenLop"].ToString());
                lv_HienThiDL_fLop.Items[i].SubItems.Add(rd["Makhoa"].ToString());
                i++;
            }
            rd.Close();
        }*/
    }
}
