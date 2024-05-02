<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="ChiTietSP.aspx.cs" Inherits="WebOnline.ChiTietSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2> Chi Tiết Sản Phẩm<br /></h2>
    <div class="col-md-6">
                <asp:Image ID="imgSanPham" runat="server" CssClass="img-fluid" Width="30%"/>
            </div>
            <div class="col-md-6">
                <h5><asp:Label ID="lblTenSP" runat="server" Text=""></asp:Label></h5>
                <asp:Label ID="lblDonGia" runat="server" Text=""></asp:Label><br /><br />
                Mô Tả Chi Tiết:<asp:Label ID="lblMoTa" runat="server" Text=""></asp:Label><br /><br /><br /><br /><br /><br />

              
            </div>
</asp:Content>
