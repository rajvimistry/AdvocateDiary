using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Article_add_new_topic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHeaderMessage.Text = Session["Name"].ToString();
        Session["Name"] = lblHeaderMessage.Text;
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        clsArticle objArticle = new clsArticle();
        objArticle.Topicname = txtTopicname.Text.Trim();
        objArticle.TopicDescription = txtTopicdescription.Text.Trim();
        objArticle.PostBy = lblHeaderMessage.Text.Trim();
        objArticle.Insert();
        Response.Redirect("Articles.aspx");
    }
    protected void cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Articles.aspx");
    }
}