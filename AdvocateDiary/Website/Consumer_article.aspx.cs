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

public partial class Consumer_article : System.Web.UI.Page
{
    protected Utils util;
    clsArticle objArticle = new clsArticle();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblHeaderMessage.Text = Session["Name"].ToString();
            Session["Name"] = lblHeaderMessage.Text;
            Search();
            FillArticleDetails();
        }
    }

    protected void Search()
    {
        util = new Utils();
    }

    public void FillArticleDetails()
    {
        dtlDoctors.DataSource = objArticle.SelectAll();
        dtlDoctors.DataBind();
    }
}