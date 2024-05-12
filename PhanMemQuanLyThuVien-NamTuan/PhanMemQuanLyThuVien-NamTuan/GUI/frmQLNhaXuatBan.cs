﻿using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLNhaXuatBan : Form
    {
        public frmQLNhaXuatBan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisplayNextPublisherId()
        {
            txtPublisherId.Text = NhaXuatBanBUS.CreateNextId();
        }

        void DisplayPublisher(DataTable data = null, string query = null)
        {
            if (data == null) data = NhaXuatBanBUS.GetData();
            if (query != null) data = NhaXuatBanBUS.GetData(query);

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            // Hiện dữ liệu nhà xuất bản vào DataGridView
            DisplayPublisher();
            // Hiện mã nhà xuất bản kế tiếp
            DisplayNextPublisherId();
            // Hiện lời nhắc dưới ô nhập
            lblCheckName.Text = "Vui lòng nhập tên!";
            lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            lblCheckPhone.Text = "Vui lòng nhập SĐT!";
        }

        // Sự kiện xảy ra khi chọn vào 1 dòng dữ liệu trong DataGridView
        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaNXB, TenNXB, DiaChi, SDT;
                MaNXB = dgvDataList.CurrentRow.Cells["MaNXB"].Value.ToString();
                TenNXB = dgvDataList.CurrentRow.Cells["TenNXB"].Value.ToString();
                DiaChi = dgvDataList.CurrentRow.Cells["DiaChi"].Value.ToString();
                SDT = dgvDataList.CurrentRow.Cells["SDT"].Value.ToString();

                txtPublisherId.Text = MaNXB;
                txtPublisherName.Text = TenNXB;
                txtAddress.Text = DiaChi;
                txtPhone.Text = SDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        // Chọn tìm theo mã
        private void radPublisherId_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = NhaXuatBanBUS.SearchData("MaNXB", txtSearch.Text);
            DisplayPublisher(data);
        }

        // Chọn tìm theo tên
        private void radPublisherName_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = NhaXuatBanBUS.SearchData("TenNXB", txtSearch.Text);
            DisplayPublisher(data);
        }

        // Chọn tìm theo SĐT
        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = NhaXuatBanBUS.SearchData("SDT", txtSearch.Text);
            DisplayPublisher(data);
        }

        // Sự kiện xảy ra khi nội dung tìm thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radPublisherId.Checked)
                radPublisherId_CheckedChanged(sender, e);
            else if (radPublisherName.Checked)
                radPublisherName_CheckedChanged(sender, e);
            else
                radPhone_CheckedChanged(sender, e);
        }

        // Reset form
        void ResetAll()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayNextPublisherId();
            DisplayPublisher();
            txtPublisherName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }    

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        // Ngăn ko cho nhập nội dung tìm kiếm ko hợp lệ
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Ngăn ko cho nhập SDT ko hợp lệ
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool KeyDelete = (e.KeyChar == (char)Keys.Delete);
            bool KeyBackspace = (e.KeyChar == (char)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !KeyDelete && !KeyBackspace)
            {
                e.Handled = true;
            }

            string SDT = txtPhone.Text;
            if (SDT.Length >= 12 && !KeyDelete && !KeyBackspace)
            {
                e.Handled = true;
            }
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtPublisherName_TextChanged(object sender, EventArgs e)
        {
            string NXB = txtPublisherName.Text;
            if (NXB == "")
                lblCheckName.Text = "Vui lòng nhập tên!";
            else 
                lblCheckName.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string DiaChi = txtAddress.Text;
            if (DiaChi == "")
                lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            else 
                lblCheckAddress.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtPhone.Text;
            // Kiểm tra số điện thoại đã tồn tại
            string query = $"SELECT SDT FROM NhaXuatBan WHERE SDT = '{SDT}' AND MaNXB <> '{txtPublisherId.Text}'";
            int ExistPhone = NhaXuatBanBUS.GetData(query).Rows.Count;
            if (SDT == "")
                lblCheckPhone.Text = "Vui lòng nhập SĐT!";
            else if (SDT.Length < 10)
                lblCheckPhone.Text = "SĐT chưa hợp lệ!";
            else if (ExistPhone > 0)
                lblCheckPhone.Text = "SĐT đã tồn tại!";
            else
                lblCheckPhone.Text = "";
        }

        string CheckValidInput(out string MaNXB, out string TenNXB, out string DiaChi, out string SDT)
        {
            MaNXB = txtPublisherId.Text;
            TenNXB = txtPublisherName.Text;
            DiaChi = txtAddress.Text;
            SDT = txtPhone.Text;

            string ThongBao = "";
            if (TenNXB == "") ThongBao += "Vui lòng nhập tên NXB!";

            if (DiaChi == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập địa chỉ!";
            }

            if (SDT == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập SĐT!";
            }

            if (SDT.Length < 10)
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "SĐT chưa hợp lệ!";
            }

            string query = $"SELECT SDT FROM NhaXuatBan WHERE SDT = '{SDT}' AND MaNXB <> '{MaNXB}'";
            int ExistPhone = NhaXuatBanBUS.GetData(query).Rows.Count;
            if (ExistPhone > 0)
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "SĐT đã tồn tại!";
            }

            return ThongBao;
        }

        // Chức năng thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaNXB, TenNXB, DiaChi, SDT;
                string ThongBao = CheckValidInput(out MaNXB, out TenNXB, out DiaChi, out SDT);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaNXB = new ParameterCSDL("MaNXB", MaNXB);
                    ParameterCSDL pTenNXB = new ParameterCSDL("TenNXB", TenNXB.Trim());
                    ParameterCSDL pDiaChi = new ParameterCSDL("DiaChi", DiaChi.Trim());
                    ParameterCSDL pSDT = new ParameterCSDL("SDT", SDT);
                    ParameterCSDL[] pArray = { pMaNXB, pTenNXB, pDiaChi, pSDT };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);

                    int RowsAffected = NhaXuatBanBUS.InsertData(LstParams);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetAll();
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Chức năng sửa
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý sửa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaNXB, TenNXB, DiaChi, SDT;
                string ThongBao = CheckValidInput(out MaNXB, out TenNXB, out DiaChi, out SDT);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaNXB = new ParameterCSDL("MaNXB", MaNXB);
                    ParameterCSDL pTenNXB = new ParameterCSDL("TenNXB", TenNXB.Trim());
                    ParameterCSDL pDiaChi = new ParameterCSDL("DiaChi", DiaChi.Trim());
                    ParameterCSDL pSDT = new ParameterCSDL("SDT", SDT);
                    ParameterCSDL[] pArray = { pMaNXB, pTenNXB, pDiaChi, pSDT };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem nội dung sửa có khác ban đầu ko
                    string query = $"SELECT * FROM NhaXuatBan WHERE MaNXB = '{MaNXB}' AND TenNXB = N'{TenNXB}'";
                    query += $" AND DiaChi = N'{DiaChi}' AND SDT = '{SDT}'";

                    int NotChangeData = NhaXuatBanBUS.GetData(query).Rows.Count;
                    // Khi nội dung sửa khác ban đầu thì cập nhật lại
                    if (NotChangeData == 0)
                    {
                        int RowsAffected = NhaXuatBanBUS.UpdateData(LstParams);

                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetAll();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Chức năng xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaNXB;
                MaNXB = txtPublisherId.Text;

                int RowsAffected = NhaXuatBanBUS.DeleteData(MaNXB);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetAll();
                }
            }
        }
    }
}
