using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebOnline.qlyAdmin
{
    public partial class QLySanPham : System.Web.UI.Page
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
                string query = "SELECT MaSV, TenSP, DonGia, SL, HinhAnh, MoTa FROM SanPham";
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
            Response.Redirect("ThemSP.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            Button btnSua = (Button)sender;
            string maSP = btnSua.CommandArgument;

          
            Response.Redirect($"EditSanPham.aspx?MaSV={maSP}");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            string maSV = btnXoa.CommandArgument;

          
            XoaSanPham(maSV);

          
            HienThiDanhSachSanPham();
        }

        protected void XoaSanPham(string maSV)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SanPham WHERE MaSV = @MaSV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSV", maSV);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
