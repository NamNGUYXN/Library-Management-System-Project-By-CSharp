namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTaiKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblCheckPassword = new System.Windows.Forms.Label();
            this.lblCheckPhone = new System.Windows.Forms.Label();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLibrarianId = new System.Windows.Forms.TextBox();
            this.txtLibrarianName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLibrarianId = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radPhone = new System.Windows.Forms.RadioButton();
            this.radLibrarianName = new System.Windows.Forms.RadioButton();
            this.radLibrarianId = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(276, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(444, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN THỦ THƯ";
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "add-icon.png");
            this.imgIcon.Images.SetKeyName(1, "back-icon.png");
            this.imgIcon.Images.SetKeyName(2, "delete-icon.png");
            this.imgIcon.Images.SetKeyName(3, "edit-icon.png");
            this.imgIcon.Images.SetKeyName(4, "reset-icon.png");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chkShowPassword);
            this.panel4.Controls.Add(this.lblCheckPassword);
            this.panel4.Controls.Add(this.lblCheckPhone);
            this.panel4.Controls.Add(this.lblCheckName);
            this.panel4.Controls.Add(this.dtpBirth);
            this.panel4.Controls.Add(this.radFemale);
            this.panel4.Controls.Add(this.radMale);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.txtLibrarianId);
            this.panel4.Controls.Add(this.txtLibrarianName);
            this.panel4.Controls.Add(this.lblPassword);
            this.panel4.Controls.Add(this.lblPhone);
            this.panel4.Controls.Add(this.lblGender);
            this.panel4.Controls.Add(this.lblLibrarianId);
            this.panel4.Controls.Add(this.lblBirth);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(683, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 533);
            this.panel4.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword.Location = new System.Drawing.Point(103, 345);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(118, 21);
            this.chkShowPassword.TabIndex = 13;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblCheckPassword
            // 
            this.lblCheckPassword.AutoSize = true;
            this.lblCheckPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckPassword.Location = new System.Drawing.Point(100, 368);
            this.lblCheckPassword.Name = "lblCheckPassword";
            this.lblCheckPassword.Size = new System.Drawing.Size(0, 16);
            this.lblCheckPassword.TabIndex = 12;
            // 
            // lblCheckPhone
            // 
            this.lblCheckPhone.AutoSize = true;
            this.lblCheckPhone.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckPhone.Location = new System.Drawing.Point(100, 283);
            this.lblCheckPhone.Name = "lblCheckPhone";
            this.lblCheckPhone.Size = new System.Drawing.Size(0, 16);
            this.lblCheckPhone.TabIndex = 12;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckName.Location = new System.Drawing.Point(100, 112);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(0, 16);
            this.lblCheckName.TabIndex = 11;
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(103, 142);
            this.dtpBirth.MaxDate = new System.DateTime(9998, 1, 1, 0, 0, 0, 0);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(207, 22);
            this.dtpBirth.TabIndex = 2;
            this.dtpBirth.Value = new System.DateTime(2024, 5, 7, 0, 0, 0, 0);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.Color.White;
            this.radFemale.Location = new System.Drawing.Point(185, 202);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(44, 20);
            this.radFemale.TabIndex = 3;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.ForeColor = System.Drawing.Color.White;
            this.radMale.Location = new System.Drawing.Point(103, 202);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 20);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 318);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(103, 258);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(207, 22);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtLibrarianId
            // 
            this.txtLibrarianId.Enabled = false;
            this.txtLibrarianId.Location = new System.Drawing.Point(103, 30);
            this.txtLibrarianId.Name = "txtLibrarianId";
            this.txtLibrarianId.ReadOnly = true;
            this.txtLibrarianId.Size = new System.Drawing.Size(207, 22);
            this.txtLibrarianId.TabIndex = 1;
            // 
            // txtLibrarianName
            // 
            this.txtLibrarianName.Location = new System.Drawing.Point(103, 87);
            this.txtLibrarianName.Name = "txtLibrarianName";
            this.txtLibrarianName.Size = new System.Drawing.Size(207, 22);
            this.txtLibrarianName.TabIndex = 1;
            this.txtLibrarianName.TextChanged += new System.EventHandler(this.txtLibrarianName_TextChanged);
            this.txtLibrarianName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLibrarianName_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(24, 321);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(47, 261);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(37, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "SĐT";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(29, 204);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 16);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới tính";
            // 
            // lblLibrarianId
            // 
            this.lblLibrarianId.AutoSize = true;
            this.lblLibrarianId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianId.ForeColor = System.Drawing.Color.White;
            this.lblLibrarianId.Location = new System.Drawing.Point(16, 33);
            this.lblLibrarianId.Name = "lblLibrarianId";
            this.lblLibrarianId.Size = new System.Drawing.Size(76, 16);
            this.lblLibrarianId.TabIndex = 0;
            this.lblLibrarianId.Text = "Mã thủ thư";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.ForeColor = System.Drawing.Color.White;
            this.lblBirth.Location = new System.Drawing.Point(22, 147);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(76, 16);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "Ngày sinh";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(37, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.radPhone);
            this.panel5.Controls.Add(this.radLibrarianName);
            this.panel5.Controls.Add(this.radLibrarianId);
            this.panel5.Location = new System.Drawing.Point(12, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 37);
            this.panel5.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(266, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radPhone
            // 
            this.radPhone.AutoSize = true;
            this.radPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPhone.ForeColor = System.Drawing.Color.White;
            this.radPhone.Location = new System.Drawing.Point(171, 8);
            this.radPhone.Name = "radPhone";
            this.radPhone.Size = new System.Drawing.Size(55, 20);
            this.radPhone.TabIndex = 6;
            this.radPhone.Text = "SĐT";
            this.radPhone.UseVisualStyleBackColor = true;
            this.radPhone.CheckedChanged += new System.EventHandler(this.radPhone_CheckedChanged);
            // 
            // radLibrarianName
            // 
            this.radLibrarianName.AutoSize = true;
            this.radLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLibrarianName.ForeColor = System.Drawing.Color.White;
            this.radLibrarianName.Location = new System.Drawing.Point(82, 8);
            this.radLibrarianName.Name = "radLibrarianName";
            this.radLibrarianName.Size = new System.Drawing.Size(70, 20);
            this.radLibrarianName.TabIndex = 6;
            this.radLibrarianName.Text = "Họ tên";
            this.radLibrarianName.UseVisualStyleBackColor = true;
            this.radLibrarianName.CheckedChanged += new System.EventHandler(this.radLibrarianName_CheckedChanged);
            // 
            // radLibrarianId
            // 
            this.radLibrarianId.AutoSize = true;
            this.radLibrarianId.Checked = true;
            this.radLibrarianId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLibrarianId.ForeColor = System.Drawing.Color.White;
            this.radLibrarianId.Location = new System.Drawing.Point(17, 8);
            this.radLibrarianId.Name = "radLibrarianId";
            this.radLibrarianId.Size = new System.Drawing.Size(46, 20);
            this.radLibrarianId.TabIndex = 6;
            this.radLibrarianId.TabStop = true;
            this.radLibrarianId.Text = "Mã";
            this.radLibrarianId.UseVisualStyleBackColor = true;
            this.radLibrarianId.CheckedChanged += new System.EventHandler(this.radLibrarianId_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.txtQuantity);
            this.panel6.Location = new System.Drawing.Point(518, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 37);
            this.panel6.TabIndex = 16;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(3, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 7);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(77, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDataList);
            this.panel3.Location = new System.Drawing.Point(12, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 399);
            this.panel3.TabIndex = 15;
            // 
            // dgvDataList
            // 
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.AllowUserToDeleteRows = false;
            this.dgvDataList.AllowUserToResizeColumns = false;
            this.dgvDataList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataList.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT});
            this.dgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataList.GridColor = System.Drawing.Color.Black;
            this.dgvDataList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDataList.Location = new System.Drawing.Point(0, 0);
            this.dgvDataList.MultiSelect = false;
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersVisible = false;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(665, 399);
            this.dgvDataList.TabIndex = 10;
            this.dgvDataList.TabStop = false;
            this.dgvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellClick);
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã";
            this.MaTK.Name = "MaTK";
            this.MaTK.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 85);
            this.panel2.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imgIcon;
            this.btnAdd.Location = new System.Drawing.Point(3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 72);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imgIcon;
            this.btnDelete.Location = new System.Drawing.Point(87, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 72);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageIndex = 3;
            this.btnUpdate.ImageList = this.imgIcon;
            this.btnUpdate.Location = new System.Drawing.Point(171, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 72);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageIndex = 4;
            this.btnReset.ImageList = this.imgIcon;
            this.btnReset.Location = new System.Drawing.Point(255, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 72);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imgIcon;
            this.btnBack.Location = new System.Drawing.Point(339, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 72);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Trở lại";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmQLTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmQLTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thủ thư";
            this.Load += new System.EventHandler(this.frmThuThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLibrarianName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radLibrarianName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.TextBox txtLibrarianId;
        private System.Windows.Forms.Label lblLibrarianId;
        private System.Windows.Forms.RadioButton radLibrarianId;
        private System.Windows.Forms.RadioButton radPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.Label lblCheckPhone;
        private System.Windows.Forms.Label lblCheckPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}