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

public partial class Lawyer_update_info : System.Web.UI.Page
{
    clsLawyer_Update_info objLawyerUpdateInfo = new clsLawyer_Update_info();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!IsPostBack)
        {
            if (Request["Lawyername"] == null)
            {
                Button2.Visible = false;
                getDetails(Request["Lawyername"]);
            }
            else
            {
                Button3.Visible = false;
            }
        }
    }

    protected void getDetails(string lawyername)
    {
        objLawyerUpdateInfo.Lawyername = lblHeaderMessage.Text;
        objLawyerUpdateInfo.SelectById();
        txtAbout.Text = objLawyerUpdateInfo.About;
        txtAddress.Text = objLawyerUpdateInfo.Address;
        txtCity.Text = objLawyerUpdateInfo.City;
        txtContact_M.Text = objLawyerUpdateInfo.Contact2;
        txtContact_O.Text = objLawyerUpdateInfo.Contact;
        txtEmail.Text = objLawyerUpdateInfo.Email;
        txtExperience.Text = objLawyerUpdateInfo.Experience;
        txtState.Text = objLawyerUpdateInfo.State;
        txtWorkingfield.Text = objLawyerUpdateInfo.Workingfield;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("lawyer_setting_page.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        objLawyerUpdateInfo.Lawyername = lblHeaderMessage.Text;
        objLawyerUpdateInfo.Experience = txtExperience.Text.Trim();
        objLawyerUpdateInfo.Workingfield = txtWorkingfield.Text.Trim();
        objLawyerUpdateInfo.Address = txtAddress.Text.Trim();
        objLawyerUpdateInfo.City = txtCity.Text.Trim();
        objLawyerUpdateInfo.State = txtState.Text.Trim();
        objLawyerUpdateInfo.Email = txtEmail.Text.Trim();
        objLawyerUpdateInfo.About = txtAbout.Text.Trim();
        objLawyerUpdateInfo.Contact = txtContact_O.Text.Trim();
        objLawyerUpdateInfo.Contact2 = txtContact_M.Text.Trim();
        objLawyerUpdateInfo.Insert();
        Label1.Text = "Data Inserted Successfully";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        objLawyerUpdateInfo.Lawyername = lblHeaderMessage.Text;
        objLawyerUpdateInfo.Experience = txtExperience.Text.Trim();
        objLawyerUpdateInfo.Workingfield = txtWorkingfield.Text.Trim();
        objLawyerUpdateInfo.Address = txtAddress.Text.Trim();
        objLawyerUpdateInfo.City = txtCity.Text.Trim();
        objLawyerUpdateInfo.State = txtState.Text.Trim();
        objLawyerUpdateInfo.Email = txtEmail.Text.Trim();
        objLawyerUpdateInfo.About = txtAbout.Text.Trim();
        objLawyerUpdateInfo.Contact = txtContact_O.Text.Trim();
        objLawyerUpdateInfo.Contact2 = txtContact_M.Text.Trim();
        objLawyerUpdateInfo.Update();
        Label1.Text = "Data Updated Successfully";

    }
}