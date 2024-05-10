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

        void HienThiMaNXBKeTiep()
        {
            txtPublisherId.Text = TuDongTao.MaKeTiep("MaNXB", "NhaXuatBan", "NXB");
        }

        void HienThiBangNXB(string query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1")
        {
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;

            HienThiBangNXB();
            HienThiMaNXBKeTiep();

            lblCheckName.Text = "Vui lòng nhập tên!";
            lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            lblCheckPhone.Text = "Vui lòng nhập SĐT!";

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

        private void radPublisherId_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
            query += " AND MaNXB LIKE '%" + NoiDungTim + "%'";
            HienThiBangNXB(query);
        }

        private void radPublisherName_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
            query += " AND TenNXB LIKE N'%" + NoiDungTim + "%'";
            HienThiBangNXB(query);
        }

        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
            query += " AND SDT LIKE '%" + NoiDungTim + "%'";
            HienThiBangNXB(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ResetDuLieuNhap();
            string NoiDungTim = txtSearch.Text;
            string query;

            if (radPublisherId.Checked)
            {
                query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
                query += " AND MaNXB LIKE '%" + NoiDungTim + "%'";

            }
            else if (radPublisherName.Checked)
            {
                query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
                query += " AND TenNXB LIKE N'%" + NoiDungTim + "%'";
            }
            else
            {
                query = "SELECT * FROM NhaXuatBan WHERE TrangThai = 1";
                query += " AND SDT LIKE '%" + NoiDungTim + "%'";
            }

            HienThiBangNXB(query);
        }

        void ResetDuLieuNhap()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            HienThiMaNXBKeTiep();
            HienThiBangNXB();
            txtPublisherName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
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
                string MaNXB, TenNXB, DiaChi, SDT;
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

                if (ThongBao == "")
                {
                    string query = "INSERT INTO NhaXuatBan (MaNXB, TenNXB, DiaChi, SDT, TrangThai)";
                    query += " VALUES ('" + MaNXB + "', N'" + TenNXB + "', N'" + DiaChi + "',";
                    query += " '" + SDT + "', 1)";

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
                string MaNXB, TenNXB, DiaChi, SDT;
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

                if (ThongBao == "")
                {
                    string query = "UPDATE NhaXuatBan SET TenNXB = N'" + TenNXB + "',";
                    query += " DiaChi = N'" + DiaChi + "', SDT = '" + SDT + "'";
                    query += " WHERE MaNXB = '" + MaNXB + "'";

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
                string MaNXB;
                MaNXB = txtPublisherId.Text;

                string query = "UPDATE NhaXuatBan SET TrangThai = 0";
                query += " WHERE MaNXB = '" + MaNXB + "'";

                int RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetDuLieuNhap();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT không hợp lệ!";
            }

            string SDT = txtPhone.Text;
            if (!char.IsControl(e.KeyChar) && SDT.Length >= 12)
            {
                e.Handled = true;
                lblCheckPhone.Text = "SĐT tối đa 12 số!";
            }
        }

        private void txtPublisherName_TextChanged(object sender, EventArgs e)
        {
            string NXB = txtPublisherName.Text;
            if (NXB == "")
            {
                lblCheckName.Text = "Vui lòng nhập tên!";
            }
            else lblCheckName.Text = "";
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string DiaChi = txtAddress.Text;
            if (DiaChi == "")
            {
                lblCheckAddress.Text = "Vui lòng nhập địa chỉ!";
            }
            else lblCheckAddress.Text = "";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtPhone.Text;
            if (SDT == "")
            {
                lblCheckPhone.Text = "Vui lòng nhập SĐT!";
            }
            else lblCheckPhone.Text = "";
        }
    }
}
