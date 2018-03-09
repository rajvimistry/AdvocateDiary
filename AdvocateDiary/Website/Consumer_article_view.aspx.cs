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

public partial class Consumer_article_view : System.Web.UI.Page
{
    
    clsArticle objArticle = new clsArticle();
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
        if (!IsPostBack)
        {
            if (Request["Topic_name"] != null)
            {
                // getLoginDetails(Convert.ToInt32(Request["LoginId"].ToString()));
                getTopicdetails(Request["Topic_name"]);
            }
        }
    }

     

    public void getTopicdetails(string topic_name)
    {
        objArticle.Topicname = topic_name;
        objArticle.SelectById();
        txtTopicname.Text = objArticle.Topicname.ToString();
        txtTopicdescription.Text = objArticle.TopicDescription.ToString();
        txtPostby.Text = objArticle.PostBy.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Consumer_article.aspx");
    }
}