using System;
using System.Data;
using System.Data.SqlClient;

namespace WebOnline.qlyAdmin
{
    public partial class EditSanPham : System.Web.UI.Page
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
            string maSP = Request.QueryString["MaSV"];

           
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";

           
            string query = "SELECT TenSP, DonGia, SL FROM SanPham WHERE MaSV = @MaSV";

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               
                command.Parameters.AddWithValue("@MaSV", maSP);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   
                    txtMaSP.Text = maSP;
                    txtTenSP.Text = reader["TenSP"].ToString();
                    txtGia.Text = reader["DonGia"].ToString();
                    txtSL.Text = reader["SL"].ToString();
                }
                reader.Close();
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string donGia = txtGia.Text;
            string sL = txtSL.Text;

            
            CapNhatSanPham(maSP, tenSP, donGia, sL);

            
            Response.Redirect("QLySanPham.aspx");
        }

        protected void CapNhatSanPham(string maSP, string tenSP, string donGia, string sL)
        {
           
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";

           
            string query = "UPDATE SanPham SET TenSP = @TenSP, DonGia = @DonGia, SL = @SL WHERE MaSV = @MaSV";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               
                command.Parameters.AddWithValue("@MaSV", maSP);
                command.Parameters.AddWithValue("@TenSP", tenSP);
                command.Parameters.AddWithValue("@DonGia", donGia);
                command.Parameters.AddWithValue("@SL", sL);

              
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
