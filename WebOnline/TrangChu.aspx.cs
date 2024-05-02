using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOnline
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(sqlcon);
                con.Open();
                string sql = "SELECT SanPham.MaSV, SanPham.TenSP, SanPham.HinhAnh, SanPham.DonGia FROM SanPham  ";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dl_loaiSP.DataSource = dt;
                dl_loaiSP.DataBind();

                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] data = btn.CommandArgument.Split(';');
            string tenSP = data[0];
            string hinhAnh = data[1];
            string donGia = data[2];

          
            Response.Redirect($"GioHang.aspx?tenSP={tenSP}&hinhAnh={hinhAnh}&donGia={donGia}");
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            string[] data = btn.CommandArgument.Split(';');
            string tenSP = data[0];
            string hinhAnh = data[1];
            string donGia = data[2];

           
            Response.Redirect($"GioHang.aspx?tenSP={tenSP}&hinhAnh={hinhAnh}&donGia={donGia}");
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
