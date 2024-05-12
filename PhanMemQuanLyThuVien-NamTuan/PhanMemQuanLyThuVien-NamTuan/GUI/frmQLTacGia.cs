using PhanMemQuanLyThuVien_NamTuan.BUS;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmQLTacGia : Form
    {
        public frmQLTacGia()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DisplayNextAuthorId()
        {
            txtAuthorId.Text = TacGiaBUS.CreateNextId();
        }

        void DisplayAuthor(DataTable data = null, string query = null)
        {
            if (data == null) data = TacGiaBUS.GetData();
            if (query != null) data = TacGiaBUS.GetData(query);

            dgvDataList.DataSource = data;
            txtQuantity.Text = data.Rows.Count.ToString();

            // Xóa việc chương trình tự chọn hàng đầu tiên trong DataGridView
            dgvDataList.ClearSelection();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // Không tự động tạo các cột tiêu đề
            dgvDataList.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            // Hiện dữ liệu tác giả vào DataGridView
            DisplayAuthor();
            // Hiện mã tác giả kế tiếp
            DisplayNextAuthorId();
            // Hiện lời nhắc dưới ô nhập
            lblCheckName.Text = "Vui lòng nhập họ tên!";
            lblCheckHometown.Text = "Vui lòng nhập quê quán!";
        }

        // Sự kiện xảy ra khi chọn vào 1 dòng dữ liệu trong DataGridView
        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                string MaTG, HoTenTG, GioiTinh, QueQuan;
                MaTG = dgvDataList.CurrentRow.Cells["MaTG"].Value.ToString();
                HoTenTG = dgvDataList.CurrentRow.Cells["HoTenTG"].Value.ToString();
                GioiTinh = dgvDataList.CurrentRow.Cells["GioiTinh"].Value.ToString();
                QueQuan = dgvDataList.CurrentRow.Cells["QueQuan"].Value.ToString();

                txtAuthorId.Text = MaTG;
                txtAuthorName.Text = HoTenTG;
                radMale.Checked = (GioiTinh == "Nam") ? true : false;
                radFemale.Checked = (GioiTinh == "Nữ") ? true : false;
                txtHometown.Text = QueQuan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        // Chọn tìm theo mã
        private void radAuthorId_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TacGiaBUS.SearchData("MaTG", txtSearch.Text);
            DisplayAuthor(data);
        }

        // Chọn tìm theo tên
        private void radAuthorName_CheckedChanged(object sender, EventArgs e)
        {
            ResetAll();
            DataTable data = TacGiaBUS.SearchData("HoTenTG", txtSearch.Text);
            DisplayAuthor(data);
        }

        // Sự kiện xảy ra khi nội dung tìm thay đổi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radAuthorId.Checked)
                radAuthorId_CheckedChanged(sender, e);
            else
                radAuthorName_CheckedChanged(sender, e);
        }

        // Reset form
        void ResetAll()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            radMale.Checked = true;
            DisplayAuthor();
            DisplayNextAuthorId();
            txtAuthorName.Text = "";
            txtHometown.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ResetAll();
        }

        // Ngăn ko cho nhập họ tên ko hợp lệ
        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool KeyDelete = (e.KeyChar == (char)Keys.Delete);
            bool KeyBackspace = (e.KeyChar == (char)Keys.Back);
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !KeyDelete && !KeyBackspace)
            {
                e.Handled = true;
            }
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {
            string HoTen = txtAuthorName.Text;
            if (HoTen == "")
                lblCheckName.Text = "Vui lòng nhập họ tên!";
            else 
                lblCheckName.Text = "";
        }

        // Khi ô nhập thay đổi nếu rỗng hiện lời nhắc
        private void txtHometown_TextChanged(object sender, EventArgs e)
        {
            string Quequan = txtHometown.Text;
            if (Quequan == "")
                lblCheckHometown.Text = "Vui lòng nhập quê quán!";
            else 
                lblCheckHometown.Text = "";
        }

        string CheckValidInput(out string MaTG, out string HoTenTG, out string GioiTinh, out string QueQuan)
        {
            MaTG = txtAuthorId.Text;
            HoTenTG = txtAuthorName.Text;
            GioiTinh = (radMale.Checked) ? "Nam" : "Nữ";
            QueQuan = txtHometown.Text;

            string ThongBao = "";
            if (HoTenTG == "") ThongBao += "Vui lòng nhập họ tên!";

            if (QueQuan == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập quê quán!";
            }

            return ThongBao;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý thêm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string MaTG, HoTenTG, GioiTinh, QueQuan;
                string ThongBao = CheckValidInput(out MaTG, out HoTenTG, out GioiTinh, out QueQuan);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTG = new ParameterCSDL("MaTG", MaTG);
                    ParameterCSDL pHoTenTG = new ParameterCSDL("HoTenTG", HoTenTG.Trim());
                    ParameterCSDL pGioiTinh = new ParameterCSDL("GioiTinh", GioiTinh);
                    ParameterCSDL pQueQuan = new ParameterCSDL("QueQuan", QueQuan.Trim());
                    ParameterCSDL[] pArray = { pMaTG, pHoTenTG, pGioiTinh, pQueQuan };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);

                    int RowsAffected = TacGiaBUS.InsertData(LstParams);

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
                string MaTG, HoTenTG, GioiTinh, QueQuan;
                string ThongBao = CheckValidInput(out MaTG, out HoTenTG, out GioiTinh, out QueQuan);

                if (ThongBao == "")
                {
                    ParameterCSDL pMaTG = new ParameterCSDL("MaTG", MaTG);
                    ParameterCSDL pHoTenTG = new ParameterCSDL("HoTenTG", HoTenTG.Trim());
                    ParameterCSDL pGioiTinh = new ParameterCSDL("GioiTinh", GioiTinh);
                    ParameterCSDL pQueQuan = new ParameterCSDL("QueQuan", QueQuan.Trim());
                    ParameterCSDL[] pArray = { pMaTG, pHoTenTG, pGioiTinh, pQueQuan };
                    List<ParameterCSDL> LstParams = new List<ParameterCSDL>();
                    LstParams.AddRange(pArray);
                    // Kiểm tra xem nội dung sửa có khác ban đầu ko
                    string query = $"SELECT * FROM TacGia WHERE MaTG = '{MaTG}' AND HoTenTG = N'{HoTenTG}'";
                    query += $" AND GioiTinh = N'{GioiTinh}' AND QueQuan = N'{QueQuan}'";

                    int NotChangeData = TacGiaBUS.GetData(query).Rows.Count;
                    // Khi nội dung sửa khác ban đầu thì cập nhật lại
                    if (NotChangeData == 0)
                    {
                        int RowsAffected = TacGiaBUS.UpdateData(LstParams);

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
                string MaTG;
                MaTG = txtAuthorId.Text;

                int RowsAffected = TacGiaBUS.DeleteData(MaTG);

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
