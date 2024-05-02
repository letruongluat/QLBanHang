<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="WebOnline.TimKiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
            <asp:DataList ID="dlSearchResults" runat="server" RepeatColumns="3">
                <ItemTemplate>
                    <div style="padding: 10px; border: 1px solid #ccc; margin: 5px;">
                        <img src='<%# Eval("HinhAnh") %>' alt='<%# Eval("TenSP") %>' width="100" height="100" />
                        <br />
                        <strong><%# Eval("TenSP") %></strong>
                        <br />
                        Đơn Giá: <%# Eval("DonGia", "{0:C}") %>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
</asp:Content>
