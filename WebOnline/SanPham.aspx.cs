using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebOnline
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string maLoai = Request.QueryString["MaLoai"];
                string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(sqlcon))
                {
                    con.Open();
                    string sql = "SELECT SanPham.MaSV, SanPham.TenSP, SanPham.HinhAnh, SanPham.DonGia, LoaiSP.TenLoai FROM SanPham INNER JOIN LoaiSP ON SanPham.MaLoai = LoaiSP.MaLoai";

                   
                    if (!string.IsNullOrEmpty(maLoai))
                    {
                        sql += " WHERE SanPham.MaLoai = @MaLoai";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        
                        if (!string.IsNullOrEmpty(maLoai))
                        {
                            cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            DataTable dt = ds.Tables[0];
                            dl_loaiSP.DataSource = dt;
                            dl_loaiSP.DataBind();
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                Response.Redirect("DangNhap.aspx");

           
           
        }

        protected void ImageButton2_Click(object sender, EventArgs e)
        {
           
                Response.Redirect("DangNhap.aspx");
           
           
        }
        
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           
                Response.Redirect("DangNhap.aspx");
            
            
        }
        protected void ImageButton1_Click(object sender, EventArgs e)
        {
           
               
                Response.Redirect("DangNhap.aspx");
          
        }
    }
}
