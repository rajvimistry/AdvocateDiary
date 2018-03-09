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

public partial class Forgot_password : System.Web.UI.Page
{
    clsConsumer objConsumer = new clsConsumer();
    clsEmployee objEmployee = new clsEmployee();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Lawyer.Checked == true)
        {
            objEmployee.Uname = txtUsername.Text.Trim();
            DataTable dtUser = new DataTable();
            dtUser = objEmployee.chkName();
            if (dtUser.Rows.Count == 0)
            {
                  lblMessage.Text = "Username does not exist!";
            }
            else
            {
                //FillQuestion();
                //DataRow drLogin;
                //drLogin = dtUser.Rows[0];
                //Session["LoginName"] = drLogin["Username"].ToString();
                objEmployee.SelectByName();
                txtQuestion.Text = objEmployee.Question;
            }
        }

        if (Consumer.Checked == true)
        {
            objConsumer.Uname = txtUsername.Text.Trim();
            DataTable dtUser = new DataTable();
            dtUser = objConsumer.chkName();
            if (dtUser.Rows.Count == 0)
            {
                  lblMessage.Text = "Username does not exist!";
            }
            else
            {
                lblMessage.Text = "";
                objConsumer.SelectByName();
                txtQuestion.Text = objConsumer.Question;         
            }
 
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Lawyer.Checked == true)
        {
            objEmployee.Uname = txtUsername.Text;
            objEmployee.Answer = txtAnswer.Text.Trim();
            DataTable dtUser = new DataTable();
            dtUser = objEmployee.chkAnswer();
            if (dtUser.Rows.Count == 0)
            {
                Label6.Text = "Wrong Answer!";
                txtNewPassword.Text = "";
                txtRePassword.Text = "";
            }
            else
            {
                objEmployee.Uname = txtUsername.Text;
                objEmployee.Password = txtNewPassword.Text;
                objEmployee.Update_password();
                txtRePassword.Text = "";
                txtUsername.Text = "";
                txtAnswer.Text = "";
                txtNewPassword.Text = "";
                txtQuestion.Text = "";
                lblMessage.Text = "Password Change Successfully";
            }
        }

        if (Consumer.Checked == true)
        {
            objConsumer.Uname = txtUsername.Text.Trim();
            objConsumer.Answer = txtAnswer.Text.Trim();
            DataTable dtUser = new DataTable();
            dtUser = objConsumer.chkAnswer();
            if (dtUser.Rows.Count == 0)
            {
                Label6.Text = "Wrong Answer!";
            }
            else
            {
                objConsumer.Uname = txtUsername.Text;
                objConsumer.Password = txtNewPassword.Text;
                objConsumer.Update_password();
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        txtUsername.Text = "";
        txtRePassword.Text = "";
        txtQuestion.Text = "";
        txtNewPassword.Text = "";
        txtAnswer.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login_page_lawyer_consumer.aspx");
    }
}