using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebOnline
{
    public partial class ChiTietSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThiThongTinSanPham();
        }

        private void HienThiThongTinSanPham()
        {
            if (Request.QueryString["tenSP"] != null && Request.QueryString["hinhAnh"] != null && Request.QueryString["donGia"] != null)
            {
                string tenSP = Request.QueryString["tenSP"];
                string hinhAnh = Request.QueryString["hinhAnh"];
                string donGia = Request.QueryString["donGia"];

                lblTenSP.Text = tenSP;
                imgSanPham.ImageUrl = hinhAnh;
                lblDonGia.Text = "Tổng cộng = " + donGia + "VND";

                string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(sqlcon))
                {
                    string query = "SELECT MoTa FROM SanPham WHERE TenSP = @TenSP";

                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenSP", tenSP);
                        connection.Open();
                        object result = command.ExecuteScalar();

                        
                        if (result != null)
                        {
                            lblMoTa.Text = result.ToString();
                        }
                        else
                        {
                            lblMoTa.Text = "Không có thông tin mô tả cho sản phẩm này.";
                        }
                    }
                }
            }
            else
            {
                
            }
        }
    }
}
