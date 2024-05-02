<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WebOnline.TrangChu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .product-item {
            float: left;
            width: 30%; /* 30% width để hiển thị 3 sản phẩm trên mỗi hàng */
            margin: 10px;
        }
        .product-name {
            width:100%;

        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="SanPham"> 
        <asp:DataList ID="dl_loaiSP" runat="server" RepeatDirection="Horizontal" RepeatColumns="3" Width="80%" style="margin-left: 200px;">
            <ItemTemplate>
                <div class="product-item">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("HinhAnh") %>' Width="200px" Height="200px" CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>' OnClick="ImageButton2_Click" />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TenSP") %>' CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>' OnClick="LinkButton1_Click" ></asp:LinkButton>
                    <br />
                    <asp:Label CssClass="product-name" ID="Label1" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
                    <asp:Button ID="Button2" runat="server" Text="Mua Hàng" CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>' OnClick="Button1_Click" />
                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="anh/giohang.png" Width="30px" CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>' OnClick="ImageButton1_Click"/>
                    <br />     
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>