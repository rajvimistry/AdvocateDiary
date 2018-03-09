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

public partial class Manage_forum : System.Web.UI.Page
{
    clsArticle objArticle = new clsArticle();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FillArticleDetails();
        }
    }
    protected void FillArticleDetails()
    {
        gvMaster.DataSource = objArticle.SelectAll();
        gvMaster.DataBind();
    }

    //protected void btnSave_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("Manage-Login-Add.aspx");
    //}

    protected void gvMaster_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName.ToString().ToUpper() == "EDIT")
        //{
        //    Response.Redirect("Manage-Login-Add.aspx?LoginId=" + e.CommandArgument.ToString());
        //}
        if (e.CommandName.ToString().ToUpper() == "DELETE")
        {
            objArticle.Topicname = e.CommandArgument.ToString();
            objArticle.Delete();
            lblMessage.Text = "Successfully deleted!";
        }
    }

    protected void gvMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        FillArticleDetails();
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
        FillArticleDetails();
    }

    //public string getRights(int nRights)
    //{
    //    if (nRights == 1)
    //    {
    //        return "Admin";
    //    }
    //    return "User";
    //}
}