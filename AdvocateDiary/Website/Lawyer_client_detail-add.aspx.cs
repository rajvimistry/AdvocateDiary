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

public partial class Lawyer_client_detail_add : System.Web.UI.Page
{
    clsClientdetails objClientdetails = new clsClientdetails();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (Request["client_name"] != null)
        {
            // getLoginDetails(Convert.ToInt32(Request["LoginId"].ToString()));
            btnSave.Visible = false;
            getClientdetails(Request["client_name"]);
        }
        else
        {
            btnUpdate.Visible = false;
        }
    }

    protected void getClientdetails(string client_name)
    {
        objClientdetails.Clientname = client_name;
        objClientdetails.SelectByName();
        txtName.Text = objClientdetails.Clientname;
        txtcontact.Text = objClientdetails.Mobile;
        txtCity.Text = objClientdetails.Address;
        txtEmail.Text = objClientdetails.Email;
        txtDetail.Text = objClientdetails.Details;
        txtRemark.Text = objClientdetails.Remarks;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Lawyer_client_details.aspx");
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        clsClientdetails objClientdetails = new clsClientdetails();

        objClientdetails.Lawyername = lblHeaderMessage.Text.Trim();
        objClientdetails.Clientname = txtName.Text.Trim();
        objClientdetails.Mobile = txtcontact.Text.Trim();
        objClientdetails.Address = txtCity.Text.Trim();
        objClientdetails.Remarks = txtRemark.Text.Trim();
        objClientdetails.Details = txtDetail.Text.Trim();
        objClientdetails.Email = txtEmail.Text.Trim();
        objClientdetails.Insert();
        //lblHeaderMessage.Text = "Data Inserted Successfully";
        Response.Redirect("Lawyer_client_details.aspx");
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        clsClientdetails objClientdetails = new clsClientdetails();
        objClientdetails.Lawyername = lblHeaderMessage.Text.Trim();
        objClientdetails.Clientname = txtName.Text.Trim();
        objClientdetails.Mobile = txtcontact.Text.Trim();
        objClientdetails.Address = txtCity.Text.Trim();
        objClientdetails.Remarks = txtRemark.Text.Trim();
        objClientdetails.Details = txtDetail.Text.Trim();
        objClientdetails.Email = txtEmail.Text.Trim();
        objClientdetails.Update();
        Response.Redirect("Lawyer_client_details.aspx");

    }

    
}