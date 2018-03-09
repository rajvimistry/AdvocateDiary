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

public partial class lawyer_setting_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lawyer_update_info.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        clsEmployee objEmployee = new clsEmployee();
        objEmployee.Uname = lblHeaderMessage.Text;
        objEmployee.Password = txtOld.Text;
        DataTable dtUser = new DataTable();
        dtUser = objEmployee.ValidateLogin();

        if (dtUser.Rows.Count == 0)
        {
            lblMessage.Text = "Invalid Password!";
        }
        else
        {
            DataRow drLogin;
            drLogin = dtUser.Rows[0];
            objEmployee.Password = txtNew.Text;
            objEmployee.Update_password();
            lbl1Message.Text = "Password Change Successfully";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        clsEmployee objEmployee = new clsEmployee();
        objEmployee.Uname = lblHeaderMessage.Text;
        objEmployee.Password = txtOld1.Text;
        DataTable dtUser = new DataTable();
        dtUser = objEmployee.ValidateLogin();

        if (dtUser.Rows.Count == 0)
        {
            lbl2Message.Text = "Invalid Password!";
        }
        else
        {
            //DataRow drLogin;
            //drLogin = dtUser.Rows[0];
            objEmployee.DeleteByName();
            Response.Redirect("Login_page_lawyer_consumer.aspx");
        }
    }
}