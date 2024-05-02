<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="EditSanPham.aspx.cs" Inherits="WebOnline.qlyAdmin.EditSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Custom CSS styles */
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Sửa Sản Phẩm</h2>
  
    <asp:TextBox ID="txtMaSP" runat="server" placeholder="Mã Sản Phẩm"></asp:TextBox>
    <asp:TextBox ID="txtTenSP" runat="server" placeholder="Tên Sản Phẩm"></asp:TextBox>
    <asp:TextBox ID="txtGia" runat="server" placeholder="Giá"></asp:TextBox>
    <asp:TextBox ID="txtSL" runat="server" placeholder="Số Lượng"></asp:TextBox>
   
    <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật Sản Phẩm" OnClick="btnCapNhat_Click" />
</asp:Content>
