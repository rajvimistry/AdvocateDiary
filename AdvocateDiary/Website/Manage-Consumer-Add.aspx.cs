using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Consumer_Add : System.Web.UI.Page
{
    clsConsumer objConsumer = new clsConsumer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request["id"] != null)
            {
                getConsumerDetails(Convert.ToInt32(Request["id"].ToString()));
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
            else
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
        }
    }

    protected void getConsumerDetails(int id)
    {
        objConsumer.ConsumerId = id;
        objConsumer.SelectById();
        txtName.Text = objConsumer.Name.ToString();
        lname.Text = objConsumer.L_Name.ToString();
        uname.Text = objConsumer.Uname.ToString();
        password.Text = objConsumer.Password.ToString();
        txtDOB.Text = objConsumer.DOB.ToShortDateString();
        txtAddress.Text = objConsumer.Address.ToString();
        txtMobile.Text = objConsumer.Mobile.ToString();
        email.Text = objConsumer.Email.ToString();
        txtAns.Text = objConsumer.Answer.ToString();
        txtQue.Text = objConsumer.Question.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Manage-Consumer.aspx");
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        objConsumer.Name = txtName.Text.Trim();
        objConsumer.L_Name = lname.Text.Trim();
        objConsumer.Uname = uname.Text.Trim();
        objConsumer.Email = email.Text.Trim();
        objConsumer.Password = password.Text.Trim();
        objConsumer.Address = txtAddress.Text.Trim();
        objConsumer.Mobile = txtMobile.Text.Trim();
        objConsumer.DOB = Convert.ToDateTime(txtDOB.Text.Trim());
        objConsumer.Question = txtQue.Text.Trim();
        objConsumer.Answer = txtAns.Text.Trim();
        objConsumer.Insert();
        Response.Redirect("Manage-Consumer.aspx");
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        objConsumer.Name = txtName.Text.Trim();
        objConsumer.L_Name = lname.Text.Trim();
        objConsumer.Uname = uname.Text.Trim();
        objConsumer.Email = email.Text.Trim();
        objConsumer.Password = password.Text.Trim();
        objConsumer.Address = txtAddress.Text.Trim();
        objConsumer.Mobile = txtMobile.Text.Trim();
        objConsumer.Question = txtQue.Text.Trim();
        objConsumer.Answer = txtAns.Text.Trim();
        objConsumer.DOB = Convert.ToDateTime(txtDOB.Text.Trim());
        objConsumer.Update();
        Response.Redirect("Manage-Consumer.aspx");
    }
}