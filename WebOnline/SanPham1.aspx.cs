using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOnline
{
    public partial class SanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string maLoai = Request.QueryString["MaLoai"];
                if (!string.IsNullOrEmpty(maLoai))
                {
                    // Nếu maLoai không null và không rỗng, thực hiện các thao tác tương ứng
                    string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        string sql = "SELECT SanPham.MaSV, SanPham.TenSP, SanPham.HinhAnh, SanPham.DonGia, LoaiSP.TenLoai FROM SanPham INNER JOIN LoaiSP ON SanPham.MaLoai = LoaiSP.MaLoai WHERE SanPham.MaLoai = @MaLoai";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@MaLoai", maLoai);

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
                else
                {
                   
                    string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(sqlcon))
                    {
                        con.Open();
                        string sql = "SELECT SanPham.MaSV, SanPham.TenSP, SanPham.HinhAnh, SanPham.DonGia, LoaiSP.TenLoai FROM SanPham INNER JOIN LoaiSP ON SanPham.MaLoai = LoaiSP.MaLoai";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
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

                // Tiếp tục thực hiện các thao tác khác sau khi xử lý maLoai
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] data = btn.CommandArgument.Split(';');
            string maSP = data[0]; 
            string tenSP = data[1];
            string hinhAnh = data[2];
            string donGia = data[3];


            Response.Redirect($"GioHang.aspx?maSP={maSP}&tenSP={tenSP}&hinhAnh={hinhAnh}&donGia={donGia}");
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            string[] data = btn.CommandArgument.Split(';');
            string maSP = data[0];
            string tenSP = data[1];
            string hinhAnh = data[2];
            string donGia = data[3];


            Response.Redirect($"GioHang.aspx?maSP={maSP}&tenSP={tenSP}&hinhAnh={hinhAnh}&donGia={donGia}");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string[] data = btn.CommandArgument.Split(';');
            string tenSP = data[0];
            string hinhAnh = data[1];
            string donGia = data[2];

            Response.Redirect($"ChiTietSP.aspx?tenSP={tenSP}&hinhAnh={hinhAnh}&donGia={donGia}");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            string[] data = btn.CommandArgument.Split(';');
            string tenSP = data[0];
            string hinhAnh = data[1];
            string donGia = data[2];

          
            Response.Redirect($"ChiTietSP.aspx?tenSP={tenSP}&hinhAnh={hinhAnh}&donGia={donGia}");
        }
    }
}
