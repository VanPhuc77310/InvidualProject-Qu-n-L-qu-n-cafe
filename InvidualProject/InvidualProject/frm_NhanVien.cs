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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            for (int i = Lib_Menu.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_DsKhachOrder.Items.Add(Lib_Menu.SelectedItems[i]);
                Lib_Menu.Items.Remove(Lib_Menu.SelectedItems[i]);
            }
            Lib_DsKhachOrder.Sorted = true;
            Lib_Menu.Sorted = true;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lib_Menu.Items.Count; i++)
            {
                Lib_DsKhachOrder.Items.Add(Lib_Menu.Items[i]);
            }
            Lib_Menu.Items.Clear();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            for (int i = Lib_DsKhachOrder.SelectedItems.Count - 1; i >= 0; i--)
            {
                Lib_Menu.Items.Add(Lib_DsKhachOrder.SelectedItems[i]);
                Lib_DsKhachOrder.Items.Remove(Lib_DsKhachOrder.SelectedItems[i]);
            }
            Lib_DsKhachOrder.Sorted = true;
            Lib_Menu.Sorted = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lib_DsKhachOrder.Items.Count; i++)
            {
                Lib_Menu.Items.Add(Lib_DsKhachOrder.Items[i]);
            }
            Lib_DsKhachOrder.Items.Clear();
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
