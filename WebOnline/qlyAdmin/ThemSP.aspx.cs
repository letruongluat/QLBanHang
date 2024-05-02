using System;
using System.Data.SqlClient;
using System.IO;

namespace WebOnline.qlyAdmin
{
    public partial class ThemSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            
            string maSV = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string donGia = txtGia.Text;
            string sL = txtSL.Text;

           
            string hinhAnhPath = LưuẢnhVàTrảVềĐườngDẫn();

           
            ThemSanPhamVaoCSDL(maSV, tenSP, donGia, sL, hinhAnhPath);

          
            Response.Redirect("QLySanPham.aspx");
        }

        private string LưuẢnhVàTrảVềĐườngDẫn()
        {
            if (FileUploadHinhAnh.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadHinhAnh.FileName);
                    string path = Server.MapPath("anh/") + filename;
                    FileUploadHinhAnh.SaveAs(path);
                  
                    return "anh/" + filename;
                }
                catch (Exception ex)
                {
                   
                    return string.Empty;
                }
            }
            else
            {
              
                return string.Empty;
            }
        }

        protected void ThemSanPhamVaoCSDL(string maSP, string tenSP, string donGia, string sL, string hinhAnhPath)
        {
           
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KyThuatTMDT\baitap\WebOnline\WebOnline\App_Data\DataBase.mdf;Integrated Security=True";
           
            string query = "INSERT INTO SanPham (MaSV, TenSP, DonGia, SL, HinhAnh) VALUES (@MaSV, @TenSP, @DonGia, @SL, @HinhAnh)";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@MaSV", maSP);
                command.Parameters.AddWithValue("@TenSP", tenSP);
                command.Parameters.AddWithValue("@DonGia", donGia);
                command.Parameters.AddWithValue("@SL", sL);
                command.Parameters.AddWithValue("@HinhAnh", hinhAnhPath);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
