using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyThuVien_NamTuan
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        //Tạo ra các thuộc tính tương ứng với các button cần quyền truy cập
        public bool btnLibrarianEnabled
        {
            get { return btnLibrarianEnabled; }
            set { btnLibrarian.Enabled = value; }
        }
        // Đoạn code trên tương ứng với đoạn code này
        //private bool btnLibrarianEnabled;
        //public bool get_btnLibrarianEnabled()
        //{
        //    return btnLibrarianEnabled;
        //}
        //public void set_btnLibrarianEnabled(bool value)
        //{
        //    btnLibrarian.Enabled = value;
        //}

        public bool btnBookEnabled
        {
            get { return btnBookEnabled; }
            set { btnBook.Enabled = value; }
        }

        public bool btnCategoryEnabled
        {
            get { return btnCategoryEnabled; }
            set { btnCategory.Enabled = value; }
        }

        public bool btnAuthorEnabled
        {
            get { return btnAuthorEnabled; }
            set { btnAuthor.Enabled = value; }
        }

        public bool btnPublisherEnabled
        {
            get { return btnPublisherEnabled; }
            set { btnPublisher.Enabled = value; }
        }

        public bool btnStatisticEnabled
        {
            get { return btnStatisticEnabled; }
            set { btnStatistic.Enabled = value; }
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTaiKhoan frmTaiKhoan = new frmQLTaiKhoan();
            frmTaiKhoan.ShowDialog();
            this.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSach frmSach = new frmQLSach();
            frmSach.ShowDialog();
            this.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTheLoai frmTheLoai = new frmQLTheLoai();
            frmTheLoai.ShowDialog();
            this.Show();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTacGia frmTacGia = new frmQLTacGia();
            frmTacGia.ShowDialog();
            this.Show();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLNhaXuatBan frmNhaXuatBan = new frmQLNhaXuatBan();
            frmNhaXuatBan.ShowDialog();
            this.Show();
        }

        private void btnLibraryCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLTheDocGia frmTheDocGia = new frmQLTheDocGia();
            frmTheDocGia.ShowDialog();
            this.Show();
        }

        private void btnLoanCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLPhieuMuonTra frmPhieuMuonTra = new frmQLPhieuMuonTra();
            frmPhieuMuonTra.ShowDialog();
            this.Show();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.ShowDialog();
            this.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý đăng xuất?",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Sự kiện form closing sẽ diễn ra ở form đăng nhập
                frmDangNhap.closingAtThisForm = true;
                this.Close();
            }    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Sự kiện form closing sẽ diễn ra ở form giao diện chính này
            frmDangNhap.closingAtThisForm = false;
            this.Close();
        }

        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!frmDangNhap.closingAtThisForm)
            {
                DialogResult result = MessageBox.Show("Đồng ý thoát?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
