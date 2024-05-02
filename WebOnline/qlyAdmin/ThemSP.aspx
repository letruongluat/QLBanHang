
<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="ThemSP.aspx.cs" Inherits="WebOnline.qlyAdmin.ThemSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Thêm Sản Phẩm</h2>

    <asp:TextBox ID="txtMaSP" runat="server" placeholder="Mã Sản Phẩm"></asp:TextBox>
    <asp:TextBox ID="txtTenSP" runat="server" placeholder="Tên Sản Phẩm"></asp:TextBox>
    <asp:TextBox ID="txtGia" runat="server" placeholder="Giá"></asp:TextBox>
    <asp:TextBox ID="txtSL" runat="server" placeholder="Số Lượng"></asp:TextBox>
 <asp:FileUpload ID="FileUploadHinhAnh" runat="server" />


    <asp:Button ID="btnThem" runat="server" Text="Thêm Sản Phẩm" OnClick="btnThem_Click" />
</asp:Content>

