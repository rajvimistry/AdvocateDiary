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

public partial class Lawyer_Profile_Consumer : System.Web.UI.Page
{
    clsLawyer_Update_info objclsupdateinfo = new clsLawyer_Update_info();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!IsPostBack)
        {
            if (Request["Lawyername"] != null)
            {
                // getLoginDetails(Convert.ToInt32(Request["LoginId"].ToString()));
                getLawyerdetails(Request["Lawyername"]);
            }
        }
    }

    public void getLawyerdetails(string lawyername)
    {
        objclsupdateinfo.Lawyername = lawyername;
        objclsupdateinfo.SelectByName();
        txtAbout.Text = objclsupdateinfo.About.ToString();
        txtAddress.Text = objclsupdateinfo.Address.ToString();
        txtCity.Text = objclsupdateinfo.City.ToString();
        txtContact1.Text = objclsupdateinfo.Contact.ToString();
        txtContact2.Text = objclsupdateinfo.Contact2.ToString();
        txtEmail.Text = objclsupdateinfo.Email.ToString();
        txtExperience.Text = objclsupdateinfo.Experience.ToString();
        txtName.Text = objclsupdateinfo.Lawyername.ToString();
        txtState.Text = objclsupdateinfo.State.ToString();
        txtWorkingfield.Text = objclsupdateinfo.Workingfield.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Consumer_search_page.aspx");
    }
}