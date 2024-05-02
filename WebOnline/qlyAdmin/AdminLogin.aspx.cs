using System;

namespace WebOnline.qlyAdmin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = tbTenDangNhap.Text.Trim();
            string matKhau = tbMatKhau.Text.Trim();

            if (tenDangNhap == "admin" && matKhau == "admin123")
            {
              
                Response.Redirect("QLyTaiKhoan1.aspx");
            }
            else
            {
                
                ltrThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
    }
}
