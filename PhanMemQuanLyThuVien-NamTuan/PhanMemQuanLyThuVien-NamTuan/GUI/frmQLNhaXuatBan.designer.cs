namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmQLNhaXuatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhaXuatBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.panEnterInfo = new System.Windows.Forms.Panel();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.lblCheckPhone = new System.Windows.Forms.Label();
            this.lblCheckAddress = new System.Windows.Forms.Label();
            this.txtPublisherId = new System.Windows.Forms.TextBox();
            this.lblPublisherId = new System.Windows.Forms.Label();
            this.panSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radPhone = new System.Windows.Forms.RadioButton();
            this.radPublisherName = new System.Windows.Forms.RadioButton();
            this.radPublisherId = new System.Windows.Forms.RadioButton();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panDataList = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panFunction = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panQuantity = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panTitle.SuspendLayout();
            this.panEnterInfo.SuspendLayout();
            this.panSearch.SuspendLayout();
            this.panDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.panFunction.SuspendLayout();
            this.panQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 132);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 22);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.Teal;
            this.panTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Location = new System.Drawing.Point(12, 12);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(998, 44);
            this.panTitle.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(234, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN NHÀ XUẤT BẢN";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(96, 189);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(207, 22);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(96, 76);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(207, 22);
            this.txtPublisherName.TabIndex = 1;
            this.txtPublisherName.TextChanged += new System.EventHandler(this.txtPublisherName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(33, 135);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 16);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(50, 191);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(37, 16);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "SĐT";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherName.ForeColor = System.Drawing.Color.White;
            this.lblPublisherName.Location = new System.Drawing.Point(53, 79);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(34, 16);
            this.lblPublisherName.TabIndex = 0;
            this.lblPublisherName.Text = "Tên";
            // 
            // panEnterInfo
            // 
            this.panEnterInfo.BackColor = System.Drawing.Color.Teal;
            this.panEnterInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEnterInfo.Controls.Add(this.lblCheckName);
            this.panEnterInfo.Controls.Add(this.lblCheckPhone);
            this.panEnterInfo.Controls.Add(this.lblCheckAddress);
            this.panEnterInfo.Controls.Add(this.txtAddress);
            this.panEnterInfo.Controls.Add(this.txtPhone);
            this.panEnterInfo.Controls.Add(this.txtPublisherId);
            this.panEnterInfo.Controls.Add(this.txtPublisherName);
            this.panEnterInfo.Controls.Add(this.lblAddress);
            this.panEnterInfo.Controls.Add(this.lblPublisherId);
            this.panEnterInfo.Controls.Add(this.lblPhone);
            this.panEnterInfo.Controls.Add(this.lblPublisherName);
            this.panEnterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panEnterInfo.ForeColor = System.Drawing.Color.White;
            this.panEnterInfo.Location = new System.Drawing.Point(683, 62);
            this.panEnterInfo.Name = "panEnterInfo";
            this.panEnterInfo.Size = new System.Drawing.Size(327, 533);
            this.panEnterInfo.TabIndex = 10;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckName.Location = new System.Drawing.Point(93, 101);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(0, 16);
            this.lblCheckName.TabIndex = 13;
            // 
            // lblCheckPhone
            // 
            this.lblCheckPhone.AutoSize = true;
            this.lblCheckPhone.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckPhone.Location = new System.Drawing.Point(93, 214);
            this.lblCheckPhone.Name = "lblCheckPhone";
            this.lblCheckPhone.Size = new System.Drawing.Size(0, 16);
            this.lblCheckPhone.TabIndex = 13;
            // 
            // lblCheckAddress
            // 
            this.lblCheckAddress.AutoSize = true;
            this.lblCheckAddress.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckAddress.Location = new System.Drawing.Point(93, 157);
            this.lblCheckAddress.Name = "lblCheckAddress";
            this.lblCheckAddress.Size = new System.Drawing.Size(0, 16);
            this.lblCheckAddress.TabIndex = 13;
            // 
            // txtPublisherId
            // 
            this.txtPublisherId.Enabled = false;
            this.txtPublisherId.Location = new System.Drawing.Point(96, 20);
            this.txtPublisherId.Name = "txtPublisherId";
            this.txtPublisherId.Size = new System.Drawing.Size(207, 22);
            this.txtPublisherId.TabIndex = 1;
            // 
            // lblPublisherId
            // 
            this.lblPublisherId.AutoSize = true;
            this.lblPublisherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherId.ForeColor = System.Drawing.Color.White;
            this.lblPublisherId.Location = new System.Drawing.Point(25, 23);
            this.lblPublisherId.Name = "lblPublisherId";
            this.lblPublisherId.Size = new System.Drawing.Size(62, 16);
            this.lblPublisherId.TabIndex = 0;
            this.lblPublisherId.Text = "Mã NXB";
            // 
            // panSearch
            // 
            this.panSearch.BackColor = System.Drawing.Color.Teal;
            this.panSearch.Controls.Add(this.txtSearch);
            this.panSearch.Controls.Add(this.radPhone);
            this.panSearch.Controls.Add(this.radPublisherName);
            this.panSearch.Controls.Add(this.radPublisherId);
            this.panSearch.Location = new System.Drawing.Point(12, 153);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(522, 37);
            this.panSearch.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(233, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // radPhone
            // 
            this.radPhone.AutoSize = true;
            this.radPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPhone.ForeColor = System.Drawing.Color.White;
            this.radPhone.Location = new System.Drawing.Point(158, 8);
            this.radPhone.Name = "radPhone";
            this.radPhone.Size = new System.Drawing.Size(55, 20);
            this.radPhone.TabIndex = 6;
            this.radPhone.Text = "SĐT";
            this.radPhone.UseVisualStyleBackColor = true;
            this.radPhone.CheckedChanged += new System.EventHandler(this.radPhone_CheckedChanged);
            // 
            // radPublisherName
            // 
            this.radPublisherName.AutoSize = true;
            this.radPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPublisherName.ForeColor = System.Drawing.Color.White;
            this.radPublisherName.Location = new System.Drawing.Point(85, 8);
            this.radPublisherName.Name = "radPublisherName";
            this.radPublisherName.Size = new System.Drawing.Size(52, 20);
            this.radPublisherName.TabIndex = 6;
            this.radPublisherName.Text = "Tên";
            this.radPublisherName.UseVisualStyleBackColor = true;
            this.radPublisherName.CheckedChanged += new System.EventHandler(this.radPublisherName_CheckedChanged);
            // 
            // radPublisherId
            // 
            this.radPublisherId.AutoSize = true;
            this.radPublisherId.Checked = true;
            this.radPublisherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPublisherId.ForeColor = System.Drawing.Color.White;
            this.radPublisherId.Location = new System.Drawing.Point(18, 8);
            this.radPublisherId.Name = "radPublisherId";
            this.radPublisherId.Size = new System.Drawing.Size(46, 20);
            this.radPublisherId.TabIndex = 6;
            this.radPublisherId.TabStop = true;
            this.radPublisherId.Text = "Mã";
            this.radPublisherId.UseVisualStyleBackColor = true;
            this.radPublisherId.CheckedChanged += new System.EventHandler(this.radPublisherId_CheckedChanged);
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
            // panDataList
            // 
            this.panDataList.Controls.Add(this.dgvDataList);
            this.panDataList.Location = new System.Drawing.Point(12, 196);
            this.panDataList.Name = "panDataList";
            this.panDataList.Size = new System.Drawing.Size(665, 399);
            this.panDataList.TabIndex = 15;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChi,
            this.SDT});
            this.dgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataList.GridColor = System.Drawing.Color.Black;
            this.dgvDataList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDataList.Location = new System.Drawing.Point(0, 0);
            this.dgvDataList.MultiSelect = false;
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersVisible = false;
            this.dgvDataList.RowHeadersWidth = 62;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(665, 399);
            this.dgvDataList.TabIndex = 10;
            this.dgvDataList.TabStop = false;
            this.dgvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellClick);
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.MinimumWidth = 8;
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.MinimumWidth = 8;
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // panFunction
            // 
            this.panFunction.BackColor = System.Drawing.Color.Teal;
            this.panFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFunction.Controls.Add(this.btnAdd);
            this.panFunction.Controls.Add(this.btnDelete);
            this.panFunction.Controls.Add(this.btnUpdate);
            this.panFunction.Controls.Add(this.btnReset);
            this.panFunction.Controls.Add(this.btnBack);
            this.panFunction.Location = new System.Drawing.Point(12, 62);
            this.panFunction.Name = "panFunction";
            this.panFunction.Size = new System.Drawing.Size(665, 85);
            this.panFunction.TabIndex = 18;
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
            // panQuantity
            // 
            this.panQuantity.BackColor = System.Drawing.Color.Teal;
            this.panQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panQuantity.Controls.Add(this.lblQuantity);
            this.panQuantity.Controls.Add(this.txtQuantity);
            this.panQuantity.Location = new System.Drawing.Point(540, 153);
            this.panQuantity.Name = "panQuantity";
            this.panQuantity.Size = new System.Drawing.Size(137, 37);
            this.panQuantity.TabIndex = 20;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(3, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 8);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(53, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // frmQLNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panQuantity);
            this.Controls.Add(this.panFunction);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.panDataList);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.panEnterInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmQLNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà xuất bản";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.panEnterInfo.ResumeLayout(false);
            this.panEnterInfo.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.panDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.panFunction.ResumeLayout(false);
            this.panQuantity.ResumeLayout(false);
            this.panQuantity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.Panel panEnterInfo;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radPublisherName;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panDataList;
        private System.Windows.Forms.Panel panFunction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.TextBox txtPublisherId;
        private System.Windows.Forms.Label lblPublisherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Panel panQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RadioButton radPublisherId;
        private System.Windows.Forms.RadioButton radPhone;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.Label lblCheckPhone;
        private System.Windows.Forms.Label lblCheckAddress;
    }
}