using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using QLNhaSach.Modules;

namespace QLNhaSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string maNV;
        public void enableControl(int maLTK)
        {
            switch(maLTK)
            {
                case 1://admin
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
                case 2://Nhan vien ban hang
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
                case 3://Nhan viên quản lý kho
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
                default:
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnLoaiSanPham.Enabled = true;
                    btnSanPham.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnThongKe.Enabled = true;
                    break;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmDangNhap f = new frmDangNhap(this);
            f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
            f.ShowDialog();
            f.WindowState = FormWindowState.Normal;

            //tabControl1.Hide();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //xu lý tất cả cac form con
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            frmMain_Load(sender, e);
        }

        private void btnDoiMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControlMain.TabPages.IndexOfKey("tabPageDoiMatKhau");
            if (index > 0)
                tabControlMain.SelectedIndex = index;
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDoiMatKhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                tabControlMain.SelectedTab=p;
                f.Show();
            }
        }
    }
}
