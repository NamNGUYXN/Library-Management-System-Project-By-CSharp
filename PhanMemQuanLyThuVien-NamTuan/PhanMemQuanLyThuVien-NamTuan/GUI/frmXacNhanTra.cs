using GUI;
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

namespace PhanMemQuanLyThuVien_NamTuan.GUI
{
    public partial class frmXacNhanTra : Form
    {
        public string MaPhieu = "";
        public string MaTDG = "";
        List<SachHong> DSSachHong = new List<SachHong>();
        List<string> DSMaSach = new List<string>();
        string MaSach = "";
        string MoTa = "";

        public frmXacNhanTra()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HienThiMaSach()
        {
            //string query = "SELECT MaSach FROM CTPhieuMuonTra";
            //query += " WHERE MaPhieu = '" + MaPhieu + "'";
            //DataTable data = CTPhieuMuonTraBUS.GetData(query);
            //foreach (DataRow dr in data.Rows)
            //{
            //    DSMaSach.Add(dr[0].ToString());
            //}
            //clbBooks.DataSource = data;
            //clbBooks.DisplayMember = "MaSach";
            //clbBooks.ValueMember = "MaSach";
            //// Xóa việc chương trình tự chọn hàng đầu tiên trong clbBooks
            //clbBooks.ClearSelected();
        }

        string MaSachHongKeTiep()
        {
            return TuDongTao.MaKeTiep("MaSH", "SachHong", "SH");
        }

        private void frmXacNhanTra_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            btnSaveDescription.Enabled = false;
            btnConfirm.Enabled = true;

            HienThiMaSach();
        }

        private void clbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbBooks.SelectedIndex != -1)
            {
                // Lấy đc mã sách từ giá trị đang đc chọn ở clbBooks
                string MaSach = clbBooks.SelectedValue.ToString();
                // Lấy thông tin sách từ csdl và đưa vào phần thông tin sách
                string query = "SELECT TenSach, TenTL, HoTenTG ";
                query += " FROM Sach s INNER JOIN TheLoai tl ON s.MaTL = tl.MaTL ";
                query += " INNER JOIN TacGia tg ON s.MaTG = tg.MaTG ";
                query += " WHERE MaSach = '" + MaSach + "'";
                DataTable data = SachBUS.GetData(query);
                if (data.Rows.Count > 0)
                {
                    txtBookName.Text = data.Rows[0][0].ToString();
                    txtCategory.Text = data.Rows[0][1].ToString();
                    txtAuthor.Text = data.Rows[0][2].ToString();
                }

                int index = clbBooks.SelectedIndex;
                if (!clbBooks.GetItemChecked(index))
                {
                    txtDescription.Enabled = false;
                    btnSaveDescription.Enabled = false;
                    txtDescription.Text = "";
                }
                else
                {
                    txtDescription.Enabled = true;
                    btnSaveDescription.Enabled = true;
                    foreach (SachHong itemSH in DSSachHong)
                    {
                        if (itemSH.MaSach == clbBooks.SelectedValue.ToString())
                            txtDescription.Text = itemSH.MoTa;
                    }
                }
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            MoTa = txtDescription.Text;
        }

        private void clbBooks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Trường hợp check mã sách
            if (e.NewValue == CheckState.Checked)
            {
                txtDescription.Enabled = true;
                btnSaveDescription.Enabled = true;
                btnConfirm.Enabled = false;
                MaSach = clbBooks.SelectedValue.ToString();
                SachHong sh = new SachHong(MaSach, "");
                DSSachHong.Add(sh);

                //
                int index = 0;
                foreach (string itemMS in DSMaSach)
                {
                    if (itemMS == clbBooks.SelectedValue.ToString()) break;
                    index++;
                }
                DSMaSach.RemoveAt(index);
            }
            else
            {
                txtDescription.Text = "";
                txtDescription.Enabled = false;
                btnSaveDescription.Enabled = false;

                //
                int index = 0;
                foreach (SachHong itemSH in DSSachHong)
                {
                    if (itemSH.MaSach == clbBooks.SelectedValue.ToString()) break;
                    index++;
                }
                DSSachHong.RemoveAt(index);

                //
                string MaSach = clbBooks.SelectedValue.ToString();
                DSMaSach.Add(MaSach);

                //
                int cnt = 0;
                foreach (SachHong itemSH in DSSachHong)
                {
                    if (itemSH.MoTa == "") cnt++;
                }
                if (cnt == 0) btnConfirm.Enabled = true;
            }
        }

        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            int index = clbBooks.SelectedIndex;
            if (clbBooks.GetItemChecked(index))
            {
                foreach (SachHong itemSH in DSSachHong)
                {
                    if (itemSH.MaSach == clbBooks.SelectedValue.ToString())
                        itemSH.MoTa = this.MoTa;
                }
            }
            if (MoTa != "") btnConfirm.Enabled = true;
            else
            {
                MessageBox.Show("Mô tả không được để trống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConfirm.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //string txt = "";
            //for (int i = 0; i < DSSachHong.Count; i++)
            //{
            //    txt += "MaSach: " + DSSachHong[i].MaSach.ToString() + "\n";
            //    txt += "MoTa: " + DSSachHong[i].MoTa.ToString() + "\n";
            //    txt += "----------------\n";
            //}
            //MessageBox.Show(txt);

            //DialogResult result = MessageBox.Show("Đồng ý xác nhận trả?", "Thông báo",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    int RowsAffected = 0;
            //    string query = "";
            //    DateTime dt = DateTime.Now;
            //    string NgayTra = dt.ToString("yyyy/MM/dd");

            //    foreach (SachHong itemSH in DSSachHong)
            //    {
            //        string MaSH = MaSachHongKeTiep();
            //        string MaSach = itemSH.MaSach;
            //        string MoTa = itemSH.MoTa;
            //        query = "INSERT INTO SachHong (MaSH, MaSach, MaTDG, MoTa, NgayBaoHong, TrangThai)";
            //        query += " VALUES ('" + MaSH + "', '" + MaSach + "', '" + MaTDG + "',";
            //        query += " N'" + MoTa + "', '" + NgayTra + "', 1)";
            //        RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);
            //    }

            //    foreach (string itemMS in DSMaSach)
            //    {
            //        query = "SELECT SoLuong FROM Sach WHERE MaSach = '" + itemMS + "'";
            //        int SoLuong = (int)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
            //        SoLuong++;

            //        query = "UPDATE Sach SET SoLuong = " + SoLuong + " WHERE MaSach = '" + itemMS + "'";
            //        RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);
            //    }

            //    query = "UPDATE PhieuMuonTra SET DaTra = 1, NgayTra = '" + NgayTra + "'";
            //    query += " WHERE MaPhieu = '" + MaPhieu + "'";
            //    RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);

            //    if (RowsAffected > 0)
            //    {
            //        MessageBox.Show("Xác nhận trả thành công!", "Thông báo",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //}
        }
    }

    public class SachHong
    {
        public string MaSach { get; set; }
        public string MoTa { get; set; }

        public SachHong()
        {
            MaSach = "";
            MoTa = "";
        }

        public SachHong(string MaSach, string MoTa)
        {
            this.MaSach = MaSach;
            this.MoTa = MoTa;
        }
    }
}
