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

public partial class Lawyer_event : System.Web.UI.Page
{
    clsEvent objEvent = new clsEvent();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!Page.IsPostBack)
        {
            FillEventDetails();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtEvent.Text == "" && txtDate.Text == "" && txtTime.Text == "")
        {
            Label4.Text = "Insert all details";
        }
        else
        {
            objEvent.Lawyername = lblHeaderMessage.Text;
            objEvent.Eventname = txtEvent.Text.Trim();
            objEvent.Date = Convert.ToDateTime(txtDate.Text.Trim());
            objEvent.Time = txtTime.Text.Trim();
            objEvent.Insert();
            FillEventDetails();
            txtTime.Text = "";
            txtEvent.Text = "";
            txtDate.Text = "";
            Label4.Text = "";
        }
    }

    protected void FillEventDetails()
    {
        objEvent.Lawyername = lblHeaderMessage.Text;
        gvMaster.DataSource = objEvent.SelectAll();
        gvMaster.DataBind();
    }

    protected void gvMaster_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName.ToString().ToUpper() == "EDIT")
        //{
        //    Response.Redirect("Lawyer_client_detail-add.aspx?Clientname=" + e.CommandArgument.ToString());
        //}
        if (e.CommandName.ToString().ToUpper() == "DELETE")
        {
            objEvent.Eventname = e.CommandArgument.ToString();
            objEvent.Delete();
           // lblMessage.Text = "Data successfully deleted!";
        }
    }

    protected void gvMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        FillEventDetails();
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
        FillEventDetails();
    }
}