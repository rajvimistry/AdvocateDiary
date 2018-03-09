<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Consumer_article.aspx.cs" Inherits="Consumer_article" %>

<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
        <li><a href="Consumer_home_page.aspx">Home</a></li>
      <li><a href="Consumer_feedback_page.aspx">Feedback</a></li>
      <li><a href="Consumer_article.aspx" class="act">Articles</a></li>
      <li><a href="Consumer_settings_page.aspx">Settings</a></li>
      <li><a href="Consumer_search_page.aspx">Search</a></li>
      <li><a href="Consumer_Event.aspx">Events</a></li>
          <%--<li><a href="sitemap.html">Site Map</a></li>--%>
      <li><a href="Login_page_lawyer_consumer.aspx">Logout</a></li>
       
    </ul>
        </asp:Content> 
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">
     <form id="form1" runat="server">
        <div style="text-align:right"><font size="3"> Hi  </font> <asp:Label ID="lblHeaderMessage" runat="server" Font-Size="Medium"></asp:Label> 
            </div>
         <div>
         <asp:DataList ID="dtlDoctors" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal" Font-Size="Medium">
             <ItemTemplate>
                        <li>
                           <%-- <img width="99" height="115" alt="" src="<%# Eval("PathImage") %>" />--%>
                            <h3>
                                <a href="Consumer_article_view.aspx?Topic_name=<%# Eval("Topic_name") %>">
                                    <%# Eval("Topic_Name") %>
                                </a>
                            </h3>
                            <p class="indent2">
                                 <%# util.StringExtensions(Eval("Topic_Description").ToString(),50) %>
                            </p>
                        </li>
                    </ItemTemplate>
             </asp:DataList>
             </div>
         </form>
    </asp:Content>