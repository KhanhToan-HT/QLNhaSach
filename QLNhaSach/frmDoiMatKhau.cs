using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaSach
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private void sbtnCapNhat_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, "");
            errorProvider1.SetError(txtConfirmPass, "");
            if(txtPassNew.Text.Length<8||!txtPassNew.Text.Any(char.IsDigit)||!txtPassNew.Text.Any(char.IsLower)||!txtPassNew.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtPassNew, "Mật khẩu mới tối thiểu 8 kí tự, gồm chữ số," + "in hoa, in thường.");
                return;
            }
            frmMain f = (frmMain)this.MdiParent;
        }

        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
