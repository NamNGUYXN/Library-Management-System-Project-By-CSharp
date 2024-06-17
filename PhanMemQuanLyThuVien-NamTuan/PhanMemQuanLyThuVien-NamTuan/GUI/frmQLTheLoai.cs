using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        void DisplayNextCategoryId()
        {
            txtCategoryId.Text = TheLoaiBUS.CreateNextId();
        }

        void DisplayCategory(DataTable data = null)
        {
            if (data == null) data = TheLoaiBUS.GetData();

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            // Hiện dữ liệu thể loại vào DataGridView
            DisplayCategory();
            // Hiện mã thể loại kế tiếp
            DisplayNextCategoryId();
            // Hiện lời nhắc dưới ô nhập
            lblCheckCategoryName.Text = "Vui lòng nhập tên thể loại!";
        }

        // Sự kiện xảy ra khi chọn vào 1 dòng dữ liệu trong DataGridView
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

        // Chọn tìm theo mã
        private void radCategoryId_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TheLoaiBUS.SearchData("MaTL", txtSearch.Text);
            DisplayCategory(data);
        }

        // Chọn tìm theo tên
        private void radCategoryName_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TheLoaiBUS.SearchData("TenTL", txtSearch.Text);
            DisplayCategory(data);
        }

        // Sự kiện xảy ra khi nội dung tìm thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radCategoryId.Checked)
                radCategoryId_CheckedChanged(sender, e);
            else
                radCategoryName_CheckedChanged(sender, e);
        }

        // Reset form
        void ResetAll()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            DisplayNextCategoryId();
            DisplayCategory();
            txtCategoryName.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            radCategoryId.Checked = true;
            ResetAll();
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            string TheLoai = txtCategoryName.Text;
            if (TheLoai == "")
            {
                lblCheckCategoryName.Text = "Vui lòng nhập tên thể loại!";
            }
            else lblCheckCategoryName.Text = "";
        }

        // Ngăn ko cho nhập tên thể loại ko hợp lệ
        private void txtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        string CheckValidInput(out string MaTL, out string TenTL)
        {
            MaTL = txtCategoryId.Text;
            TenTL = txtCategoryName.Text.Trim();

            string ThongBao = "";
            if (TenTL == "") ThongBao += "Vui lòng nhập tên thể loại!";

            return ThongBao;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTL, TenTL;
                string ThongBao = CheckValidInput(out MaTL, out TenTL);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTL = new ParameterCSDL("MaTL", MaTL);
                    ParameterCSDL pTenTL = new ParameterCSDL("TenTL", TenTL);
                    ParameterCSDL[] pArray = { pMaTL, pTenTL };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem thể loại vừa thêm đã tồn tại chưa
                    string query = $"SELECT * FROM TheLoai WHERE TrangThai = 1 AND TenTL = N'{TenTL}'";

                    int ExistCategory = TheLoaiBUS.GetData(query).Rows.Count;
                    if (ExistCategory > 0)
                    {
                        MessageBox.Show("Thể loại đã tồn tại!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int RowsAffected = TheLoaiBUS.InsertData(LstParams);

                        if (RowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo",
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý sửa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTL, TenTL;
                string ThongBao = CheckValidInput(out MaTL, out TenTL);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTL = new ParameterCSDL("MaTL", MaTL);
                    ParameterCSDL pTenTL = new ParameterCSDL("TenTL", TenTL);
                    ParameterCSDL[] pArray = { pMaTL, pTenTL };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem nội dung sửa có khác ban đầu ko
                    string query = $"SELECT * FROM TheLoai WHERE MaTL = '{MaTL}' AND TenTL = N'{TenTL}'";

                    int NotChangeData = TheLoaiBUS.GetData(query).Rows.Count;
                    // Khi nội dung sửa khác ban đầu thì cập nhật lại
                    if (NotChangeData == 0)
                    {
                        int RowsAffected = TheLoaiBUS.UpdateData(LstParams);

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
                string MaTL;
                MaTL = txtCategoryId.Text;

                int RowsAffected = TheLoaiBUS.DeleteData(MaTL);

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
