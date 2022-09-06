<%@ Page Title="" Language="C#" MasterPageFile="~/AfterLogin.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Library_simple.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <form id="form1" runat="server">
    <asp:Label runat="server" Text="Username : "></asp:Label>
    <asp:TextBox runat="server" ID="textboxusernamename"></asp:TextBox>
           ->
    </asp:TextBox><asp:TextBox ID="changeuser" runat="server"></asp:TextBox>
    
        <br />
    
    <asp:Label runat="server" Text="name : "></asp:Label>
    <asp:TextBox runat="server" ID="textboxname"></asp:TextBox>->
   </asp:TextBox><asp:TextBox ID="changename" runat="server"></asp:TextBox>
        <br />

    <asp:Label runat="server" Text="password : "></asp:Label>
    <asp:TextBox runat="server" ID="textboxpassword"></asp:TextBox>->
           </asp:TextBox><asp:TextBox ID="changepass" runat="server"></asp:TextBox>
    <br />
           <asp:Button runat="server" Text="updade" OnClick="Unnamed4_Click" />
           </form>
</asp:Content>
