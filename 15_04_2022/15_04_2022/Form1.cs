using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_04_2022
{
    public partial class fQLSV : Form
    {
        private Form currentChildForm;
        public fQLSV()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false; //hiện lên đầu
            childForm.FormBorderStyle = FormBorderStyle.None; //tắt đường viền
            childForm.Dock = DockStyle.Fill;
            pn_Form.Controls.Add(childForm);//form con nằm trong menu
            pn_Form.Tag = childForm;//panel và childe form nằm cùng tag
            childForm.BringToFront();
            childForm.Show();
        }
        private void mnCapNhatKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCapNhatKhoa());
        }

        private void mnCapNhatLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCapNhatLop());
        }

        private void mnCapNhatMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCapNhatMonHoc());
        }

        private void mnCapNhatSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCapNhatSinhVien());
        }

        private void mnCapNhatDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCapNhatDiem());
        }
        private void mnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thoat == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
