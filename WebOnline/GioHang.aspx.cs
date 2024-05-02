using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebOnline
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadThongTinDangKy();
            }

            HienThiThongTinSanPham();
        }

        protected void LoadThongTinDangKy()
        {
            if (Session["TenDangNhap"] != null)
            {
                string tenDangNhap = Session["TenDangNhap"].ToString();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                string query = "SELECT Email, TenDangNhap, SDT FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string tenSP = Request.QueryString["tenSP"];
                        string hinhAnh = Request.QueryString["hinhAnh"];
                        string donGia = Request.QueryString["donGia"];
                        lblTenSP.Text = tenSP;
                        imgSanPham.ImageUrl = hinhAnh;

                        lblDonGia.Text = donGia;
                        txttenDN.Text = reader["TenDangNhap"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtSoDienThoai.Text = reader["SDT"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                }
            }
        }

        protected void HienThiThongTinSanPham()
        {
            if (Request.QueryString["maSP"] != null)
            {
                string maSP = Request.QueryString["maSP"];
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                string query = "SELECT MaSV, TenSP, DonGia FROM SanPham WHERE MaSV = @MaSP";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSP", maSP);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string maSV = reader["MaSV"].ToString();
                        Session["MaSV"] = maSV;
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            else
            {

            }
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM DonHang WHERE TenTK = @TenTK", con);
                    checkCmd.Parameters.AddWithValue("@TenTK", txttenDN.Text);
                    int userCount = (int)checkCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        Response.Write("<script>alert('Đơn Hàng đã tồn tại!');</script>");
                        con.Close();
                        return;
                    }

                    int soLuong;
                    if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
                    {
                        Response.Write("<script>alert('Số lượng không hợp lệ!');</script>");
                        return;
                    }

                    string maSP = Request.QueryString["maSP"];

                    float donGia;
                    if (!float.TryParse(lblDonGia.Text.Replace("VND", "").Trim(), out donGia))
                    {
                        return;
                    }

                    float tongTien = donGia * soLuong;

                    DateTime ngayHD = DateTime.Now;

                    SqlCommand getTenTKCmd = new SqlCommand("SELECT TenTK FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap", con);
                    getTenTKCmd.Parameters.AddWithValue("@TenDangNhap", txttenDN.Text);
                    string tenTK = getTenTKCmd.ExecuteScalar().ToString();

                    SqlCommand cmd = new SqlCommand("INSERT INTO DonHang (MaSV, TenTK, NgayHD, SoLuong, TongTien) VALUES (@MaSV, @TenTK, @NgayHD, @SoLuong, @TongTien)", con);
                    cmd.Parameters.AddWithValue("@MaSV", maSP);
                    cmd.Parameters.AddWithValue("@TenTK", tenTK);
                    cmd.Parameters.AddWithValue("@NgayHD", ngayHD);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);

                    int ketqua = cmd.ExecuteNonQuery();
                    con.Close();

                    if (ketqua > 0)
                    {
                        Session["MaSV"] = maSP;
                        Session["TenTK"] = tenTK;
                        Session["NgayHD"] = ngayHD;
                        Session["SoLuong"] = soLuong;
                        Session["TongTien"] = tongTien;

                        ScriptManager.RegisterStartupScript(this, GetType(), "InvalidLogin", "alert('Đặt hàng thành công');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "InvalidLogin", "document.getElementById('tenDangNhapError').innerText = 'Đặt hàng đã tồn tại!';", true);
                    }
                }
            }
        }
    }
}
