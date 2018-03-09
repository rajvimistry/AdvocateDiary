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

public partial class Consumer_feedback_page : System.Web.UI.Page
{
    clsEmployee objEmployee = new clsEmployee();
    clsLawyer_Update_info objLawyerinfo = new clsLawyer_Update_info();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!Page.IsPostBack)
        {
            FillLawyerDetails();
        }
    }

    protected void FillLawyerDetails()
    {
        objLawyerinfo.Lawyername= lblHeaderMessage.Text;
        gvMaster.DataSource = objLawyerinfo.SelectAll();
        gvMaster.DataBind();
    }

    protected void gvMaster_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.ToString().ToUpper() == "EDIT")
        {
            Response.Redirect("Consumer_feedback_view.aspx?Lawyername=" + e.CommandArgument.ToString());
        }
        //if (e.CommandName.ToString().ToUpper() == "DELETE")
        //{
        //    objClientdetails.Clientname = e.CommandArgument.ToString();
        //    objClientdetails.Delete();
        //    lblMessage.Text = "Data successfully deleted!";
        //}
    }

    protected void gvMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        FillLawyerDetails();
    }

    protected void gvMaster_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    LinkButton lbDelete = (LinkButton)e.Row.FindControl("lbDelete");
        //    lbDelete.Attributes.Add("onclick", "return confirm('Are you sure to delete?');");
        //}
    }

    protected void gvMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMaster.PageIndex = e.NewPageIndex;
        FillLawyerDetails();
    }
}