using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        frmDoiMatKhau frmDoiMatKhau;
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
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            //f.ShowDialog();
            f.Show();
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
            if(frmDoiMatKhau==null)
            {
                frmDoiMatKhau = new frmDoiMatKhau();
                frmDoiMatKhau.MdiParent = this;
                frmDoiMatKhau.WindowState = FormWindowState.Maximized;
                frmDoiMatKhau.Show();
            }
            else
            {
                frmDoiMatKhau.Activate();
                frmDoiMatKhau.Show();
            }
        }
    }
}
