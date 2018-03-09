<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="registration_page.aspx.cs" Inherits="registration_page" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="CPH1" runat="server">

    <form id="form1" runat="server">
          
    <div align="center">
    <table cellpadding="5" cellspacing="5" border="0" width="450" align="center" style="font-family:Calibri">
        <tr>
        <td colspan="2" align="center">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">&nbsp;First Name</td>
        <td class="auto-style2"><asp:TextBox ID="txtName" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td class="auto-style1">
            Last Name</td>
        <td class="auto-style2"><asp:TextBox ID="lname" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lname" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">Username</td>
        <td class="auto-style2"><asp:TextBox ID="uname" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="uname" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">
            Email</td>
        <td class="auto-style2">
            <asp:TextBox ID="email" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
            <tr>
                <td class="auto-style1">
                    Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="password" runat="server" CssClass="input300" TextMode="Password" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Confirm Password</td>
                <td class="auto-style2">
                    <asp:TextBox ID="c_password" runat="server" CssClass="input300" TextMode="Password" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="c_password" ErrorMessage="*"></asp:CompareValidator>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style3">
                    </td>
                <td class="auto-style4">
                    <asp:RadioButton ID="Lawyer" runat="server" Text="Lawyer" GroupName="a" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="Consumer" runat="server" Text="Consumer" GroupName="a" />
                </td>
            </tr>
            
            <tr>
                <td class="auto-style5">
                    Working Field</td>
                <td class="auto-style6">
                    <asp:TextBox ID="type" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox></td>
            </tr>
        <tr>
        <td class="auto-style1">
            Date of Birth</td>
        <td class="auto-style2"><asp:TextBox ID="txtDOB" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>&nbsp;<a href="javascript:NewCal('<%=txtDOB.ClientID %>','mmddyyyy')"><img src="images/cal.gif" width="16" height="16" border="0" alt="Pick a date"></a><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtDOB" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">
            Address</td>
        <td class="auto-style2"><asp:TextBox ID="txtAddress" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtAddress" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">
            Mobile</td>
        <td class="auto-style2"><asp:TextBox ID="txtMobile" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtMobile" ErrorMessage="*" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">
            Security Que</td>
        <td class="auto-style2"><asp:TextBox ID="txtQue" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtQue" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
        <td class="auto-style1">
            Answer</td>
        <td class="auto-style2"><asp:TextBox ID="txtAns" runat="server" CssClass="input300" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAns" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
            <tr>
        <td colspan="2" align="center">
        <asp:Button ID="Back" runat="server" CssClass="myButton1" Text="Back" CausesValidation="False" OnClick="Back_Click" />
        &nbsp;
        <asp:Button ID="btnUpdate" runat="server" CssClass="myButton1" Text="Register" OnClick="btnUpdate_Click" />
            &nbsp;
        <asp:Button ID="btnCancel" runat="server" CssClass="myButton1" Text="Cancel" CausesValidation="False" OnClick="btnCancel_Click" />
        </td>
        </tr>
        </table>
    </div>
            </form>
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 89px;
            height: 50px;
        }
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            width: 89px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 89px;
            height: 51px;
        }
        .auto-style6 {
            height: 51px;
        }
    </style>
</asp:Content>

