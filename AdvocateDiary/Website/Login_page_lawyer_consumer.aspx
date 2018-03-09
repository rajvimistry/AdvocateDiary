<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login_page_lawyer_consumer.aspx.cs" Inherits="Login_page_lawyer_consumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  <title>Advocate Diary</title>
 <!-- <link rel="stylesheet" href="style.css">-->
  <link href="style_login_registration.css" rel="stylesheet" type="text/css" />
  <!--[if lt IE 9]><script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script><![endif]-->
</head>
<body>
    <h1 class="register-title">Welcome</h1>
    <form id="form1" runat="server" class="register">
    <div class="register-switch">
      <input type="radio" name="sex" value="F" id="sex_f" class="register-switch-input" runat="server" checked />
      <label for="sex_f" class="register-switch-label">Lawyer</label>
      <input type="radio" name="sex" value="M" id="sex_m" class="register-switch-input" runat="server" />
      <label for="sex_m" class="register-switch-label">Consumer</label>
        </div>

        <asp:TextBox ID="txtUsername" runat="server" CssClass="register-input"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="register-input" TextMode="Password"></asp:TextBox>
        <%-- <input type="text" class="register-input" placeholder="Email address" runat="server" id="txtUsername" />
         <input type="password" class="register-input" placeholder="Password" runat="server" id="txtPassword" />--%>
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="register-button" OnClick="Button1_Click" />	
    <asp:LinkButton ID="register_button" runat="server" Text="New user? Create Account" Font-Size="Small" OnClick="register_button_Click" /><br/>
        <asp:LinkButton ID="Forgot_password" runat="server" Text="Forgot Password ?" Font-Size="Small" OnClick="Forgot_password_Click" />
    </form>
</body>
</html>
