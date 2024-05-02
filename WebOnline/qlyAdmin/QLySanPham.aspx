<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="QLySanPham.aspx.cs" Inherits="WebOnline.qlyAdmin.QLySanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
   

        .action-buttons {
            text-align: right;
        }

        .add-product-button {
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:100%">
        <h2 class="fixed">Danh Sách Sản Phẩm</h2>
        <asp:GridView ID="GridViewSanPham" runat="server" AutoGenerateColumns="False" style="width:100%">
    <Columns>
        <asp:BoundField DataField="MaSV" HeaderText="Mã Sản Phẩm" />
        <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
        <asp:BoundField DataField="DonGia" HeaderText="Giá" />
        <asp:BoundField DataField="SL" HeaderText="Số Lượng" />
        <asp:TemplateField HeaderText="Hình Ảnh">
            <ItemTemplate>
                <asp:Image ID="imgHinhAnh" runat="server" ImageUrl='<%# Eval("HinhAnh") %>' Height="100px" Width="100px" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="MoTa" HeaderText="Mô Tả" />
        <asp:TemplateField HeaderText="Thao Tác">
            <ItemTemplate>
                <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" CommandArgument='<%# Eval("MaSV") %>' />
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" CommandArgument='<%# Eval("MaSV") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

        <div class="action-buttons">
            <asp:Button ID="btnThem" runat="server" Text="Thêm" CssClass="add-product-button" OnClick="btnThem_Click" />
        </div><br /><br /><br /><br />
    </div><br /><br /><br /><br /><br />
</asp:Content>
