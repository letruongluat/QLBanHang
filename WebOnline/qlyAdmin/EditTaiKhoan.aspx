<%@ Page Title="" Language="C#" MasterPageFile="~/qlyAdmin/TrangChuAdmin.Master" AutoEventWireup="true" CodeBehind="EditTaiKhoan.aspx.cs" Inherits="WebOnline.qlyAdmin.EditTaiKhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
   
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
        <h2 class="dk">Sửa Tài Khoản</h2>
         Họ Và Tên: <asp:TextBox ID="txttendn" runat="server" style="margin-left: 50px"></asp:TextBox>
           <br />
     
        </div><br />
    <div>
     Tên Đăng Nhập: <asp:TextBox ID="txtten" runat="server" style="margin-left: 19px"></asp:TextBox>
           <br />
     
        </div><br />
    <div>
            Mật Khẩu: <asp:TextBox ID="txtpass" runat="server" TextMode="Password" style="margin-left: 58px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Nhập Mật Khẩu" ControlToValidate="txtpass" Display="Dynamic" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div><br />
    <div>
      Email: <asp:TextBox ID="txtemail" runat="server" style="margin-left: 83.5px" ></asp:TextBox>
        </div><br />
    <div>
       Số Điện Thoại:  <asp:TextBox ID="txtsdt" runat="server"  style="margin-left: 30px" Width="162px"></asp:TextBox>
         <br /><br /><br />

       </div><br />
    <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật Tài Khoản" OnClick="btnCapNhat_Click" /><br /><br /><br />
</asp:Content>
