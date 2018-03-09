<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Consumer_feedback_page.aspx.cs" Inherits="Consumer_feedback_page" %>

<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
        <li><a href="Consumer_home_page.aspx">Home</a></li>
      <li><a href="Consumer_feedback_page.aspx" class="act">Feedback</a></li>
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
        </div>
         <asp:GridView ID="gvMaster" runat="server" CssClass="input100" AutoGenerateColumns="False" CellPadding="4" ForeColor="#000000" Font-Size="Medium" GridLines="Both" BorderStyle="Solid" BorderColor="#000000" Width="104%"   AllowPaging="True" OnRowCommand="gvMaster_RowCommand" OnRowDataBound="gvMaster_RowDataBound" OnRowDeleting="gvMaster_RowDeleting" OnPageIndexChanging="gvMaster_PageIndexChanging" PageSize="10" CellSpacing="0">
            
            <Columns>
                <%--<asp:TemplateField HeaderText="Rights">--%>
                   <%-- <ItemTemplate>
                        <asp:Label runat="server" ID="lblRights" Text='<%# getRights(Convert.ToInt32(Eval("Rights"))) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="70px" HorizontalAlign="Center" />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>--%>
                <asp:BoundField DataField="Lawyername" HeaderText="Lawyer Name" ItemStyle-Width="370">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Working_field" HeaderText="Working Area">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbEdit" Text="Go" CommandName="Edit" CommandArgument='<%# Eval("Lawyername") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="50px" HorizontalAlign="Center"  />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>
               <%-- <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbDelete" Text="GO" CommandName="Delete" CommandArgument='<%# Eval("Lawyer_name") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="50px" HorizontalAlign="Center"  />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>--%>
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Font-Bold="true"  />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#80b5ea" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#80b5ea" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <AlternatingRowStyle BackColor="#EFF3FB" />
        </asp:GridView>
         </form>
    </asp:Content>