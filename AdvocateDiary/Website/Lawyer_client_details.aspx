<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Lawyer_client_details.aspx.cs" Inherits="Lawyer_client_details" %>
<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
      <li><a href="Lawyer_homepage.aspx">Home</a></li>
      <li><a href="Lawyer_client_details.aspx" class="act">Client Details</a></li>
      <li><a href="Articles.aspx">Articles</a></li>
      <li><a href="lawyer_setting_page.aspx">Settings</a></li>
      <li><a href="Lawyer_search_page.aspx">Search</a></li>
      <li><a href="Lawyer_event.aspx">Event</a></li>
          <%--<li><a href="sitemap.html">Site Map</a></li>--%>
      <li><a href="Login_page_lawyer_consumer.aspx">Logout</a></li>
       
    </ul>
        </asp:Content> 
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">
    <form id="form1" runat="server" style="width: 644px">
        <div style="text-align:right; width: 675px; height: 47px;"><font size="3"> Hi  </font> <asp:Label ID="lblHeaderMessage" runat="server" Font-Size="Medium"></asp:Label> 
            <br />
            <br />
            <br />
            </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div align="right"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add new detail" CssClass="myButton1" /></div>
            <br />
            <br /> 
        <asp:GridView ID="gvMaster" runat="server" CssClass="input100" AutoGenerateColumns="False" CellPadding="4" ForeColor="#000000" Font-Size="Medium" GridLines="Both" BorderStyle="Solid" BorderColor="#000000" Width="104%"   AllowPaging="True" OnRowCommand="gvMaster_RowCommand" OnRowDataBound="gvMaster_RowDataBound" OnRowDeleting="gvMaster_RowDeleting" OnPageIndexChanging="gvMaster_PageIndexChanging" PageSize="10" CellSpacing="0">
            
            <Columns>
                <%--<asp:TemplateField HeaderText="Rights">--%>
                   <%-- <ItemTemplate>
                        <asp:Label runat="server" ID="lblRights" Text='<%# getRights(Convert.ToInt32(Eval("Rights"))) %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle Width="70px" HorizontalAlign="Center" />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>--%>
                <asp:BoundField DataField="client_name" HeaderText=" Name">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="mobile" HeaderText="Contact No">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="email" HeaderText="Email Id">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="details" HeaderText="Other Details">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="address" HeaderText="Address">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="remarks" HeaderText="Remarks">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbEdit" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("client_name") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="50px" HorizontalAlign="Center"  />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbDelete" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("client_name") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="50px" HorizontalAlign="Center"  />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>
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