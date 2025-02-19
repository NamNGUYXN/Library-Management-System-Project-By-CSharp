﻿using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLTheDocGia : Form
    {
        public frmQLTheDocGia()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisplayNextLibraryCardId()
        {
            txtLibraryCardId.Text = TheDocGiaBus.CreateNextId();
        }

        void HienThiNgayHetHan()
        {
            DateTime dtNow = DateTime.Now;
            dtpExpiryDate.Text = TheDocGiaBus.SauSoNgay(dtNow, 180).ToString();
        }

        void DisplayLibraryCard(DataTable data = null)
        {
            if (data == null) data = TheDocGiaBus.GetData();

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnExtend.Enabled = false;
            // Hiện dữ liệu thẻ độc giả vào DataGridView
            DisplayLibraryCard();
            HienThiNgayHetHan();
            // Hiện mã thẻ độc giả kế tiếp
            DisplayNextLibraryCardId();
            // Hiện lời nhắc dưới ô nhập
            lblCheckName.Text = "Vui lòng nhập họ tên!";
            lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            lblCheckPhone.Text = "Vui lòng nhập họ tên!";
            lblCheckIdCard.Text = "Vui lòng nhập CCCD!";
        }

        // Sự kiện xảy ra khi chọn vào 1 dòng trong DataGridView
        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD;
                DateTime NgayHetHan;
                MaTDG = dgvDataList.CurrentRow.Cells["MaTDG"].Value.ToString();
                HoTenDG = dgvDataList.CurrentRow.Cells["HoTenDG"].Value.ToString();
                GioiTinh = dgvDataList.CurrentRow.Cells["GioiTinh"].Value.ToString();
                DiaChi = dgvDataList.CurrentRow.Cells["DiaChi"].Value.ToString();
                SDT = dgvDataList.CurrentRow.Cells["SDT"].Value.ToString();
                CCCD = dgvDataList.CurrentRow.Cells["CCCD"].Value.ToString();
                NgayHetHan = (DateTime)dgvDataList.CurrentRow.Cells["NgayHetHan"].Value;

                DateTime dt = DateTime.Now;
                if (dt > NgayHetHan) btnExtend.Enabled = true;
                else btnExtend.Enabled = false;

                txtLibraryCardId.Text = MaTDG;
                txtReaderName.Text = HoTenDG;
                radMale.Checked = (GioiTinh == "Nam") ? true : false;
                radFemale.Checked = (GioiTinh == "Nữ") ? true : false;
                txtAddress.Text = DiaChi;
                txtPhone.Text = SDT;
                txtIdCard.Text = CCCD;
                dtpExpiryDate.Text = NgayHetHan.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        // Chọn tìm theo mã
        private void radReaderId_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TheDocGiaBus.SearchData("MaTDG", txtSearch.Text);
            DisplayLibraryCard(data);
        }

        // Chọn tìm theo tên
        private void radReaderName_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TheDocGiaBus.SearchData("HoTenDG", txtSearch.Text);
            DisplayLibraryCard(data);
        }

        // Chọn tìm theo cccd
        private void radIdCard_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TheDocGiaBus.SearchData("CCCD", txtSearch.Text);
            DisplayLibraryCard(data);
        }

        // Chọn tìm theo sdt
        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TheDocGiaBus.SearchData("SDT", txtSearch.Text);
            DisplayLibraryCard(data);
        }

        // Sự kiện xảy ra khi nội dung tìm thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radLibraryCardId.Checked)
                radReaderId_CheckedChanged(sender, e);
            else if (radReaderName.Checked)
                radReaderName_CheckedChanged(sender, e);
            else if (radIdCard.Checked)
                radIdCard_CheckedChanged(sender, e);
            else
                radPhone_CheckedChanged(sender, e);
        }

        // Reset form
        void ResetAll()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnExtend.Enabled = false;
            DisplayLibraryCard();
            DisplayNextLibraryCardId();
            HienThiNgayHetHan();
            txtReaderName.Text = "";
            radMale.Checked = true;
            radLibraryCardId.Checked = true;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtIdCard.Text = "";
        }

        private void txtReaderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            radIdCard.Checked = true;
            ResetAll();
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtReaderName_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtReaderName.Text;
            if (HoTen == "")
                lblCheckName.Text = "Vui lòng nhập họ tên!";
            else if (!Regex.IsMatch(HoTen, @"^\p{L}[\p{L}\s]+$"))
                lblCheckName.Text = "Họ tên không hợp lệ!";
            else 
                lblCheckName.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string DiaChi = txtAddress.Text;
            if (DiaChi == "")
                lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            else if (!Regex.IsMatch(DiaChi, @"^[-/,.\w\s]+$"))
                lblCheckAddress.Text = "Địa chỉ không hợp lệ!";
            else
                lblCheckAddress.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtPhone.Text;
            bool ExistPhone = TheDocGiaBus.ExistPhone(txtLibraryCardId.Text, SDT);
            if (SDT == "")
                lblCheckPhone.Text = "Vui lòng nhập SĐT!";
            else if (ExistPhone)
                lblCheckPhone.Text = "SĐT đã tồn tại!";
            else if (SDT.Length > 12 || SDT.Length < 10 || !Regex.IsMatch(SDT, @"^0\d+$"))
                lblCheckPhone.Text = "SĐT không hợp lệ!";
            else
                lblCheckPhone.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtIdCard_TextChanged(object sender, EventArgs e)
        {
            string CCCD = txtIdCard.Text;
            bool ExistIdCard = TheDocGiaBus.ExistIdCard(txtLibraryCardId.Text, CCCD);
            if (CCCD == "")
                lblCheckIdCard.Text = "Vui lòng nhập CCCD!";
            else if (ExistIdCard)
                lblCheckIdCard.Text = "CCCD đã tồn tại!";
            else if (CCCD.Length != 12 || !Regex.IsMatch(CCCD, @"^0\d+$"))
                lblCheckIdCard.Text = "CCCD không hợp lệ!";
            else
                lblCheckIdCard.Text = "";
        }

        string CheckValidInput(out string MaTDG, out string HoTenDG, out string GioiTinh, out string DiaChi,
            out string SDT, out string CCCD, out string NgayTao, out string NgayHetHan)
        {
            MaTDG = txtLibraryCardId.Text;
            HoTenDG = txtReaderName.Text.Trim();
            GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
            DiaChi = txtAddress.Text.Trim();
            SDT = txtPhone.Text;
            CCCD = txtIdCard.Text;
            DateTime dt = DateTime.Now;
            NgayTao = dt.ToString();
            NgayHetHan = dtpExpiryDate.Value.ToString("yyyy/MM/dd");

            string ThongBao = "";
            if (HoTenDG == "") ThongBao += "Vui lòng nhập họ tên!";
            else if (!Regex.IsMatch(HoTenDG, @"^\p{L}[\p{L}\s]+$"))
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Họ tên không hợp lệ!";
            }

            if (DiaChi == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập địa chỉ!";
            }
            else if (!Regex.IsMatch(DiaChi, @"^[-/,.\w\s]+$"))
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Địa chỉ không hợp lệ!";
            }

            bool ExistPhone = TheDocGiaBus.ExistPhone(MaTDG, SDT);
            if (SDT == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập SĐT!";
            } 
            else if (SDT.Length > 12 || SDT.Length < 10 || !Regex.IsMatch(SDT, @"^0\d+$"))
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "SĐT không hợp lệ!";
            }
            else if (ExistPhone)
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "SĐT đã tồn tại!";
            }

            bool ExistIdCard = TheDocGiaBus.ExistIdCard(MaTDG, CCCD);
            if (CCCD == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập CCCD!";
            }
            else if (CCCD.Length != 12 || !Regex.IsMatch(CCCD, @"^0\d+$"))
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "CCCD không hợp lệ!";
            }
            else if (ExistIdCard)
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "CCCD đã tồn tại!";
            }

            return ThongBao;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD, NgayTao, NgayHetHan;

                string ThongBao = CheckValidInput(out MaTDG, out HoTenDG, out GioiTinh, out DiaChi,
                    out SDT, out CCCD, out NgayTao, out NgayHetHan);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTDG = new ParameterCSDL("MaTDG", MaTDG);
                    ParameterCSDL pHoTenDG = new ParameterCSDL("HoTenDG", HoTenDG);
                    ParameterCSDL pGioiTinh = new ParameterCSDL("GioiTinh", GioiTinh);
                    ParameterCSDL pDiaChi = new ParameterCSDL("DiaChi", DiaChi);
                    ParameterCSDL pSDT = new ParameterCSDL("SDT", SDT);
                    ParameterCSDL pCCCD = new ParameterCSDL("CCCD", CCCD);
                    ParameterCSDL pNgayTao = new ParameterCSDL("NgayTao", NgayTao);
                    ParameterCSDL pNgayHetHan = new ParameterCSDL("NgayHetHan", NgayHetHan);
                    ParameterCSDL[] pArray = { pMaTDG, pHoTenDG, pGioiTinh, pDiaChi, pSDT, pCCCD, pNgayTao, pNgayHetHan };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);

                    int RowsAffected = TheDocGiaBus.InsertData(LstParams);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý sửa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD, NgayTao, NgayHetHan;

                string ThongBao = CheckValidInput(out MaTDG, out HoTenDG, out GioiTinh, out DiaChi,
                    out SDT, out CCCD, out NgayTao, out NgayHetHan);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTDG = new ParameterCSDL("MaTDG", MaTDG);
                    ParameterCSDL pHoTenDG = new ParameterCSDL("HoTenDG", HoTenDG);
                    ParameterCSDL pGioiTinh = new ParameterCSDL("GioiTinh", GioiTinh);
                    ParameterCSDL pDiaChi = new ParameterCSDL("DiaChi", DiaChi);
                    ParameterCSDL pSDT = new ParameterCSDL("SDT", SDT);
                    ParameterCSDL pCCCD = new ParameterCSDL("CCCD", CCCD);
                    ParameterCSDL[] pArray = { pMaTDG, pHoTenDG, pGioiTinh, pDiaChi, pSDT, pCCCD };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);

                    // Kiểm tra xem nội dung sửa có khác ban đầu ko
                    bool NotChangeData = TheDocGiaBus.CheckNotChange(MaTDG, HoTenDG, GioiTinh, DiaChi, SDT, CCCD);
                    // Khi nội dung sửa khác ban đầu thì cập nhật lại
                    if (NotChangeData)
                    {
                        int RowsAffected = TheDocGiaBus.UpdateData(LstParams);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTDG;
                MaTDG = txtLibraryCardId.Text;

                int RowsAffected = TheDocGiaBus.DeleteData(MaTDG);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetAll();
                }
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý gia hạn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTDG, NgayHetHan, ThongBao = "";
                MaTDG = txtLibraryCardId.Text;
                DateTime dtNow = DateTime.Now;
                NgayHetHan = TheDocGiaBus.SauSoNgay(dtNow, 180).ToString("yyyy/MM/dd");

                DateTime NgayHetHanTrongCSDL = TheDocGiaBus.GetDueDate(MaTDG);
                DateTime NgayToiDaDuocGiaHan = TheDocGiaBus.SauSoNgay(NgayHetHanTrongCSDL, 10);
                if (dtNow > NgayToiDaDuocGiaHan)
                {
                    ThongBao += "Thời hạn độc giả được gia hạn đã hơn 10 ngày!";
                }

                if (ThongBao == "")
                {
                    int RowsAffected = TheDocGiaBus.Extend(MaTDG, NgayHetHan);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Gia hạn thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetAll();
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao, "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
    }
}