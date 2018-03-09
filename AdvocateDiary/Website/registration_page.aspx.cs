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

public partial class registration_page : System.Web.UI.Page
{
    clsEmployee objEmployee = new clsEmployee();
    clsConsumer objConsumer = new clsConsumer();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (txtName.Text == null && lname.Text == null && uname.Text == null && email.Text == null && password.Text == null && txtAddress.Text == null && txtMobile.Text == null && txtDOB.Text == null && txtQue.Text == null && txtAns.Text == null && Lawyer.Checked == false && Consumer.Checked == false)
        {
            Label1.Text = "Insert All The Details, Make Sure it is in correct format";
        }
        if (Lawyer.Checked == true)
        {
           
            objEmployee.Uname = uname.Text.Trim();
            DataTable dtUser = new DataTable();
            dtUser = objEmployee.chkName();
            if (dtUser.Rows.Count != 0)
            {
                Label1.Text = "This username is already exist, Please choose another!";
            }
            else
            {
                objEmployee.Name = txtName.Text.Trim();
                objEmployee.L_Name = lname.Text.Trim();
                objEmployee.Uname = uname.Text.Trim();
                objEmployee.Email = email.Text.Trim();
                objEmployee.Password = password.Text.Trim();
                objEmployee.Type = type.Text.Trim();
                objEmployee.Address = txtAddress.Text.Trim();
                objEmployee.Mobile = txtMobile.Text.Trim();
                objEmployee.DOB = Convert.ToDateTime(txtDOB.Text.Trim());
                objEmployee.Question = txtQue.Text.Trim();
                objEmployee.Answer = txtAns.Text.Trim();
                objEmployee.Insert();
                Label1.Text = "registered successfully";
                txtAddress.Text = "";
                txtAns.Text = "";
                txtDOB.Text = "";
                txtMobile.Text = "";
                txtName.Text = "";
                txtQue.Text = "";
                lname.Text = "";
                email.Text = "";
                password.Text = "";
                type.Text = "";
                uname.Text = "";
            }
        }

        if (Consumer.Checked == true)
        {
            objConsumer.Uname = uname.Text.Trim();
             DataTable dtUser = new DataTable();
            dtUser = objConsumer.chkName();
            if (dtUser.Rows.Count != 0)
            {
                Label1.Text = "This username is already exist, Please choose another!";
            }
            else
            {

                objConsumer.Name = txtName.Text.Trim();
                objConsumer.L_Name = lname.Text.Trim();
                objConsumer.Uname = uname.Text.Trim();
                objConsumer.Email = email.Text.Trim();
                objConsumer.Password = password.Text.Trim();
                objConsumer.Address = txtAddress.Text.Trim();
                objConsumer.Mobile = txtMobile.Text.Trim();
                objConsumer.DOB = Convert.ToDateTime(txtDOB.Text.Trim());
                objConsumer.Insert();
                Label1.Text = "registered successfully";
                txtAddress.Text = "";
                txtAns.Text = "";
                txtDOB.Text = "";
                txtMobile.Text = "";
                txtName.Text = "";
                txtQue.Text = "";
                lname.Text = "";
                email.Text = "";
                password.Text = "";
                type.Text = "";
                uname.Text = "";
            }
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login_page_lawyer_consumer.aspx");
    }
    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login_page_lawyer_consumer.aspx");
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string s = args.Value;
        if (s.Length == 10)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }
    }
}