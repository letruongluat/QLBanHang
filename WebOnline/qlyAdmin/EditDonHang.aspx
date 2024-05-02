<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="EditDonHang.aspx.cs" Inherits="WebOnline.qlyAdmin.EditDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Sửa Đơn Hàng</h2>
    <div>
         Họ Và Tên: <asp:TextBox ID="txttendn" runat="server" style="margin-left: 50px"></asp:TextBox>
           <br />
     
        </div><br />
    <div>
     Tên Đăng Nhập: <asp:TextBox ID="txtten" runat="server" style="margin-left: 19px"></asp:TextBox>
           <br />
     
        </div><br />
    <div>
      Email: <asp:TextBox ID="txtemail" runat="server" style="margin-left: 83.5px" ></asp:TextBox>
        </div><br />
    <div>
       Số Điện Thoại:  <asp:TextBox ID="txtsdt" runat="server"  style="margin-left: 30px" Width="162px"></asp:TextBox>
</div><br />
  Mã Đơn Hàng:  <asp:TextBox ID="txtMaDh" runat="server" placeholder="Mã Đơn Hàng" style="margin-left: 30px"></asp:TextBox><br /><br />
  Số Lượng:  <asp:TextBox ID="txtSoLuong" runat="server" placeholder="Số Lượng" style="margin-left: 57px"></asp:TextBox><br /><br />
  Tổng Tiền:  <asp:TextBox ID="txtTongTien" runat="server" placeholder="Tổng Tiền" style="margin-left: 52px"></asp:TextBox><br /><br /><br /><br />
 
   
    <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật Sản Phẩm" OnClick="btnCapNhat_Click" style="margin-left: 69px" />
</asp:Content>

