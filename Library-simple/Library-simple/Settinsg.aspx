<%@ Page Title="" Language="C#" MasterPageFile="~/AfterLogin.Master" AutoEventWireup="true" CodeBehind="Settinsg.aspx.cs" Inherits="Library_simple.Settinsg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form id="form1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="update_details" OnClick="Button1_Click" />
         <asp:Button ID="Button2" runat="server" Text="Delete account" OnClick="Button2_Click" />
</form>
</asp:Content>
