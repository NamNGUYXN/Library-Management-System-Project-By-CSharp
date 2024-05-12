﻿namespace PhanMemQuanLyThuVien_NamTuan
{
    partial class frmQLTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTacGia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblHometown = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCheckHometown = new System.Windows.Forms.Label();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radAuthorName = new System.Windows.Forms.RadioButton();
            this.radAuthorId = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.Color.White;
            this.radFemale.Location = new System.Drawing.Point(184, 135);
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
            this.radMale.Location = new System.Drawing.Point(102, 135);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(57, 20);
            this.radMale.TabIndex = 2;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 44);
            this.panel1.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(282, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ THÔNG TIN TÁC GIẢ";
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(102, 186);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(207, 22);
            this.txtHometown.TabIndex = 3;
            this.txtHometown.TextChanged += new System.EventHandler(this.txtHometown_TextChanged);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(102, 82);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(207, 22);
            this.txtAuthorName.TabIndex = 1;
            this.txtAuthorName.TextChanged += new System.EventHandler(this.txtAuthorName_TextChanged);
            this.txtAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorName_KeyPress);
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHometown.ForeColor = System.Drawing.Color.White;
            this.lblHometown.Location = new System.Drawing.Point(15, 189);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(73, 16);
            this.lblHometown.TabIndex = 0;
            this.lblHometown.Text = "Quê quán";
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
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(28, 137);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 16);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới tính";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.ForeColor = System.Drawing.Color.White;
            this.lblAuthorName.Location = new System.Drawing.Point(36, 85);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(52, 16);
            this.lblAuthorName.TabIndex = 0;
            this.lblAuthorName.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblCheckHometown);
            this.panel4.Controls.Add(this.lblCheckName);
            this.panel4.Controls.Add(this.txtAuthorId);
            this.panel4.Controls.Add(this.lblAuthorId);
            this.panel4.Controls.Add(this.radFemale);
            this.panel4.Controls.Add(this.radMale);
            this.panel4.Controls.Add(this.txtHometown);
            this.panel4.Controls.Add(this.txtAuthorName);
            this.panel4.Controls.Add(this.lblHometown);
            this.panel4.Controls.Add(this.lblGender);
            this.panel4.Controls.Add(this.lblAuthorName);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(683, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 533);
            this.panel4.TabIndex = 10;
            // 
            // lblCheckHometown
            // 
            this.lblCheckHometown.AutoSize = true;
            this.lblCheckHometown.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckHometown.Location = new System.Drawing.Point(99, 211);
            this.lblCheckHometown.Name = "lblCheckHometown";
            this.lblCheckHometown.Size = new System.Drawing.Size(0, 16);
            this.lblCheckHometown.TabIndex = 13;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCheckName.Location = new System.Drawing.Point(99, 107);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(0, 16);
            this.lblCheckName.TabIndex = 13;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Enabled = false;
            this.txtAuthorId.Location = new System.Drawing.Point(102, 30);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(207, 22);
            this.txtAuthorId.TabIndex = 5;
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorId.ForeColor = System.Drawing.Color.White;
            this.lblAuthorId.Location = new System.Drawing.Point(12, 33);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(79, 16);
            this.lblAuthorId.TabIndex = 4;
            this.lblAuthorId.Text = "Mã tác giả";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.radAuthorName);
            this.panel5.Controls.Add(this.radAuthorId);
            this.panel5.Location = new System.Drawing.Point(12, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 37);
            this.panel5.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(172, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radAuthorName
            // 
            this.radAuthorName.AutoSize = true;
            this.radAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAuthorName.ForeColor = System.Drawing.Color.White;
            this.radAuthorName.Location = new System.Drawing.Point(88, 8);
            this.radAuthorName.Name = "radAuthorName";
            this.radAuthorName.Size = new System.Drawing.Size(70, 20);
            this.radAuthorName.TabIndex = 6;
            this.radAuthorName.Text = "Họ tên";
            this.radAuthorName.UseVisualStyleBackColor = true;
            this.radAuthorName.CheckedChanged += new System.EventHandler(this.radAuthorName_CheckedChanged);
            // 
            // radAuthorId
            // 
            this.radAuthorId.AutoSize = true;
            this.radAuthorId.Checked = true;
            this.radAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAuthorId.ForeColor = System.Drawing.Color.White;
            this.radAuthorId.Location = new System.Drawing.Point(19, 8);
            this.radAuthorId.Name = "radAuthorId";
            this.radAuthorId.Size = new System.Drawing.Size(46, 20);
            this.radAuthorId.TabIndex = 6;
            this.radAuthorId.TabStop = true;
            this.radAuthorId.Text = "Mã";
            this.radAuthorId.UseVisualStyleBackColor = true;
            this.radAuthorId.CheckedChanged += new System.EventHandler(this.radAuthorId_CheckedChanged);
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
            this.MaTG,
            this.HoTenTG,
            this.GioiTinh,
            this.QueQuan});
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
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã";
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            // 
            // HoTenTG
            // 
            this.HoTenTG.DataPropertyName = "HoTenTG";
            this.HoTenTG.HeaderText = "Họ tên";
            this.HoTenTG.Name = "HoTenTG";
            this.HoTenTG.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê quán";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.txtQuantity);
            this.panel6.Location = new System.Drawing.Point(540, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 37);
            this.panel6.TabIndex = 20;
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
            // frmQLTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1022, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1038, 645);
            this.MinimumSize = new System.Drawing.Size(1038, 645);
            this.Name = "frmQLTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radAuthorName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RadioButton radAuthorId;
        private System.Windows.Forms.Label lblCheckHometown;
        private System.Windows.Forms.Label lblCheckName;
    }
}