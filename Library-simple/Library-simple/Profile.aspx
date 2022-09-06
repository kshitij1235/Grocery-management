<%@ Page Title="" Language="C#" MasterPageFile="~/AfterLogin.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Library_simple.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


       <form id="form1" runat="server">
    <asp:Label runat="server" Text="Username : "></asp:Label>
    <asp:TextBox runat="server" ID="textboxusernamename"></asp:TextBox>
    
        <br />
    
    <asp:Label runat="server" Text="name : "></asp:Label>
    <asp:TextBox runat="server" ID="textboxname"></asp:TextBox>
        <br />

    <asp:Label runat="server" Text="password : "></asp:Label>
    <asp:TextBox runat="server" ID="textboxpassword"></asp:TextBox>
    <br />
           </form>
</asp:Content>
