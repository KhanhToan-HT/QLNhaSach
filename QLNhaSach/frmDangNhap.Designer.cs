namespace QLNhaSach
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sbtnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.sbtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // sbtnDangNhap
            // 
            this.sbtnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnDangNhap.ImageOptions.Image")));
            this.sbtnDangNhap.Location = new System.Drawing.Point(94, 140);
            this.sbtnDangNhap.Name = "sbtnDangNhap";
            this.sbtnDangNhap.Size = new System.Drawing.Size(100, 37);
            this.sbtnDangNhap.TabIndex = 1;
            this.sbtnDangNhap.Text = "Đăng Nhập";
            this.sbtnDangNhap.Click += new System.EventHandler(this.sbtnDangNhap_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(205, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(175, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // sbtnThoat
            // 
            this.sbtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThoat.ImageOptions.Image")));
            this.sbtnThoat.Location = new System.Drawing.Point(231, 140);
            this.sbtnThoat.Name = "sbtnThoat";
            this.sbtnThoat.Size = new System.Drawing.Size(100, 37);
            this.sbtnThoat.TabIndex = 1;
            this.sbtnThoat.Text = "Thoát";
            this.sbtnThoat.Click += new System.EventHandler(this.sbtnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 235);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.sbtnThoat);
            this.Controls.Add(this.sbtnDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Enter += new System.EventHandler(this.frmDangNhap_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDangNhap_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton sbtnDangNhap;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.SimpleButton sbtnThoat;
    }
}

