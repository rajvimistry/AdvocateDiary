<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Main_login_page.aspx.cs" Inherits="Main_login_page" %>

<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">
    <form id="form1" runat="server">
        <table class="container">
            <tr>
                <td style="width: 201px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 201px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server" Height="30px" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 201px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 201px; height: 52px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password</td>
                <td style="height: 52px">
                    <asp:TextBox ID="txtPassword" runat="server" Height="30px" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 201px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 40px; width: 201px"></td>
                <td style="height: 40px"></td>
            </tr>
            <tr>
                <td style="width: 201px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="Lawyer" runat="server" Height="30px" Text="Lawyer" />
                </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="Consumer" runat="server" Height="30px" Text="Consumer" />
                </td>
            </tr>
            <tr>
                <td style="width: 201px">&nbsp;</td>
                <td>
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 201px">&nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" Width="153px" />
                </td>
            </tr>
        </table>
    </form>
    </asp:Content>