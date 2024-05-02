<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="WebOnline.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2 class="dk">Đăng Ký Tài Khoản</h2>
         Họ Và Tên: <asp:TextBox ID="txttendn" runat="server" style="margin-left: 50px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Phải Nhập Tên" ControlToValidate="txttendn"
                Display="Dynamic" Font-Bold="true" Font-Italic="true" ForeColor="Red">
            </asp:RequiredFieldValidator><br />
     
        </div><br />
    <div>
     Tên Đăng Nhập: <asp:TextBox ID="txtten" runat="server" style="margin-left: 19px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Phải Nhập Tên" ControlToValidate="txtten"
                Display="Dynamic" Font-Bold="true" Font-Italic="true" ForeColor="Red">
            </asp:RequiredFieldValidator><br />
     
        </div><br />
    <div>
            Mật Khẩu: <asp:TextBox ID="txtpass" runat="server" TextMode="Password" style="margin-left: 58px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Nhập Mật Khẩu" ControlToValidate="txtpass" Display="Dynamic" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div><br />
    <div>
            Nhập Lại MK: <asp:TextBox ID="txtpass1" runat="server" TextMode="Password" style="margin-left: 31.5px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ErrorMessage="2 MK phải giống nhau"
                ControlToValidate="txtpass1" ControlToCompare="txtpass" Operator="Equal" Type="String" Display="Dynamic" ForeColor="Red"></asp:CompareValidator>
        </div><br />
    <div>
      Email: <asp:TextBox ID="txtemail" runat="server" style="margin-left: 83.5px" ></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="email phải đúng định dạng" ControlToValidate="txtemail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div><br />
    <div>
       Số Điện Thoại:  <asp:TextBox ID="txtsdt" runat="server"  style="margin-left: 30px" Width="162px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ErrorMessage="Phải Nhập Số Điện Thoại" ControlToValidate="txtsdt"
                Display="Dynamic" Font-Bold="true" Font-Italic="true" ForeColor="Red">
            </asp:RequiredFieldValidator><br /><br /><br />
    </div>
        <span id="tenDangNhapError" class="error-message" ></span>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Đăng Ký" style="margin-left: 149px" Width="115px" OnClick="Button1_Click"  />

       </div><br /><br /><br />
  
</asp:Content>
