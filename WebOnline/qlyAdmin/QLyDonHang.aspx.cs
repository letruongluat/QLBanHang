using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebOnline
{
    public partial class QLyDonHang : System.Web.UI.Page
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
                string query = "SELECT TaiKhoan.TenTK, TenDangNhap, Email, SDT , MaDH,TenSP, SoLuong, TongTien FROM TaiKhoan,DonHang,SanPham where TaiKhoan.TenTK=DonHang.TenTK and DonHang.MaSV = SanPham.MaSV";
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

            Response.Redirect("ThemDonHang.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            Button btnSua = (Button)sender;
            string tenTK = btnSua.CommandArgument;


            Response.Redirect($"EditDonHang.aspx?MaDH={tenTK}");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            string maDH = btnXoa.CommandArgument;


            XoaDonHang(maDH);


            HienThiDanhSachSanPham();
        }

        protected void XoaDonHang(string maDH)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Mở kết nối ở đây

                string queryDonHang = "DELETE FROM DonHang WHERE MaDH = @MaDH";
                SqlCommand commandDonHang = new SqlCommand(queryDonHang, connection); // Sử dụng SqlCommand cho bảng DonHang
                commandDonHang.Parameters.AddWithValue("@MaDH", maDH);
                commandDonHang.ExecuteNonQuery();

                connection.Close(); // Đóng kết nối khi đã hoàn thành thao tác
            }
        }



    }
}
