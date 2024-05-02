using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebOnline.qlyAdmin
{
    public partial class QLyTaiKhoan1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienThiDanhSachSanPham();
            }
        }

        protected void HienThiDanhSachSanPham()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenTK, TenDangNhap, MatKhau, Email, SDT FROM TaiKhoan";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                GridViewSanPham.DataSource = dataTable;
                GridViewSanPham.DataBind();
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("ThemTaiKhoan.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            Button btnSua = (Button)sender;
            string tenTK = btnSua.CommandArgument;

           
            Response.Redirect($"EditTaiKhoan.aspx?TenTK={tenTK}");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            string tenTK = btnXoa.CommandArgument;

          
            XoaSanPham(tenTK);

           
            HienThiDanhSachSanPham();
        }

        protected void XoaSanPham(string tenTK)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TaiKhoan WHERE TenTK = @TenTK";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenTK", tenTK);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
