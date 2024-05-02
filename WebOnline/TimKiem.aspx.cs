using System;
using System.Data;
using System.Data.SqlClient;

namespace WebOnline
{
    public partial class TimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productName = Request.QueryString["ProductName"];
                if (!string.IsNullOrEmpty(productName))
                {
                    DataTable dtSearchResult = SearchProductByName(productName);
                    if (dtSearchResult.Rows.Count > 0)
                    {

                        dlSearchResults.DataSource = dtSearchResult;
                        dlSearchResults.DataBind();
                    }
                    else
                    {

                        dlSearchResults.DataSource = dtSearchResult;
                        dlSearchResults.DataBind();
                    }
                }
            }
        }

        private DataTable SearchProductByName(string productName)
        {
            DataTable dt = new DataTable();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            string query = "SELECT MaSV, TenSP, HinhAnh, DonGia FROM SanPham WHERE TenSP LIKE @ProductName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", "%" + productName );

               
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                
            }

            return dt;
        }
    }
}
