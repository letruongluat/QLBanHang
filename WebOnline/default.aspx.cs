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
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["TenDangNhap"] == null)
                {
                    HienThiSanPham();
                }
                else
                {

                    HienThiSanPham();
                }
            }
        }

        protected void HienThiSanPham()
        {
           
            string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string sql = "SELECT SanPham.MaSV, SanPham.TenSP, SanPham.HinhAnh, SanPham.DonGia FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dl_loaiSP.DataSource = dt;
                dl_loaiSP.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["TenDangNhap"] == null)
            {

                Response.Redirect("DangNhap.aspx");

            }

        }

        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            if (Session["TenDangNhap"] == null)
            {

                Response.Redirect("DangNhap.aspx");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["TenDangNhap"] == null)
            {
               
                Response.Redirect("DangNhap.aspx");
            }

        }
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
            if (Session["TenDangNhap"] == null)
            {
                Response.Redirect("DangNhap.aspx");
            }

        }
    }
}
