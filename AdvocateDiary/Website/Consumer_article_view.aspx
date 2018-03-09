<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Consumer_article_view.aspx.cs" Inherits="Consumer_article_view" %>

<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
        <li><a href="Consumer_home_page.aspx">Home</a></li>
      <li><a href="Consumer_feedback_page.aspx">Feedback</a></li>
      <li><a href="Consumer_article.aspx" class="act">Articles</a></li>
      <li><a href="Consumer_settings_page.aspx">Settings</a></li>
      <li><a href="Consumer_search_page.aspx">Search</a></li>
      <li><a href="Consumer_Event.aspx">Event</a></li>
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
            <br />
            <table class="container">
                <tr>
                    <td style="width: 161px; height: 21px;"></td>
                    <td style="height: 21px">
                        <asp:TextBox ID="txtTopicname" runat="server" Width="219px" ReadOnly="True" BorderStyle="None" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 161px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 161px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 161px">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtTopicdescription" runat="server" Height="268px" TextMode="MultiLine" Width="407px" ReadOnly="True" BorderStyle="None" Font-Size="Small"></asp:TextBox>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtPostby" runat="server" BorderStyle="None" Width="159px" Font-Size="X-Small"></asp:TextBox>
                        <br />
                        <br />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" CssClass="myButton1" />
                    </td>
                </tr>
            </table>
        </div>
        </div>
        </form>
        </asp:Content>