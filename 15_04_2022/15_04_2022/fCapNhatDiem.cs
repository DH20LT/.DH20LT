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
    public partial class fCapNhatDiem : Form
    {
        SqlConnection conn;
        public fCapNhatDiem()
        {
            InitializeComponent();
        }
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDiem;
            string strDiem;
            int demDiem;

            strDiem = "select count(*) from DIEM where MaMonHoc = '" + cbb_maMH.Text + "' and MaSinhVien = '" + cbb_maSV.Text + "'";
            cmdDiem = new SqlCommand(strDiem, conn);
            demDiem = (int)cmdDiem.ExecuteScalar();

            if (cbb_maMH.Text == "" || cbb_maSV.Text == "")
            {
                MessageBox.Show("Yêu cầu chọn đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(tb_diem.Text)>=11)
            {
                MessageBox.Show("Không được nhập quá 10 điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(demDiem >= 1)
            {
                MessageBox.Show("Đã có điểm! Không thể nhập thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd;
                string str;
                str = "insert into DIEM (MaSinhVien, MaMonHoc, Diem) values ('" + cbb_maSV.Text + "', '" + cbb_maMH.Text + "','" + tb_diem.Text + "')";
                cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //hiện dữ liệu sau khi thêm thành công
            lvwDiem.Items.Clear();
            string strMH, strD;
            int i = 0;
            SqlCommand cmdMH, cmdD;
            SqlDataReader rdMH, rdD;

            if (cbb_maMH.Text == "")
            {
                strD = "select D.Diem, D.MaSinhVien, O.TenMonHoc from DIEM as D,MONHOC as O where D.MaMonHoc = O.MaMonHoc and MaSinhVien = '" + cbb_maSV.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items.Add(rdD["TenMonHoc"].ToString());
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }
            else
            {


                //đưa tên mh vào lvw
                strMH = "select * from MONHOC where MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdMH = new SqlCommand(strMH, conn);
                rdMH = cmdMH.ExecuteReader();
                while (rdMH.Read())
                {
                    lvwDiem.Items.Add(rdMH["TenMonHoc"].ToString());
                }
                rdMH.Close();

                //đưa điểm vào lvw
                strD = "select * from DIEM where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }

        }

        private void fCapNhatDiem_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection("Data Source = MAY07; Initial Catalog = QLSV; Integrated Security = True");//kết nối csdl khi mở form (máy trường)
            conn = new SqlConnection("Data Source = LAPTOP-80KHMJNS; Initial Catalog = QLSV; Integrated Security = True");//kết nối csdl khi mở form (máy nhà)

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmdMH, cmdSV;
            string strMH, strSV;
            SqlDataReader rdMH, rdSV;

            //hiện mã sv lên cbb
            strSV = "select * from SINHVIEN";
            cmdSV = new SqlCommand(strSV, conn);
            rdSV = cmdSV.ExecuteReader();
            while (rdSV.Read())
            {
                cbb_maSV.Items.Add(rdSV["MaSinhVien"].ToString());
            }
            rdSV.Close();

            //hiện môn học lên cbb
            strMH = "select * from MONHOC";
            cmdMH = new SqlCommand(strMH, conn);
            rdMH = cmdMH.ExecuteReader();
            while (rdMH.Read())
            {
                cbb_maMH.Items.Add(rdMH["MaMonHoc"].ToString());
            }
            rdMH.Close();
        }

        private void cbb_maSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hiện dữ liệu khi chọn
            lvwDiem.Items.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmdSV;
            string strSV;
            string iSV;

            strSV = "select HoTen from SINHVIEN where MaSinhVien = '" + cbb_maSV.Text + "'";
            cmdSV = new SqlCommand(strSV, conn);
            iSV = (string)cmdSV.ExecuteScalar();
            tb_tenSV.Text = iSV;

            lvwDiem.Items.Clear();
            string strMH, strD;
            int i = 0;
            SqlCommand cmdMH, cmdD;
            SqlDataReader rdMH, rdD;

            if (cbb_maMH.Text == "")
            {
                strD = "select D.Diem, D.MaSinhVien, O.TenMonHoc from DIEM as D,MONHOC as O where D.MaMonHoc = O.MaMonHoc and MaSinhVien = '" + cbb_maSV.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items.Add(rdD["TenMonHoc"].ToString());
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }
            else
            {
                //đưa tên mh vào lvw
                strMH = "select * from MONHOC where MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdMH = new SqlCommand(strMH, conn);
                rdMH = cmdMH.ExecuteReader();
                while (rdMH.Read())
                {
                    lvwDiem.Items.Add(rdMH["TenMonHoc"].ToString());
                }
                rdMH.Close();

                //đưa điểm vào lvw
                strD = "select * from DIEM where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();

            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbb_maSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbb_maMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tb_diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;
            int dem;

            if (cbb_maSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu chọn mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbb_maMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu chọn mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult xoa;
                xoa = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (xoa == DialogResult.OK)
                {
                    str = "delete Diem from DIEM where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                    cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvwDiem.Items.Clear();
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd;
            string str;

            if (cbb_maSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu chọn mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbb_maMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yêu cầu chọn mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bt_sua.Text == "Chỉnh sửa")
            {
                bt_sua.Text = "Cập nhật";
                cbb_maMH.Enabled = false;
                cbb_maSV.Enabled = false;
            }
            else
            {
                str = "update DIEM set Diem = '" + tb_diem.Text + "' where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                bt_sua.Text = "Chỉnh sửa";
                cbb_maMH.Enabled = true;
                cbb_maSV.Enabled = true;
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //hiện dữ liệu sau khi chỉnh sửa
                lvwDiem.Items.Clear();
                string strMH, strD;
                int i = 0;
                SqlCommand cmdMH, cmdD;
                SqlDataReader rdMH, rdD;

                if (cbb_maMH.Text == "")
                {
                    strD = "select D.Diem, D.MaSinhVien, O.TenMonHoc from DIEM as D,MONHOC as O where D.MaMonHoc = O.MaMonHoc and MaSinhVien = '" + cbb_maSV.Text + "'";
                    cmdD = new SqlCommand(strD, conn);
                    rdD = cmdD.ExecuteReader();
                    while (rdD.Read())
                    {
                        lvwDiem.Items.Add(rdD["TenMonHoc"].ToString());
                        lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                        i++;
                    }
                    rdD.Close();
                }
                else
                {


                    //đưa tên mh vào lvw
                    strMH = "select * from MONHOC where MaMonHoc = '" + cbb_maMH.Text + "'";
                    cmdMH = new SqlCommand(strMH, conn);
                    rdMH = cmdMH.ExecuteReader();
                    while (rdMH.Read())
                    {
                        lvwDiem.Items.Add(rdMH["TenMonHoc"].ToString());
                    }
                    rdMH.Close();

                    //đưa điểm vào lvw
                    strD = "select * from DIEM where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                    cmdD = new SqlCommand(strD, conn);
                    rdD = cmdD.ExecuteReader();
                    while (rdD.Read())
                    {
                        lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                        i++;
                    }
                    rdD.Close();
                }
            }
        }

        /*private void bt_xem_Click(object sender, EventArgs e)
        {
            //hiện dữ liệu khi chọn
            lvwDiem.Items.Clear();
            string strMH, strD;
            int i = 0;
            SqlCommand cmdMH, cmdD;
            SqlDataReader rdMH, rdD;

            if (cbb_maMH.Text == "")
            {
                strD = "select D.Diem, D.MaSinhVien, O.TenMonHoc from DIEM as D,MONHOC as O where D.MaMonHoc = O.MaMonHoc and MaSinhVien = '" + cbb_maSV.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items.Add(rdD["TenMonHoc"].ToString());
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }
            else
            {
                

                //đưa tên mh vào lvw
                strMH = "select * from MONHOC where MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdMH = new SqlCommand(strMH, conn);
                rdMH = cmdMH.ExecuteReader();
                while (rdMH.Read())
                {
                    lvwDiem.Items.Add(rdMH["TenMonHoc"].ToString());
                }
                rdMH.Close();

                //đưa điểm vào lvw
                strD = "select * from DIEM where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }
        }*/

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lvwDiem.Items.Clear();
            cbb_maMH.Text = null;
            cbb_maSV.Text = null;
            tb_diem.Text = null;
            tb_tenSV.Text = null;
        }

        private void cbb_maMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hiện dữ liệu khi chọn
            lvwDiem.Items.Clear();
            string strMH, strD;
            int i = 0;
            SqlCommand cmdMH, cmdD;
            SqlDataReader rdMH, rdD;

            if (cbb_maMH.Text == "")
            {
                strD = "select D.Diem, D.MaSinhVien, O.TenMonHoc from DIEM as D,MONHOC as O where D.MaMonHoc = O.MaMonHoc and MaSinhVien = '" + cbb_maSV.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items.Add(rdD["TenMonHoc"].ToString());
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }
            else
            {


                //đưa tên mh vào lvw
                strMH = "select * from MONHOC where MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdMH = new SqlCommand(strMH, conn);
                rdMH = cmdMH.ExecuteReader();
                while (rdMH.Read())
                {
                    lvwDiem.Items.Add(rdMH["TenMonHoc"].ToString());
                }
                rdMH.Close();

                //đưa điểm vào lvw
                strD = "select * from DIEM where MaSinhVien = '" + cbb_maSV.Text + "' and MaMonHoc = '" + cbb_maMH.Text + "'";
                cmdD = new SqlCommand(strD, conn);
                rdD = cmdD.ExecuteReader();
                while (rdD.Read())
                {
                    lvwDiem.Items[i].SubItems.Add(rdD["Diem"].ToString());
                    i++;
                }
                rdD.Close();
            }
        }

        private void lvwDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

