using System;
using System.Configuration; 
using System.Data.SqlClient;
using System.Web.UI;

using System.Data;
namespace WebOnline
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            if (Page.IsValid)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                con.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE TenTK = @TenTK", con);
                checkCmd.Parameters.AddWithValue("@TenTK", txtten.Text);
                int userCount = (int)checkCmd.ExecuteScalar();
                if (userCount > 0)
                {
                    
                    Response.Write("<script>alert('Tên đăng nhập đã tồn tại!');</script>");
                    con.Close();
                    return;
                }

             
                SqlCommand cmd = new SqlCommand("INSERT INTO TaiKhoan (TenTK, MatKhau, Email,SDT,TenDangNhap) VALUES (@TenTK, @MatKhau, @Email,@SDT,@TenDangNhap)", con);
                cmd.Parameters.AddWithValue("@TenTK", txtten.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtpass.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
                cmd.Parameters.AddWithValue("@TenDangNhap", txttendn.Text);

                int ketqua = cmd.ExecuteNonQuery();
                con.Close();

                if (ketqua > 0)
                {
                 
                    Session["TenTK"] = txtten.Text;
                    Session["Email"] = txtemail.Text;
                    Session["SDT"] = txtsdt.Text;
                    Session["TenDangNhap"] = txttendn.Text;
               

                    
                    ScriptManager.RegisterStartupScript(this, GetType(), "InvalidLogin", "alert('Đăng ký thành công');", true);
                    Response.Redirect("DangNhap.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "InvalidLogin", "document.getElementById('tenDangNhapError').innerText = 'Tên đăng nhập đã tồn tại!';", true);
                }
            }
        }

    }
}
