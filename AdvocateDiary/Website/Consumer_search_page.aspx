﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Consumer_search_page.aspx.cs" Inherits="Consumer_search_page" %>

<asp:Content  runat="server" ID="cphHeader" ContentPlaceHolderID="ContentPlaceHolder1">
    <ul class="site-nav">
        <li><a href="Consumer_home_page.aspx">Home</a></li>
      <li><a href="Consumer_feedback_page.aspx">Feedback</a></li>
      <li><a href="Consumer_article.aspx">Articles</a></li>
      <li><a href="Consumer_settings_page.aspx">Settings</a></li>
      <li><a href="Consumer_search_page.aspx" class="act">Search</a></li>
      <li><a href="Consumer_Event.aspx">Event</a></li>
          <%--<li><a href="sitemap.html">Site Map</a></li>--%>
      <li><a href="Login_page_lawyer_consumer.aspx">Logout</a></li>
       
    </ul>
        </asp:Content> 
<asp:Content ID="cMainContent" runat="server" ContentPlaceHolderID="cphMain">
     <form id="form1" runat="server">
        <div style="text-align:right"><font size="3"> Hi  </font> <asp:Label ID="lblHeaderMessage" runat="server" Font-Size="Medium"></asp:Label> 
            </div>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
         <br />
         <br />
         <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="Label1" runat="server" Font-Size="Medium"></asp:Label>
         <br />
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Textbox runat="server" Height="24px" Width="259px" ID="txtSearch" Font-Size="Small" BorderStyle="Solid"></asp:Textbox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" CssClass="myButton1" />
&nbsp;
         <br />
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
         <asp:RadioButton ID="name" runat="server" GroupName="abc" Text="By Name" Font-Size="Medium" />
&nbsp;&nbsp;
         <asp:RadioButton ID="Working_area" runat="server" GroupName="abc" Text="Working Area" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:RadioButton ID="city" runat="server" GroupName="abc" Text="City" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;
         <asp:RadioButton ID="all" runat="server" GroupName="abc" Text="All" Font-Size="Medium" />
         <br />
         <br />
         <br />
         <br />
         <div>
         <div align="center">
         &nbsp;&nbsp;&nbsp;
         <asp:GridView ID="gvMaster" runat="server" AutoGenerateColumns="False" CssClass="input300" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="Both" BorderStyle="Solid" BorderColor="#000000" OnRowCommand="gvMaster_RowCommand" OnPageIndexChanging="gvMaster_PageIndexChanging" AllowPaging="True"  PageSize="10">
            
            <Columns>
                <asp:BoundField DataField="Lawyername" HeaderText="Name">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Working_field" HeaderText="Working Field">
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbEdit" Text="Go To Profile" Width="100" CommandName="Edit" CommandArgument='<%# Eval("Lawyername") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="50px" HorizontalAlign="Center"  />
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Font-Bold="true"  />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <AlternatingRowStyle BackColor="#EFF3FB" />
        </asp:GridView>
             </div>
             </div>
         </form>
    </asp:Content>