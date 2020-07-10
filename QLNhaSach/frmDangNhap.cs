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
    public partial class frmDangNhap : Form
    {
        XLNHANVIEN tblNhanVien;
        frmMain fMain = null;
        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }
        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(int)Keys.Enter)
            {
                btnDangNhap_Click(sender,e);
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DataRow[] r = tblNhanVien.Select("Username='" + txtUserName.Text + "' and Password ='" + txtPassword.Text + "'");
            if(r.Count()>0)
            {
                fMain.Text = "Quản lý Nhà Sách - Chào" + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                fMain.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
