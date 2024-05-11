using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtPresentPassword.Select();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Đồng ý đổi mật khẩu?",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool KTDoiMatKhau = false;
                string ThongBao = "";
                string MatKhauHienTai, MatKhauMoi, MatKhauMoiXacNhan;
                MatKhauHienTai = txtPresentPassword.Text;
                MatKhauMoi = txtNewPassword.Text;
                MatKhauMoiXacNhan = txtAgainNewPassword.Text;

                // Kiểm tra nhập liệu
                if (MatKhauHienTai == "") ThongBao += "Vui lòng nhập mật khẩu hiện tại!";


                if (MatKhauMoi == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập mật khẩu mới!";
                }

                if (MatKhauMoiXacNhan == "")
                {
                    ThongBao += (ThongBao != "") ? "\n" : "";
                    ThongBao += "Vui lòng nhập lại mật khẩu mới!";
                }

                // Kiểm tra mật khẩu mới trùng nhau
                if (MatKhauMoi == MatKhauMoiXacNhan)
                    KTDoiMatKhau = DoiMatKhauBUS.CheckChangePassword(MatKhauHienTai, MatKhauMoi);
                else
                    ThongBao += "Mật khẩu mới không trùng nhau!";

                // Trường hợp nhập liệu hợp lệ
                if (ThongBao == "")
                {
                    // Trường hợp đổi mật khẩu thành công
                    if (KTDoiMatKhau == true)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "THÔNG BÁO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    // Trường hợp đổi mật khẩu ko thành công
                    else
                        MessageBox.Show("Mật khẩu hiện tại không chính xác!", "THÔNG BÁO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Trường hợp nhập liệu không hợp lệ
                else
                    MessageBox.Show(ThongBao, "THÔNG BÁO",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPresentPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtAgainNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtPresentPassword.PasswordChar = '*';
                txtNewPassword.PasswordChar = '*';
                txtAgainNewPassword.PasswordChar = '*';
            }
        }
    }
}
