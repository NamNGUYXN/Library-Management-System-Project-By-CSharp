﻿using PhanMemQuanLyThuVien_NamTuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class frmBaoSachHong : Form
    {
        public string MaPhieu = "";
        public string MaTDG = "";
        List<SachHong> DSSachHong = new List<SachHong>();
        List<string> DSMaSach = new List<string>();
        string MaSach = "";
        string MoTa = "";

        public frmBaoSachHong()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HienThiMaSach()
        {
            string query = "SELECT MaSach FROM CTPhieuMuonTra";
            query += " WHERE MaPhieu = '" + MaPhieu + "'";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            foreach (DataRow dr in data.Rows)
            {
                DSMaSach.Add(dr[0].ToString());
            }
            clbBooks.DataSource = data;
            clbBooks.DisplayMember = "MaSach";
            clbBooks.ValueMember = "MaSach";
            // Xóa việc chương trình tự chọn hàng đầu tiên trong clbBooks
            clbBooks.ClearSelected();
        }

        string MaSachHongKeTiep()
        {
            string MaSHKeTiep;
            // Tìm mã sách hỏng cao nhất trong csdl
            string query = "SELECT MAX(MaSH) FROM SachHong";
            DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
            string MaSHMax = data.Rows[0][0].ToString();

            if (MaSHMax != "")
            {
                // Tách ra phần chuỗi và số
                string StringPart = Regex.Match(MaSHMax, @"[A-Z]+").Value;
                int NumberPart = int.Parse(Regex.Match(MaSHMax, @"\d+").Value);

                // Tăng phần số lên 1 đơn vị
                NumberPart++;

                // Nối phần chuỗi và số lại
                MaSHKeTiep = StringPart + NumberPart.ToString("D3");
            }
            else
                MaSHKeTiep = "SH001";

            return MaSHKeTiep;
        }

        private void frmBaoSachHong_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            btnSaveDescription.Enabled = false;
            btnReport.Enabled = true;

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
                DataTable data = ThucThiTruyVanBus.LayDuLieu(query);
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
                btnReport.Enabled = false;
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
                if (cnt == 0) btnReport.Enabled = true;
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
            if (MoTa != "") btnReport.Enabled = true;
            else
            {
                MessageBox.Show("Mô tả không được để trống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReport.Enabled = false;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //string txt = "";
            //for (int i = 0; i < DSSachHong.Count; i++)
            //{
            //    txt += "MaSach: " + DSSachHong[i].MaSach.ToString() + "\n";
            //    txt += "MoTa: " + DSSachHong[i].MoTa.ToString() + "\n";
            //    txt += "----------------\n";
            //}
            //MessageBox.Show(txt);

            DialogResult result = MessageBox.Show("Đồng ý báo cáo?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int RowsAffected = 0;
                string query = "";
                DateTime dt = DateTime.Now;
                string NgayTra = dt.ToString("yyyy/MM/dd");

                foreach (SachHong itemSH in DSSachHong)
                {
                    string MaSH = MaSachHongKeTiep();
                    string MaSach = itemSH.MaSach;
                    string MoTa = itemSH.MoTa;
                    query = "INSERT INTO SachHong (MaSH, MaSach, MaTDG, MoTa, TrangThai)";
                    query += " VALUES ('" + MaSH + "', '" + MaSach + "', '" + MaTDG + "',";
                    query += " N'" + MoTa + "', 1)";
                    RowsAffected = ThucThiTruyVanBus.ThaoTacDuLieu(query);

                    query = "SELECT SoLuong FROM Sach WHERE MaSach = '" + MaSach + "'";
                    int SoLuong = (int)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
                    SoLuong--;

                    query = "UPDATE Sach SET SoLuong = " + SoLuong + " WHERE MaSach = '" + MaSach + "'";
                    RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);
                }

                foreach (string itemMS in DSMaSach)
                {
                    query = "SELECT SoLuong FROM Sach WHERE MaSach = '" + itemMS + "'";
                    int SoLuong = (int)ThucThiTruyVanBus.LayDuLieu(query).Rows[0][0];
                    SoLuong++;

                    query = "UPDATE Sach SET SoLuong = " + SoLuong + " WHERE MaSach = '" + itemMS + "'";
                    RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);
                }

                query = "UPDATE PhieuMuonTra SET DaTra = 1, NgayTra = '" + NgayTra + "'";
                query += " WHERE MaPhieu = '" + MaPhieu + "'";
                RowsAffected += ThucThiTruyVanBus.ThaoTacDuLieu(query);

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Báo cáo thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }

    public class SachHong
    {
        public string MaSach {  get; set; }
        public string MoTa { get; set; }

        public SachHong()
        {
            MaSach = "";
            MoTa = "";
        }

        public SachHong (string MaSach, string MoTa)
        {
            this.MaSach = MaSach;
            this.MoTa = MoTa;
        }
    }
}
