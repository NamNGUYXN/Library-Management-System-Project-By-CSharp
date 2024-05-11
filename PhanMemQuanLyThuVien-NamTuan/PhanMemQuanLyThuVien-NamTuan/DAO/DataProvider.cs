using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GUI;
using System.Windows.Forms;
using PhanMemQuanLyThuVien_NamTuan.DTO;
using System.Drawing;

namespace PhanMemQuanLyThuVien_NamTuan.DAO
{
    public class DataProvider
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=DBQuanLyThuVien;Integrated Security=True");

        public static DataTable GetData(string query, List<ParameterCSDL> LstParams = null)
        {
            try
            {
                DataTable data = new DataTable();
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                if (LstParams != null)
                {
                    foreach (ParameterCSDL param in LstParams)
                    {
                        cmd.Parameters.AddWithValue(param.KeyCSDL, param.ValueCSDL);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn dữ liệu...", ex);
            }
        }

        public static int ExcuteSQL(string query, List<ParameterCSDL> LstParams = null)
        {
            try
            {
                int result;
                SqlCommand cmd = new SqlCommand(query, conn);
                if (LstParams != null)
                {
                    foreach (ParameterCSDL param in LstParams)
                    {
                        cmd.Parameters.AddWithValue(param.KeyCSDL, param.ValueCSDL);
                    }
                }
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thực thi truy vấn...", ex);
            }
        }

        public static void DoDuLieu(string column, string table, ComboBox cbo)
        {
            string query = "SELECT " + column + " FROM " + table;
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string value = reader.GetString(0);
                    cbo.Items.Add(value);
                }
            }
            conn.Close();
        }
    }
}
