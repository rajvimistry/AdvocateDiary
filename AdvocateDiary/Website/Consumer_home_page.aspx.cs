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

public partial class Consumer_home_page : System.Web.UI.Page
{
    clsEvent objEvent = new clsEvent();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["LoginName"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!Page.IsPostBack)
        {
            FillEventDetails();
        }
        //DataTable dtUser = new DataTable();
        //dtUser = objEvent.CheckDate();
        //if (dtUser.Rows.Count == 0)
        //{
        //    //  lblMessage.Text = "Invalid Credentials!";
        //    txtEvent.Text = "  No Upcoming events";
        //}
        //else
        //{
        //    txtEvent.Visible = false;
        //    //txtEvent.Text = "1 Upcoming Event";
        //    //DataRow drLogin;
        //    //drLogin = dtUser.Rows[0];
        //    //Session["LoginName"] = drLogin["Username"].ToString();
        //    ////   Session["Rights"] = drLogin["Rights"].ToString();
        //    //Response.Redirect("Consumer_home_page.aspx");
        //}
    }

    protected void FillEventDetails()
    {
        objEvent.Lawyername = lblHeaderMessage.Text;
        DateTime today = DateTime.Today;
        objEvent.Date = today;
        gvMaster.DataSource = objEvent.CheckDate();
        gvMaster.DataBind();
        DataTable dtUser = new DataTable();
        dtUser = objEvent.CheckDate();
        if (dtUser.Rows.Count == 0)
        {
            //  lblMessage.Text = "Invalid Credentials!";
            txtEvent.Text = "  No Upcoming events";
        }
        else
        {
            txtEvent.Visible = false;
            //txtEvent.Text = "1 Upcoming Event";
            //DataRow drLogin;
            //drLogin = dtUser.Rows[0];
            //Session["LoginName"] = drLogin["Username"].ToString();
            ////   Session["Rights"] = drLogin["Rights"].ToString();
            //Response.Redirect("Consumer_home_page.aspx");
        }
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