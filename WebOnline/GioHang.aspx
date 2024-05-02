    <%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WebOnline.GioHang" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
            .col-md-6 {
            }
            .btn-primary {
                font-weight: 700;
                margin-left: 61px;
            }
        </style>
    </asp:Content>

    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="modal-header">
            <h2 style="color:red">Giỏ Hàng</h2>
        </div>
        <div class="modal-body">
            <div class="row">
                <div class="col-md-6">
                    <asp:Image ID="imgSanPham" runat="server" CssClass="img-fluid" Width="30%" />
                </div>
                <div class="col-md-6">
                    <h5>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblTenSP" runat="server" Text=""></asp:Label></h5>
                    Số lượng: <asp:TextBox ID="txtSoLuong" runat="server" style="margin-left: 21px"></asp:TextBox><br /><br />
                    Đơn Giá:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblDonGia" runat="server" Text=""></asp:Label> VND
                    <br />
                </div>
                <div>
                    <br />
                    Tên: <asp:TextBox ID="txttenDN" runat="server" style="font-weight: 700; margin-left: 60px" Width="161px"></asp:TextBox><br /><br />
                    Email: <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 46px"></asp:TextBox><br /><br />
                    Số điện thoại: <asp:TextBox ID="txtSoDienThoai" runat="server"></asp:TextBox><br />
                </div>
            </div>
        </div><br />
        <div class="modal-footer">
            <asp:Button ID="btnDatHang" runat="server" Text="Đặt hàng" OnClick="btnDatHang_Click" CssClass="btn btn-primary" Width="128px" />
            <br /><br /><br /><br /><br /><br /><br /><br />
        </div>
    </asp:Content>
