namespace GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picKey = new System.Windows.Forms.PictureBox();
            this.panTitle = new System.Windows.Forms.Panel();
            this.panKey = new System.Windows.Forms.Panel();
            this.panLogin = new System.Windows.Forms.Panel();
            this.lblCheckPassword = new System.Windows.Forms.Label();
            this.lblCheckUsername = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLibrarianId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblLibrarianId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).BeginInit();
            this.panTitle.SuspendLayout();
            this.panKey.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(139, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // picKey
            // 
            this.picKey.Image = ((System.Drawing.Image)(resources.GetObject("picKey.Image")));
            this.picKey.InitialImage = null;
            this.picKey.Location = new System.Drawing.Point(7, 32);
            this.picKey.Margin = new System.Windows.Forms.Padding(2);
            this.picKey.Name = "picKey";
            this.picKey.Size = new System.Drawing.Size(135, 140);
            this.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKey.TabIndex = 1;
            this.picKey.TabStop = false;
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.Teal;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(12, 12);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(431, 42);
            this.panTitle.TabIndex = 8;
            // 
            // panKey
            // 
            this.panKey.BackColor = System.Drawing.Color.Teal;
            this.panKey.Controls.Add(this.picKey);
            this.panKey.Location = new System.Drawing.Point(12, 60);
            this.panKey.Name = "panKey";
            this.panKey.Size = new System.Drawing.Size(149, 204);
            this.panKey.TabIndex = 9;
            // 
            // panLogin
            // 
            this.panLogin.BackColor = System.Drawing.Color.Teal;
            this.panLogin.Controls.Add(this.lblCheckPassword);
            this.panLogin.Controls.Add(this.lblCheckUsername);
            this.panLogin.Controls.Add(this.chkShowPassword);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.txtLibrarianId);
            this.panLogin.Controls.Add(this.lblPassword);
            this.panLogin.Controls.Add(this.btnThoat);
            this.panLogin.Controls.Add(this.btnDangNhap);
            this.panLogin.Controls.Add(this.lblLibrarianId);
            this.panLogin.Location = new System.Drawing.Point(167, 60);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(276, 204);
            this.panLogin.TabIndex = 10;
            // 
            // lblCheckPassword
            // 
            this.lblCheckPassword.AutoSize = true;
            this.lblCheckPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckPassword.Location = new System.Drawing.Point(103, 81);
            this.lblCheckPassword.Name = "lblCheckPassword";
            this.lblCheckPassword.Size = new System.Drawing.Size(0, 13);
            this.lblCheckPassword.TabIndex = 12;
            // 
            // lblCheckUsername
            // 
            this.lblCheckUsername.AutoSize = true;
            this.lblCheckUsername.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckUsername.Location = new System.Drawing.Point(103, 37);
            this.lblCheckUsername.Name = "lblCheckUsername";
            this.lblCheckUsername.Size = new System.Drawing.Size(0, 13);
            this.lblCheckUsername.TabIndex = 12;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword.Location = new System.Drawing.Point(15, 96);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(118, 21);
            this.chkShowPassword.TabIndex = 3;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(105, 56);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtLibrarianId
            // 
            this.txtLibrarianId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibrarianId.Location = new System.Drawing.Point(105, 12);
            this.txtLibrarianId.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibrarianId.Name = "txtLibrarianId";
            this.txtLibrarianId.Size = new System.Drawing.Size(160, 23);
            this.txtLibrarianId.TabIndex = 1;
            this.txtLibrarianId.TextChanged += new System.EventHandler(this.txtLibrarianId_TextChanged);
            this.txtLibrarianId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLibrarianId_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(35, 57);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageIndex = 1;
            this.btnThoat.ImageList = this.imgIcon;
            this.btnThoat.Location = new System.Drawing.Point(168, 145);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 47);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "check-icon.png");
            this.imgIcon.Images.SetKeyName(1, "close-icon.png");
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ImageIndex = 0;
            this.btnDangNhap.ImageList = this.imgIcon;
            this.btnDangNhap.Location = new System.Drawing.Point(47, 145);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(97, 47);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblLibrarianId
            // 
            this.lblLibrarianId.AutoSize = true;
            this.lblLibrarianId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianId.ForeColor = System.Drawing.Color.White;
            this.lblLibrarianId.Location = new System.Drawing.Point(12, 15);
            this.lblLibrarianId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibrarianId.Name = "lblLibrarianId";
            this.lblLibrarianId.Size = new System.Drawing.Size(89, 17);
            this.lblLibrarianId.TabIndex = 11;
            this.lblLibrarianId.Text = "Mã tài khoản";
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(455, 276);
            this.ControlBox = false;
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panKey);
            this.Controls.Add(this.panTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 315);
            this.MinimumSize = new System.Drawing.Size(471, 315);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).EndInit();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panKey.ResumeLayout(false);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picKey;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Panel panKey;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLibrarianId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblLibrarianId;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Label lblCheckPassword;
        private System.Windows.Forms.Label lblCheckUsername;
    }
}

