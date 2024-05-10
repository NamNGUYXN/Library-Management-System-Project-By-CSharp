using PhanMemQuanLyThuVien_NamTuan.BUS;
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
    public partial class frmQLTheLoai : Form
    {
        public frmQLTheLoai()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HienThiMaTLKeTiep()
        {
            // Tìm mã thể loại cao nhất trong csdl
            string query = "SELECT MAX(MaTL) FROM TheLoai";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaTLMax = data.Rows[0][0].ToString();

            if (MaTLMax == "")
                txtCategoryId.Text = "TL001";
            else
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaTLMax, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaTLMax, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                string MaTLKeTiep = StringPart + NumberPart.ToString("D3");
                txtCategoryId.Text = MaTLKeTiep;
            }
        }

        void HienThiBangTheLoai(string query = "SELECT * FROM TheLoai WHERE TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;

            HienThiBangTheLoai();
            HienThiMaTLKeTiep();

            lblCheckCategoryName.Text = "Vui lòng nhập tên thể loại!";

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaLoai, TenLoai;
                MaLoai = dgvDataList.CurrentRow.Cells["MaTL"].Value.ToString();
                TenLoai = dgvDataList.CurrentRow.Cells["TenTL"].Value.ToString();

                txtCategoryId.Text = MaLoai;
                txtCategoryName.Text = TenLoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void radCategoryId_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TheLoai WHERE TrangThai = 1";
            query += " AND MaTL LIKE '%" + NoiDungTim + "%'";
            HienThiBangTheLoai(query);
        }

        private void radCategoryName_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM TheLoai WHERE TrangThai = 1";
            query += " AND TenTL LIKE N'%" + NoiDungTim + "%'";
            HienThiBangTheLoai(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query;

            if (radCategoryId.Checked)
            {
                query = "SELECT * FROM TheLoai WHERE TrangThai = 1";
                query += " AND MaTL LIKE '%" + NoiDungTim + "%'";
            }
            else
            {
                query = "SELECT * FROM TheLoai WHERE TrangThai = 1";
                query += " AND TenTL LIKE N'%" + NoiDungTim + "%'";
            }

            HienThiBangTheLoai(query);
        }

        void ResetDuLieuNhap()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            HienThiMaTLKeTiep();
            HienThiBangTheLoai();
            txtCategoryName.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTL, TenTL;
                MaTL = txtCategoryId.Text;
                TenTL = txtCategoryName.Text;

                string ThongBao = "";
                if (TenTL == "") ThongBao += "Vui lòng nhập tên thể loại!";

                if (ThongBao == "")
                {
                    string query = "INSERT INTO TheLoai (MaTL, TenTL, TrangThai)";
                    query += " VALUES ('" + MaTL + "', N'" + TenTL + "', 1)";

                    int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetDuLieuNhap();
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
                string MaTL, TenTL;
                MaTL = txtCategoryId.Text;
                TenTL = txtCategoryName.Text;

                string ThongBao = "";
                if (TenTL == "") ThongBao += "Vui lòng nhập tên thể loại!";

                if (ThongBao == "")
                {
                    string query = "UPDATE TheLoai SET TenTL = N'" + TenTL + "'";
                    query += " WHERE MaTL = '" + MaTL + "'";

                    int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetDuLieuNhap();
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
                string MaTL;
                MaTL = txtCategoryId.Text;

                string query = "UPDATE TheLoai SET TrangThai = 0";
                query += " WHERE MaTL = '" + MaTL + "'";

                int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetDuLieuNhap();
                }
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            string TheLoai = txtCategoryName.Text;
            if (TheLoai == "")
            {
                lblCheckCategoryName.Text = "Vui lòng nhập tên thể loại!";
            }
            else lblCheckCategoryName.Text = "";
        }

        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckCategoryName.Text = "Tên thể loại không hợp lệ!";
            }
        }
    }
}
