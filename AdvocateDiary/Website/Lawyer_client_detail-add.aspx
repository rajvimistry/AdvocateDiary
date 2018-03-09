<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Lawyer_client_detail-add.aspx.cs" Inherits="Lawyer_client_detail_add" %>
<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
      <li><a href="Lawyer_homepage.aspx">Home</a></li>
      <li><a href="Lawyer_client_details.aspx" class="act">Client Details</a></li>
      <li><a href="Articles.aspx">Articles</a></li>
      <li><a href="Lawyer_setting_page.aspx">Settings</a></li>
      <li><a href="Lawyer_search_page.aspx">Search</a></li>
      <li><a href="Lawyer_event.aspx">Event</a></li>
      <%--<li><a href="sitemap.html">Site Map</a></li>--%>
      <li><a href="Login_page_lawyer_consumer.aspx">Logout</a></li>
       
    </ul>
        </asp:Content> 
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">

    <form id="form1" runat="server">

    <div style="text-align:right; width: 675px; height: 47px;"><font size="3"> Hi  </font> <asp:Label ID="lblHeaderMessage" runat="server" Font-Size="Medium"></asp:Label> 
            <br />
            <br />
            <br />
            </div>
        <table cellpadding="5" cellspacing="5" border="0" align="right" style="width: 488px">
        <tr>
        <td colspan="2" align="center">
            </td>
        </tr>
        <tr>
        <td style="width: 141px; height: 47px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name</td>
        <td style="width: 271px; height: 47px;"><asp:TextBox ID="txtName" runat="server" CssClass="input300" Width="200px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td style="width: 141px; height: 47px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Phone No.</td>
        <td style="width: 271px"><asp:TextBox ID="txtcontact" runat="server" CssClass="input300" Width="200px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcontact"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td style="width: 141px; height: 47px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            City</td>
        <td style="width: 271px; height: 28px"><asp:TextBox ID="txtCity" runat="server" CssClass="input300" Width="200px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCity"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td style="width: 141px; height: 47px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email Id</td>
        <td style="width: 271px; height: 47px;"><asp:TextBox ID="txtEmail" runat="server" CssClass="input300" Width="200px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td style="width: 141px; height: 47px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Details</td>
        <td style="width: 271px; height: 47px;">
            <asp:TextBox ID="txtDetail" runat="server" CssClass="input300" TextMode="MultiLine" Width="200px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDetail"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
        </tr>
            <tr>
                <td style="width: 141px; height: 47px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Remark</td>
                <td style="width: 271px; height: 47px;">
                    <asp:TextBox ID="txtRemark" runat="server" CssClass="input300" TextMode="MultiLine" Width="200px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtRemark"
                ErrorMessage="*" Font-Bold="True" Font-Size="Small">*</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
        <td colspan="2" align="center" style="height:70px";>
        <asp:Button ID="btnSave" runat="server" CssClass="myButton1" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="btnUpdate" runat="server" CssClass="myButton1" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="myButton1" Text="Cancel" CausesValidation="False" OnClick="btnCancel_Click" />
        </td>
        </tr>
        </table>
    </form>
</asp:Content>