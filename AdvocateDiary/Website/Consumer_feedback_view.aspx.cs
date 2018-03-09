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

public partial class Consumer_feedback_view : System.Web.UI.Page
{
    clsFeedback objFeedback = new clsFeedback();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!IsPostBack)
        {
            Label1.Text = Request["Lawyername"];
            if (Request["Lawyername"] != null)
            {
                // getLoginDetails(Convert.ToInt32(Request["LoginId"].ToString()));
                getFeedback(Request["Lawyername"]);
            }
        }
    }

    public void getFeedback(string lawyer_name)
    {
        objFeedback.Name = lawyer_name;
        gvMaster.DataSource = objFeedback.SelectById();
        gvMaster.DataBind();
    }

    protected void gvMaster_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName.ToString().ToUpper() == "EDIT")
        //{
        //    Response.Redirect("Lawyer_client_detail-add.aspx?client_name=" + e.CommandArgument.ToString());
        //}
        //if (e.CommandName.ToString().ToUpper() == "DELETE")
        //{
        //    objClientdetails.Clientname = e.CommandArgument.ToString();
        //    objClientdetails.Delete();
        //    lblMessage.Text = "Data successfully deleted!";
        //}
    }

    protected void gvMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //FillLoginDetails();
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
        //gvMaster.PageIndex = e.NewPageIndex;
        //FillLoginDetails();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        objFeedback.Name = Label1.Text.Trim();
        objFeedback.Consumername = lblHeaderMessage.Text.Trim();
        objFeedback.Comments = txtComment.Text.Trim();
        objFeedback.Insert();
        txtComment.Text = "";
        Label2.Text = "Thank you for your valuable feedback";
    }
}