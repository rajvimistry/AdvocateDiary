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

public partial class Consumer_search_page : System.Web.UI.Page
{
    clsLawyer_Update_info objclslawyerinfo = new clsLawyer_Update_info();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (name.Checked == false && Working_area.Checked == false && city.Checked == false && all.Checked == false)
        {
            Label1.Text = "Please select appropriate choice";
        }

        if (name.Checked == true)
        {
            Label1.Text = "";
            objclslawyerinfo.Lawyername = txtSearch.Text;
            gvMaster.DataSource = objclslawyerinfo.SelectByName();
            gvMaster.DataBind();
        }

        if (Working_area.Checked == true)
        {
            Label1.Text = "";
            objclslawyerinfo.Workingfield = txtSearch.Text;
            gvMaster.DataSource = objclslawyerinfo.SelecByWorkingfield();
            gvMaster.DataBind();
        }

        if (city.Checked == true)
        {
            Label1.Text = "";
            objclslawyerinfo.City = txtSearch.Text;
            gvMaster.DataSource = objclslawyerinfo.SelecByCity();
            gvMaster.DataBind();
        }

        if (all.Checked == true)
        {
            Label1.Text = "";
            gvMaster.DataSource = objclslawyerinfo.SelectAll();
            gvMaster.DataBind();
        }
    }

    protected void gvMaster_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.ToString().ToUpper() == "EDIT")
        {
            Response.Redirect("Lawyer_Profile_Consumer.aspx?Lawyername=" + e.CommandArgument.ToString());
        }
    }

    protected void gvMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvMaster.PageIndex = e.NewPageIndex;
        //FillArticleDetails();
    }
}