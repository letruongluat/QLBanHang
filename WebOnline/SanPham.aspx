<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebOnline.SanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="SanPham">
            <asp:DataList ID="dl_loaiSP" runat="server" RepeatDirection="Horizontal" Width="83%" style="margin-left: 200px; margin-right: 0px;" >
                <ItemTemplate>
                    <asp:ImageButton href="ChiTietSP.aspx" ID="ImageButton1" runat="server"  ImageUrl='<%# Eval("HinhAnh") %>' Width="70%" CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>'   OnClick="ImageButton2_Click"/>
                    <br />
                    <asp:LinkButton  ID="LinkButton1" runat="server" Text='<%# Eval("TenSP") %>' CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>' OnClick="LinkButton1_Click"></asp:LinkButton>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
                    <br />     
                   <asp:Button ID="Button1" runat="server" Text="Mua Hàng" CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>' OnClick="Button1_Click" />

                  <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="anh/giohang.png" Width="30px" CommandArgument='<%# Eval("TenSP") + ";" + Eval("HinhAnh") + ";" + Eval("DonGia") %>'  OnClick="ImageButton1_Click"/>
                </ItemTemplate>
            </asp:DataList><br /><br />
        </div>
    <br />
    <br />
    <br />
</asp:Content>

