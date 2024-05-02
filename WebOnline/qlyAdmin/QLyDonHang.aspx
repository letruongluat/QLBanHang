<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="QLyDonHang.aspx.cs" Inherits="WebOnline.QLyDonHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%">
         <h2 class="fixed">Danh Sách Đơn Hàng</h2>
        <asp:GridView ID="GridViewSanPham" runat="server" AutoGenerateColumns="False" style="width:100%" >
    <Columns>
        <asp:BoundField DataField="TenDangNhap" HeaderText="Họ Và Tên" />
        <asp:BoundField DataField="TenTK" HeaderText="Tên Đăng Nhập" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="SDT" HeaderText="Số Điện Thoại" />
         <asp:BoundField DataField="MaDH" HeaderText="Mã Đơn Hàng" />
          <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />

        <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
         <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" />
        <asp:TemplateField HeaderText="Thao Tác">
            <ItemTemplate>
                <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" CommandArgument='<%# Eval("MaDH") %>' />
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" CommandArgument='<%# Eval("MaDH") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        <div class="action-buttons">
            <asp:Button ID="btnThem" runat="server" Text="Thêm" CssClass="add-product-button" OnClick="btnThem_Click" />
        </div>
    </div><br /><br /><br /><br /><br /><br />
</asp:Content>