using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvidualProject
{
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int dem = 0;

        private void btn_QLDangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from ManagerAccount where UsernameManager ='" + txt_TaiKhoan.Text + "' and PasswordManager = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.LayGT(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_QuanLyNhanVien ql = new frm_QuanLyNhanVien();
                ql.Show();
            }
            else MessageBox.Show("Sai tên hoặc mật khẩu, đăng nhập thất bại");
        }

        private void ck_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_HienThiMatKhau.Checked == true)
                txt_MatKhau.UseSystemPasswordChar = false;
            else txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_nvDangNhap_Click(object sender, EventArgs e)
        {
            string sql1 = "Select COUNT (*) from StaffAccount where UsernameStaff ='" + txt_TaiKhoan.Text + "' and PasswordStaff = '" + txt_MatKhau.Text + "'";
            int kq1 = (int)lopchung.LayGT(sql1);
            if (kq1 >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_NhanVien nv = new frm_NhanVien();
                nv.Show();
            }
            else MessageBox.Show("Sai tên hoặc mật khẩu, đăng nhập thất bại");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
