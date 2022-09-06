<%@ Page Title="" Language="C#" MasterPageFile="~/AfterLogin.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Library_simple.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       
    <form id="form1" runat="server">
           <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" /> 
       </form>

    <br/>

</asp:Content>
