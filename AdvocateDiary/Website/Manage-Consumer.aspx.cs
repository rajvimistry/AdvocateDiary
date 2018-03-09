using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Consumer : System.Web.UI.Page
{
    clsConsumer objConsumer = new clsConsumer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FillEmployeeDetails();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Response.Redirect("Manage-Consumer-Add.aspx");
    }

    protected void FillEmployeeDetails()
    {
        //if (chkStatus.Checked)
        //{
        //    gvMaster.DataSource = objEmployee.SelectInActive();
        //}
        //else
        //{
        gvMaster.DataSource = objConsumer.SelectAll();
        //}
        gvMaster.DataBind();
    }

    protected void gvMaster_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //    if (e.CommandName.ToString().ToUpper() == "ONJOB")
        //    {
        //        Response.Redirect("Manage-Employee-Trainings.aspx?EmpId=" + e.CommandArgument.ToString() + "&JobType=1");
        //    }

        //    if (e.CommandName.ToString().ToUpper() == "OFFJOB")
        //    {
        //        Response.Redirect("Manage-Employee-Trainings.aspx?EmpId=" + e.CommandArgument.ToString() + "&JobType=2");
        //    }

        if (e.CommandName.ToString().ToUpper() == "EDIT")
        {
            Response.Redirect("Manage-Consumer-Add.aspx?id=" + e.CommandArgument.ToString());
        }
        if (e.CommandName.ToString().ToUpper() == "DELETE")
        {
            objConsumer.ConsumerId = Convert.ToInt32(e.CommandArgument.ToString());
            objConsumer.Delete();
            lblMessage.Text = "Data successfully deleted!";
        }
    }

    protected void gvMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        FillEmployeeDetails();
    }

    protected void gvMaster_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton lbDelete = (LinkButton)e.Row.FindControl("lbDelete");
            lbDelete.Attributes.Add("onclick", "return confirm('Are you sure to delete?');");
        }
    }

    protected void gvMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMaster.PageIndex = e.NewPageIndex;
        FillEmployeeDetails();
    }

    protected void chkStatus_CheckedChanged(object sender, EventArgs e)
    {
        FillEmployeeDetails();
    }
}