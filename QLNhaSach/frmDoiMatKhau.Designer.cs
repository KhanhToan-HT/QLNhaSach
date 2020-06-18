namespace QLNhaSach
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.txtNhapMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.sbtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnKhong = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(37, 36);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(131, 19);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Nhập mật khẩu mới:";
            // 
            // txtNhapMatKhauMoi
            // 
            this.txtNhapMatKhauMoi.Location = new System.Drawing.Point(185, 37);
            this.txtNhapMatKhauMoi.Name = "txtNhapMatKhauMoi";
            this.txtNhapMatKhauMoi.Size = new System.Drawing.Size(174, 20);
            this.txtNhapMatKhauMoi.TabIndex = 1;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(185, 75);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(174, 20);
            this.txtNhapLaiMatKhau.TabIndex = 1;
            // 
            // sbtnCapNhat
            // 
            this.sbtnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.sbtnCapNhat.Location = new System.Drawing.Point(95, 122);
            this.sbtnCapNhat.Name = "sbtnCapNhat";
            this.sbtnCapNhat.Size = new System.Drawing.Size(93, 39);
            this.sbtnCapNhat.TabIndex = 2;
            this.sbtnCapNhat.Text = "Cập Nhật";
            // 
            // sbtnKhong
            // 
            this.sbtnKhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.sbtnKhong.Location = new System.Drawing.Point(214, 122);
            this.sbtnKhong.Name = "sbtnKhong";
            this.sbtnKhong.Size = new System.Drawing.Size(93, 39);
            this.sbtnKhong.TabIndex = 2;
            this.sbtnKhong.Text = "Không";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 212);
            this.Controls.Add(this.sbtnKhong);
            this.Controls.Add(this.sbtnCapNhat);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtNhapMatKhauMoi);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label2);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txtNhapMatKhauMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private DevExpress.XtraEditors.SimpleButton sbtnCapNhat;
        private DevExpress.XtraEditors.SimpleButton sbtnKhong;
    }
}