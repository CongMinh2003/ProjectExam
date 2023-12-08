using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiNhaHang;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL_QuanLiNhaHang
{
    public class Dataprovider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức kiểm tra acount
        public bool CheckTK(string tk, string mk)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tk", tk);
                    command.Parameters.AddWithValue("@mk", mk);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return (count > 0);
                }
            }
        }

        //Phương thức thực hiện truy vấn dữ liệu từ bang 'ThucDon' và trả về dữ liệu đó dưới dạng một đối tượng DataTable
        public DataTable loadThucDon()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM ThucDon";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

        public bool saveDatBan(DatBanDTO db)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO DatBan( MaDatBan, MaBan, MaKhachHang, TenKhachHang, SoLuongNguoi)
                        VALUES ( @madatban, @maban, @makhachhang, @tenkhachhang, @soluongnguoi)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@madatban", db.MaDatBan);
                cmd.Parameters.AddWithValue("@maban", db.MaBan);
                cmd.Parameters.AddWithValue("@makhachhang", db.MaKhachHang);
                cmd.Parameters.AddWithValue("@tenkhachhang", db.TenKhachHang);
                cmd.Parameters.AddWithValue("@soluongnguoi", db.SoLuongNguoi);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        //public bool updateBan()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string sql = @"UPDATE BAN SET TenMon = @tenmon
        //                    WHERE MaBan = @maban and SoLuongNguoi <= @soluongnguoi";
        //        SqlCommand cmd = new SqlCommand(sql, connection);
        //        cmd.Parameters.AddWithValue();
        //        cmd.Parameters.AddWithValue();
        //    }
        //}

        
    }
}
