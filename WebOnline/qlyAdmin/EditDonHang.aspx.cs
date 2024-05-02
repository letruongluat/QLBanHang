using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOnline.qlyAdmin
{
    public partial class EditDonHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                PopulateProductData();
            }
        }

        protected void PopulateProductData()
        {



            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";

            string query = "SELECT TaiKhoan.TenTK, TenDangNhap, Email, SDT , MaDH, SoLuong, TongTien FROM TaiKhoan,DonHang where TaiKhoan.TenTK=DonHang.TenTK";


            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    txtten.Text = reader["TenTK"].ToString();
                    txttendn.Text = reader["TenDangNhap"].ToString();
                   
                    txtemail.Text = reader["Email"].ToString();
                    txtsdt.Text = reader["SDT"].ToString();
                    txtMaDh.Text = reader["MaDH"].ToString();
                    txtSoLuong.Text = reader["SoLuong"].ToString();
                    txtTongTien.Text = reader["TongTien"].ToString();
                }
                reader.Close();
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {

            string tentk = txtten.Text;
            string tendn = txttendn.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string maDH = txtMaDh.Text;
            string sl = txtSoLuong.Text;
            string tongtien = txtTongTien.Text;

            CapNhatSanPham( maDH, sl, tongtien);


            Response.Redirect("QLyDonHang.aspx");
        }

        protected void CapNhatSanPham( string maDH, string sl , string tongtien)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";


            string query = "UPDATE DonHang SET  SoLuong = @SoLuong ,TongTien =@TongTien WHERE MaDH = @MaDH ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

               
                command.Parameters.AddWithValue("@MaDH", maDH);
                command.Parameters.AddWithValue("@SoLuong", sl);

                command.Parameters.AddWithValue("@TongTien", tongtien);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                }
                else
                {
                }
            }
        }
    }
}
