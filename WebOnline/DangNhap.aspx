<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="WebOnline.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h2 class="dk">Đăng Nhập Tài Khoản</h2>
     Tên Đăng Nhập: <asp:TextBox ID="txtten" runat="server" style="margin-left: 19px"></asp:TextBox>
       
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Phải Nhập Tên" ControlToValidate="txtten"
                Display="Dynamic" Font-Bold="true" Font-Italic="true" ForeColor="Red">
            </asp:RequiredFieldValidator><br />
        </div><br />
    <div>
            Mật Khẩu: <asp:TextBox ID="txtpass" runat="server" TextMode="Password" style="margin-left: 58px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Nhập Mật Khẩu" ControlToValidate="txtpass" Display="Dynamic">
            </asp:RequiredFieldValidator>
        </div><br />
      <span id="tenDangNhapError" class="error-message" ></span><br />
<div>
    <asp:Button ID="Button1" runat="server" Text="Đăng Nhập" style="margin-left: 149px" Width="115px" OnClick="Button1_Click" /></div>
  

          
    
</asp:Content>
