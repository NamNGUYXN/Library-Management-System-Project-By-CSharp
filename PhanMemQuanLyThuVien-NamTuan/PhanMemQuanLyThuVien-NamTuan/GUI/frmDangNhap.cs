using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQuanLyThuVien_NamTuan;
using PhanMemQuanLyThuVien_NamTuan.BUS;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public static bool closingAtThisForm = true;
        public static string MaTK = "";
        public static bool Quyen = false;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ThongBao = "";
            MaTK = txtLibrarianId.Text;
            string MatKhau = txtPassword.Text;

            // Kiểm tra MaTK rỗng
            if (MaTK == "")
                ThongBao += "Vui lòng nhập tài khoản!";

            // Kiểm tra MatKhau rỗng
            if (MatKhau == "")
            {
                ThongBao += (ThongBao != "") ? "\n" : "";
                ThongBao += "Vui lòng nhập mật khẩu!";
            }    
                
            // Trường hợp nhập liệu hợp lệ
            if (ThongBao == "")
            {
                bool KTDangNhap = DangNhapBUS.CheckLogin(MatKhau);

                // Trường hợp đăng nhập đúng
                if (KTDangNhap == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Ẩn form đăng nhập
                    this.Hide();
                    // Khởi tạo đối tượng form giao diện chính
                    frmGiaoDienChinh frmGiaoDienChinh = new frmGiaoDienChinh();

                    // Không cho phép thủ thư vào các chức năng
                    if (!Quyen)
                    {
                        frmGiaoDienChinh.btnLibrarianEnabled = false;
                        frmGiaoDienChinh.btnBookEnabled = false;
                        frmGiaoDienChinh.btnCategoryEnabled = false;
                        frmGiaoDienChinh.btnAuthorEnabled = false;
                        frmGiaoDienChinh.btnPublisherEnabled = false;
                        frmGiaoDienChinh.btnStatisticEnabled = false;
                    }

                    //Hiện form giao diện chính
                    frmGiaoDienChinh.ShowDialog();

                    // Nhấn thoát ở form giao diện chính
                    if (!closingAtThisForm)
                    {
                        this.Close();
                    }
                    // Nhấn đăng xuất ở form giao diện chính
                    else
                    {
                        //Gán các giá trị về mặc định khi quay lại form đăng nhập
                        txtLibrarianId.Text = "";
                        txtPassword.Text = "";
                        chkShowPassword.Checked = false;
                        Quyen = false;
                        // Tự chọn vào textbox
                        txtLibrarianId.Select();

                        //Hiện lại form đăng nhập
                        this.Show();
                    }
                }
                // Trường hợp đăng nhập sai
                else
                {
                    // Xóa mật khẩu nhập ở textbox
                    txtPassword.Text = "";
                    // Gán cảnh báo vào label
                    lblCheckPassword.Text = "Mã tài khoản hoặc mật khẩu sai!";
                }
            }
            // Trường hợp nhập liệu ko hợp lệ
            else
            {
                MessageBox.Show(ThongBao, "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closingAtThisForm)
            {
                DialogResult result = MessageBox.Show("Đồng ý thoát?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // Cảnh báo về nhập liệu
        private void txtLibrarianId_TextChanged(object sender, EventArgs e)
        {
            if (txtLibrarianId.Text.Length > 0)
                lblCheckUsername.Text = "";
            else
                lblCheckUsername.Text = "Vui lòng nhập mã tài khoản!";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
                lblCheckPassword.Text = "";
            else 
                lblCheckPassword.Text = "Vui lòng nhập mật khẩu!";
        }

        // Hủy kí tự
        private void txtLibrarianId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblCheckUsername.Text = "Không được nhập kí tự đặc biệt";
            }
        }
    }
}
