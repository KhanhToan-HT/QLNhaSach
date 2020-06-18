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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.sbtnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(185, 37);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(174, 20);
            this.txtPassNew.TabIndex = 1;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(185, 75);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(174, 20);
            this.txtConfirmPass.TabIndex = 1;
            // 
            // sbtnCapNhat
            // 
            this.sbtnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnCapNhat.ImageOptions.Image")));
            this.sbtnCapNhat.Location = new System.Drawing.Point(95, 122);
            this.sbtnCapNhat.Name = "sbtnCapNhat";
            this.sbtnCapNhat.Size = new System.Drawing.Size(93, 39);
            this.sbtnCapNhat.TabIndex = 2;
            this.sbtnCapNhat.Text = "Cập Nhật";
            this.sbtnCapNhat.Click += new System.EventHandler(this.sbtnCapNhat_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnKhong.ImageOptions.Image")));
            this.sbtnCancel.Location = new System.Drawing.Point(214, 122);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(93, 39);
            this.sbtnCancel.TabIndex = 2;
            this.sbtnCancel.Text = "Không";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 212);
            this.Controls.Add(this.sbtnCancel);
            this.Controls.Add(this.sbtnCapNhat);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label2);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private DevExpress.XtraEditors.SimpleButton sbtnCapNhat;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}