<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Article_add_new_topic.aspx.cs" Inherits="Article_add_new_topic" %>

<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
      <li><a href="Lawyer_homepage.aspx">Home</a></li>
      <li><a href="Lawyer_client_details.aspx">Client Details</a></li>
      <li><a href="Articles.aspx" class="act">Articles</a></li>
      <li><a href="Lawyer_setting_page.aspx">Settings</a></li>
      <li><a href="Laswer_search_pge.aspx">Search</a></li>
      <li><a href="Lawyer_event.aspx">Event</a></li>
          <%--<li><a href="sitemap.html">Site Map</a></li>--%>
      <li><a href="Login_page_lawyer_consumer.aspx">Logout</a></li>
       
    </ul>
        </asp:Content> 
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">
    <form id="form1" runat="server">
    <div id="subforum" style="width: 655px">
        <div style="text-align:right"><font size="3"> Hi  </font> <asp:Label ID="lblHeaderMessage" runat="server" Font-Size="Medium"></asp:Label> 
            <br />
            <br />
            <br />
            <table class="container">
                <tr>
                    <td style="width: 252px">&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Topic Name</td>
                    <td>
                        <asp:TextBox ID="txtTopicname" runat="server" Width="196px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTopicname" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 252px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 252px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Description&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtTopicdescription" runat="server" Height="280px" TextMode="MultiLine" Width="325px" BorderColor="#0099CC" BorderStyle="Solid"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTopicdescription" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 252px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 252px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 252px; height: 18px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" CssClass="myButton1" />
                    </td>
                    <td style="height: 18px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="cancel" runat="server" OnClick="cancel_Click" Text="Cancel" CssClass="myButton1" />
                    </td>
                </tr>
            </table>
        </div>
       </div>
         </form>
    </asp:Content>