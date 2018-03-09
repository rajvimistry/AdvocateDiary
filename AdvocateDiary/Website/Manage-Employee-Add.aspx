<%@ Page Language="C#" MasterPageFile="~/default.master" AutoEventWireup="true" CodeFile="Manage-Employee-Add.aspx.cs" Inherits="Manage_Employee_Add" %>
<%@ Register Src="includes/ucRightMenu.ascx" TagName="ucRightMenu" TagPrefix="uc1" %>
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">

    <div class="title">Add/Edit Lawyer Details<br /><br /></div>
        <table cellpadding="5" cellspacing="5" border="0" width="450" align="center">
        <tr>
        <td colspan="2" align="center">
            &nbsp;</td>
        </tr>
        <tr>
        <td style="width: 89px">&nbsp;First Name</td>
        <td><asp:TextBox ID="txtName" runat="server" CssClass="input300"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td style="width: 89px">
            Last Name</td>
        <td><asp:TextBox ID="lname" runat="server" CssClass="input300"></asp:TextBox></td>
        </tr>
        <tr>
        <td style="width: 89px">Username</td>
        <td><asp:TextBox ID="uname" runat="server" CssClass="input300"></asp:TextBox></td>
        </tr>
        <tr>
        <td style="width: 89px">
            Email</td>
        <td>
            <asp:TextBox ID="email" runat="server" CssClass="input300"></asp:TextBox></td>
        </tr>
            <tr>
                <td style="width: 89px">
                    Password</td>
                <td>
                    <asp:TextBox ID="password" runat="server" CssClass="input300"></asp:TextBox>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 89px">
                    Confirm Password</td>
                <td>
                    <asp:TextBox ID="c_password" runat="server" CssClass="input300"></asp:TextBox>&nbsp;</td>
            </tr>
            
            <tr>
                <td style="width: 89px">
                    Working Field</td>
                <td>
                    <asp:TextBox ID="type" runat="server" CssClass="input300"></asp:TextBox></td>
            </tr>
        <tr>
        <td style="width: 89px">
            Date of Birth</td>
        <td><asp:TextBox ID="txtDOB" runat="server" CssClass="input300"></asp:TextBox>&nbsp;<a href="javascript:NewCal('<%=txtDOB.ClientID %>','mmddyyyy')"><img src="images/cal.gif" width="16" height="16" border="0" alt="Pick a date"></a></td>
        </tr>
        <tr>
        <td style="width: 89px">
            Address</td>
        <td><asp:TextBox ID="txtAddress" runat="server" CssClass="input300"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td style="width: 89px">
            Mobile</td>
        <td><asp:TextBox ID="txtMobile" runat="server" CssClass="input300"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td style="width: 89px">
            Security Que</td>
        <td><asp:TextBox ID="txtQue" runat="server" CssClass="input300"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td style="width: 89px">
            Answer</td>
        <td><asp:TextBox ID="txtAns" runat="server" CssClass="input300"></asp:TextBox>
            </td>
        </tr>
            <tr>
        <td colspan="2" align="center">
        <asp:Button ID="btnSave" runat="server" CssClass="buttonBlue" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnUpdate" runat="server" CssClass="buttonBlue" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="buttonBlue" Text="Cancel" CausesValidation="False" OnClick="btnCancel_Click" />
        </td>
        </tr>
        </table>
</asp:Content>
<asp:Content ID="cRightMenu" runat="server" ContentPlaceHolderID="cphRight">
    <uc1:ucRightMenu ID="UcRightMenu1" runat="server" />
</asp:Content>