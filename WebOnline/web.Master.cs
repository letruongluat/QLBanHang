using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebOnline
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ( Session["TenDangNhap"] == null)
                {
                    
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                    string query = "SELECT  TenDangNhap FROM TaiKhoan";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);


                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            
                            Session["TenDangNhap"] = reader["TenDangNhap"].ToString();
                            
                        }

                        reader.Close();
                        connection.Close();
                    }
                }



                if (Session["TenDangNhap"] != null)
                {
                    lbl_ten.Text = Session["TenDangNhap"].ToString();
                }
                else
                {
                    
                }

            }
        }
        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string productName = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(productName))
            {
                Response.Redirect($"TimKiem.aspx?ProductName={productName}");
            }
        }
    }

}
