<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="QLyTaiKhoan1.aspx.cs" Inherits="WebOnline.qlyAdmin.QLyTaiKhoan1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%">
         <h2 class="fixed">Danh Sách Tài Khoản</h2>
        <asp:GridView ID="GridViewSanPham" runat="server" AutoGenerateColumns="False" style="width:100%" >
    <Columns>
        <asp:BoundField DataField="TenDangNhap" HeaderText="Họ Và Tên" />
        <asp:BoundField DataField="TenTK" HeaderText="Tên Đăng Nhập" />
        <asp:BoundField DataField="MatKhau" HeaderText="Mật Khẩu" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="SDT" HeaderText="Số Điện Thoại" />
        <asp:TemplateField HeaderText="Thao Tác">
            <ItemTemplate>
                <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" CommandArgument='<%# Eval("TenTK") %>' />
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" CommandArgument='<%# Eval("TenTK") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        <div class="action-buttons">
            <asp:Button ID="btnThem" runat="server" Text="Thêm" CssClass="add-product-button" OnClick="btnThem_Click" />
        </div>
    </div><br /><br /><br /><br /><br />
</asp:Content>
