<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Consumer_home_page.aspx.cs" Inherits="Consumer_home_page" %>

<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
        <li><a href="Consumer_home_page.aspx" class="act">Home</a></li>
      <li><a href="Consumer_feedback_page.aspx">Feedback</a></li>
      <li><a href="Consumer_article.aspx">Articles</a></li>
      <li><a href="Consumer_settings_page.aspx">Settings</a></li>
      <li><a href="Consumer_search_page.aspx">Search</a></li>
      <li><a href="Consumer_Event.aspx">Event</a></li>
          <%--<li><a href="sitemap.html">Site Map</a></li>--%>
      <li><a href="Login_page_lawyer_consumer.aspx">Logout</a></li>
       
    </ul>
        </asp:Content> 
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">
     <form id="form1" runat="server">
        <div style="text-align:right"><font size="3"> Hi  </font> <asp:Label ID="lblHeaderMessage" runat="server" Font-Size="Medium"></asp:Label> 
            <br />
            <br />
            <br />
            <div align="center">
            <asp:TextBox ID="txtEvent" runat="server" BorderStyle="Dashed" Font-Size="Large"></asp:TextBox>
                <br />
                <br />
                 <asp:GridView ID="gvMaster" runat="server" AllowPaging="True" AutoGenerateColumns="False" BorderColor="#000000" BorderStyle="None" CellPadding="4" Font-Size="Medium" ForeColor="#000000" GridLines="Both" OnPageIndexChanging="gvMaster_PageIndexChanging" OnRowCommand="gvMaster_RowCommand" OnRowDataBound="gvMaster_RowDataBound" OnRowDeleting="gvMaster_RowDeleting" PageSize="10" Width="104%">
                    <Columns>
                <%--<asp:TemplateField HeaderText="Rights">--%>
                   <%-- <ItemTemplate>
                        <asp:Label runat="server" ID="lblRights" Text='<%# getRights(Convert.ToInt32(Eval("Rights"))) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="70px" HorizontalAlign="Center" />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>--%>
                        <asp:BoundField DataField="Event_name" HeaderText="Event">
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Date1" DataFormatString="{0:dd MMMM yyyy}" HeaderText="Date">
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Time" HeaderText="Time">
                        <HeaderStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                <%--<asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbEdit" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("Client_name") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="50px" HorizontalAlign="Center"  />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>--%>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbDelete" runat="server" CommandArgument='<%# Eval("Event_name") %>' CommandName="Delete" Text="Delete"></asp:LinkButton>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                            <HeaderStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                    <PagerStyle BackColor="#2461BF" Font-Bold="true" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="White" ForeColor="Black" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
                    <AlternatingRowStyle BackColor="#EFF3FB" />
                </asp:GridView></div>
            <br />
&nbsp;</div>
         </form>
    </asp:Content>
