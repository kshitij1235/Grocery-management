﻿<%@ Page Title="" Language="C#"  MasterPageFile="~/Header_login.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Library_simple.Register" StylesheetTheme="Skin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form id="form1" runat="server">
        <div>
      
            <table style="width: 100%;">
                <tr>
                    <td>username</td>
                    <td> <asp:TextBox ID="textboxusername" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="username is required" ControlToValidate="textboxusername"></asp:RequiredFieldValidator></td>
                </tr>


                <tr>
                    <td>name</td>
                    <td id="name"><asp:TextBox ID="textboxname" runat="server"></asp:TextBox> </td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="name is required" ControlToValidate="textboxname"></asp:RequiredFieldValidator></td>
                </tr>


                <tr>
                    <td>password</td>
                    <td > <asp:TextBox ID="textboxpassword" runat="server"></asp:TextBox> </td>  
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="password is required" ControlToValidate="textboxpassword"></asp:RequiredFieldValidator></td>
                </tr>

                  <tr>
                    <td></td>
                    <td> <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" /> </td>
                    <td</td>
                </tr>

         


            </table>
        </div>
    </form>
</asp:Content>
