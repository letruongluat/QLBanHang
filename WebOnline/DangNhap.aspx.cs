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
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtten.Text;
            string matKhau = txtpass.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @TenTK AND MatKhau = @MatKhau", con);
            cmd.Parameters.AddWithValue("@TenTK", tenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", matKhau);
            int userCount = (int)cmd.ExecuteScalar();
            if (userCount > 0)
            {
                
                SqlCommand selectCmd = new SqlCommand("SELECT Email, TenTK, SDT , TenDangNhap FROM TaiKhoan WHERE TenTK = @TenTK", con);
                selectCmd.Parameters.AddWithValue("@TenTK", tenDangNhap);
                SqlDataReader reader = selectCmd.ExecuteReader();
                if (reader.Read())
                {
                  
                    Session["TenDangNhap"] = reader["TenDangNhap"].ToString();
                    Session["Email"] = reader["Email"].ToString();
                    Session["SDT"] = reader["SDT"].ToString();
                    Session["TenTK"] = reader["TenTK"].ToString();

                }
                reader.Close();

                ScriptManager.RegisterStartupScript(this, GetType(), "ValidLogin", "alert('Đăng nhập thành công');", true);
                Response.Redirect("TrangChu.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "InvalidLogin", "document.getElementById('tenDangNhapError').innerText = 'Tên đăng nhập hoặc mật khẩu không đúng!';", true);
            }
            con.Close();
        }

    }
}
