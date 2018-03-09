using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Employee.BLL;

public partial class Main_login_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lawyer_homepage.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (Lawyer.Checked == true)
        {
            clsEmployee objEmployee = new clsEmployee();
            objEmployee.Uname = txtUsername.Text;
            objEmployee.Password = txtPassword.Text;
            DataTable dtUser = new DataTable();
            dtUser = objEmployee.ValidateLogin();
            if (dtUser.Rows.Count == 0)
            {
                lblMessage.Text = "Invalid Credentials!";
            }
            else
            {
                DataRow drLogin;
                drLogin = dtUser.Rows[0];
                Session["LoginName"] = drLogin["User_Name"].ToString();
                //  Session["Rights"] = drLogin["Rights"].ToString();
                Response.Redirect("Lawyer_homepage.aspx");
            }
        }
        if (Consumer.Checked == true)
        {
            clsConsumer objConsumer = new clsConsumer();
            objConsumer.Uname = txtUsername.Text;
            objConsumer.Password = txtPassword.Text;
            DataTable dtUser = new DataTable();
            dtUser = objConsumer.ValidateLogin();
            if (dtUser.Rows.Count == 0)
            {
                //  lblMessage.Text = "Invalid Credentials!";
            }
            else
            {
                DataRow drLogin;
                drLogin = dtUser.Rows[0];
                Session["LoginName"] = drLogin["LoginName"].ToString();
                //   Session["Rights"] = drLogin["Rights"].ToString();
                Response.Redirect("default.aspx");
            }
        }
    }
}