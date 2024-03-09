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
    public partial class frm_QuanLyNhanVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from NHANVIEN";
            int sosv = (int)lopchung.LayGT(sql);
            txt_SoSV.Text = sosv.ToString();
        }
        public void LoadNV()
        {

            string sql = "Select * from NHANVIEN";
            dt_NhanVien.DataSource = lopchung.LoadDL(sql);
        }
        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void dt_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dt_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_HoTen.Text = dt_NhanVien.CurrentRow.Cells["Hoten"].Value.ToString();
            txt_DiaChi.Text = dt_NhanVien.CurrentRow.Cells["Diachi"].Value.ToString();
            dt_ngaysinh.Text = dt_NhanVien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values ('" + txt_MaNV.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "',Convert(datetime,'" + dt_ngaysinh.Text + "',103))";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm nhân viên thất bại");
            LoadNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NHANVIEN where MaNV = '" + txt_MaNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Xoá nhân viên thành công");
            else MessageBox.Show("Xoá nhân viên thất bại");
            LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NHANVIEN set Hoten = N'" + txt_HoTen.Text + "',Diachi = N'" + txt_DiaChi.Text + "',Ngaysinh = Convert(datetime,'" + dt_ngaysinh.Text + "',103) where MaNV ='" + txt_MaNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            LoadNV();
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
