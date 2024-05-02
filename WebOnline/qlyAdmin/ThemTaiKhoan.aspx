<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="ThemTaiKhoan.aspx.cs" Inherits="WebOnline.qlyAdmin.ThemTaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Custom CSS styles */
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h2 class="dk">Thêm Tài Khoản</h2>
         Họ Và Tên: <asp:TextBox ID="txttendn" runat="server" style="margin-left: 50px"></asp:TextBox>
           <br />
     
        </div><br />
    <div>
     Tên Đăng Nhập: <asp:TextBox ID="txtten" runat="server" style="margin-left: 19px"></asp:TextBox>
           <br />
     
        </div><br />
    <div>
            Mật Khẩu: <asp:TextBox ID="txtpass" runat="server" TextMode="Password" style="margin-left: 58px"></asp:TextBox>
        </div><br />
      <div>
      Email: <asp:TextBox ID="txtemail" runat="server" style="margin-left: 83.5px" ></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="email phải đúng định dạng" ControlToValidate="txtemail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div><br />
    <div>
       Số Điện Thoại:  <asp:TextBox ID="txtsdt" runat="server"  style="margin-left: 30px" Width="162px"></asp:TextBox>
         <br /><br /><br />

       </div><br />

    <asp:Button ID="btnThem" runat="server" Text="Thêm Tài Khoản" OnClick="btnThem_Click" /><br />   <br /><br /><br />
</asp:Content>
