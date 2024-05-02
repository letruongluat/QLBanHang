using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebOnline.qlyAdmin
{
    public partial class EditTaiKhoan : System.Web.UI.Page
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

           
            string query = "SELECT TenTK, TenDangNhap, MatKhau,Email,SDT FROM TaiKhoan";

         
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    
                    txtten.Text = reader["TenTK"].ToString();
                    txttendn.Text = reader["TenDangNhap"].ToString();
                    txtpass.Text = reader["MatKhau"].ToString();
                    txtemail.Text = reader["Email"].ToString();
                    txtsdt.Text = reader["SDT"].ToString();
                }
                reader.Close();
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            string tentk = txtten.Text;
            string tendn = txttendn.Text;
            string matkhau = txtpass.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            
            CapNhatSanPham(tentk, tendn, matkhau, email, sdt);

          
            Response.Redirect("QLyTaiKhoan1.aspx");
        }

        protected void CapNhatSanPham(string tentk, string tendn, string matkhau, string email, string sdt)
        {
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";

            
            string query = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, Email = @Email,SDT=@SDT WHERE TenTK = @TenTK";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               
                command.Parameters.AddWithValue("@TenTK", tentk);
                command.Parameters.AddWithValue("@TenDangNhap", tendn);
                command.Parameters.AddWithValue("@MatKhau", matkhau);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@SDT", sdt);

                
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
