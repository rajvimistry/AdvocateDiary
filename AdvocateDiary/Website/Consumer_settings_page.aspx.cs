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

public partial class Consumer_settings_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsConsumer objConsumer = new clsConsumer();
        objConsumer.Uname = lblHeaderMessage.Text;
        objConsumer.Password = txtOld.Text;
        DataTable dtUser = new DataTable();
        dtUser = objConsumer.ValidateLogin();

        if (dtUser.Rows.Count == 0)
        {
            lblMessage.Text = "Invalid Password!";
        }
        else
        {
            DataRow drLogin;
            drLogin = dtUser.Rows[0];
            objConsumer.Password = txtNew.Text;
            objConsumer.Update_password();
            lbl1Message.Text = "Password Change Successfully";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        clsConsumer objConsumer = new clsConsumer();
        objConsumer.Uname = lblHeaderMessage.Text;
        objConsumer.Password = txtOld1.Text;
        DataTable dtUser = new DataTable();
        dtUser = objConsumer.ValidateLogin();

        if (dtUser.Rows.Count == 0)
        {
            lbl2Message.Text = "Invalid Password!";
        }
        else
        {
            //DataRow drLogin;
            //drLogin = dtUser.Rows[0];
            objConsumer.DeleteByName();
            Response.Redirect("Login_page_lawyer_consumer.aspx");
        }
    }
}