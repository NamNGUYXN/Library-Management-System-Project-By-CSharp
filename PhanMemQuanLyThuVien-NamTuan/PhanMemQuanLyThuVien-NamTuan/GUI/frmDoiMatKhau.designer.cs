namespace GUI
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
            this.panPresentPassword = new System.Windows.Forms.Panel();
            this.txtPresentPassword = new System.Windows.Forms.TextBox();
            this.lblPresentPassword = new System.Windows.Forms.Label();
            this.panNewPassword = new System.Windows.Forms.Panel();
            this.lblAgainNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtAgainNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panFunction = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panPresentPassword.SuspendLayout();
            this.panNewPassword.SuspendLayout();
            this.panFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPresentPassword
            // 
            this.panPresentPassword.BackColor = System.Drawing.Color.Teal;
            this.panPresentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPresentPassword.Controls.Add(this.txtPresentPassword);
            this.panPresentPassword.Controls.Add(this.lblPresentPassword);
            this.panPresentPassword.Location = new System.Drawing.Point(12, 72);
            this.panPresentPassword.Name = "panPresentPassword";
            this.panPresentPassword.Size = new System.Drawing.Size(400, 51);
            this.panPresentPassword.TabIndex = 0;
            // 
            // txtPresentPassword
            // 
            this.txtPresentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentPassword.Location = new System.Drawing.Point(201, 15);
            this.txtPresentPassword.Name = "txtPresentPassword";
            this.txtPresentPassword.PasswordChar = '*';
            this.txtPresentPassword.Size = new System.Drawing.Size(181, 22);
            this.txtPresentPassword.TabIndex = 1;
            // 
            // lblPresentPassword
            // 
            this.lblPresentPassword.AutoSize = true;
            this.lblPresentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentPassword.ForeColor = System.Drawing.Color.White;
            this.lblPresentPassword.Location = new System.Drawing.Point(15, 18);
            this.lblPresentPassword.Name = "lblPresentPassword";
            this.lblPresentPassword.Size = new System.Drawing.Size(164, 16);
            this.lblPresentPassword.TabIndex = 0;
            this.lblPresentPassword.Text = "Nhập mật khẩu hiện tại";
            // 
            // panNewPassword
            // 
            this.panNewPassword.BackColor = System.Drawing.Color.Teal;
            this.panNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panNewPassword.Controls.Add(this.lblAgainNewPassword);
            this.panNewPassword.Controls.Add(this.lblNewPassword);
            this.panNewPassword.Controls.Add(this.txtAgainNewPassword);
            this.panNewPassword.Controls.Add(this.txtNewPassword);
            this.panNewPassword.Location = new System.Drawing.Point(12, 129);
            this.panNewPassword.Name = "panNewPassword";
            this.panNewPassword.Size = new System.Drawing.Size(400, 88);
            this.panNewPassword.TabIndex = 0;
            // 
            // lblAgainNewPassword
            // 
            this.lblAgainNewPassword.AutoSize = true;
            this.lblAgainNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgainNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblAgainNewPassword.Location = new System.Drawing.Point(15, 52);
            this.lblAgainNewPassword.Name = "lblAgainNewPassword";
            this.lblAgainNewPassword.Size = new System.Drawing.Size(160, 16);
            this.lblAgainNewPassword.TabIndex = 2;
            this.lblAgainNewPassword.Text = "Nhập lại mật khẩu mới";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(15, 13);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(139, 16);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "Nhập mật khẩu mới";
            // 
            // txtAgainNewPassword
            // 
            this.txtAgainNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgainNewPassword.Location = new System.Drawing.Point(201, 51);
            this.txtAgainNewPassword.Name = "txtAgainNewPassword";
            this.txtAgainNewPassword.PasswordChar = '*';
            this.txtAgainNewPassword.Size = new System.Drawing.Size(181, 22);
            this.txtAgainNewPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(201, 12);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(181, 22);
            this.txtNewPassword.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ImageIndex = 2;
            this.btnChange.ImageList = this.imgIcon;
            this.btnChange.Location = new System.Drawing.Point(9, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(115, 40);
            this.btnChange.TabIndex = 4;
            this.btnChange.TabStop = false;
            this.btnChange.Text = "Đổi";
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "back-icon.png");
            this.imgIcon.Images.SetKeyName(1, "close-icon.png");
            this.imgIcon.Images.SetKeyName(2, "check-icon.png");
            // 
            // panFunction
            // 
            this.panFunction.BackColor = System.Drawing.Color.Teal;
            this.panFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFunction.Controls.Add(this.chkShowPassword);
            this.panFunction.Controls.Add(this.btnBack);
            this.panFunction.Controls.Add(this.btnChange);
            this.panFunction.Location = new System.Drawing.Point(12, 12);
            this.panFunction.Name = "panFunction";
            this.panFunction.Size = new System.Drawing.Size(400, 54);
            this.panFunction.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword.Location = new System.Drawing.Point(278, 25);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(118, 21);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.TabStop = false;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageIndex = 0;
            this.btnBack.ImageList = this.imgIcon;
            this.btnBack.Location = new System.Drawing.Point(130, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(424, 229);
            this.ControlBox = false;
            this.Controls.Add(this.panNewPassword);
            this.Controls.Add(this.panFunction);
            this.Controls.Add(this.panPresentPassword);
            this.MaximumSize = new System.Drawing.Size(440, 268);
            this.MinimumSize = new System.Drawing.Size(440, 268);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panPresentPassword.ResumeLayout(false);
            this.panPresentPassword.PerformLayout();
            this.panNewPassword.ResumeLayout(false);
            this.panNewPassword.PerformLayout();
            this.panFunction.ResumeLayout(false);
            this.panFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPresentPassword;
        private System.Windows.Forms.TextBox txtPresentPassword;
        private System.Windows.Forms.Label lblPresentPassword;
        private System.Windows.Forms.Panel panNewPassword;
        private System.Windows.Forms.Label lblAgainNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtAgainNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panFunction;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}