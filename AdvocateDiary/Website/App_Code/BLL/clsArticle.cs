using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Employee.DAL;
using System.Data.SqlClient;

/// <summary>
/// Summary description for clsArticle
/// </summary>
public class clsArticle
{
	public clsArticle()
	{
		//
		// TODO: Add constructor logic here
		//
	}
     #region Variables
    DBBridge objDBBridge = new DBBridge();
    protected int _topic_id;
    protected string _topic_name = String.Empty;
    protected string _topic_description = String.Empty;
    protected string _post_by = String.Empty;
    const string _spName = "sp_tblArticle";
    #endregion

    #region Class Property

    public int topic_id
    {
        get { return topic_id; }
        set { _topic_id = value; }
    }

    public string Topicname
    {
        get { return _topic_name; }
        set { _topic_name = value; }
    }

    public string TopicDescription
    {
        get { return _topic_description; }
        set { _topic_description = value; }
    }

    public string PostBy
    {
        get { return _post_by; }
        set { _post_by = value; }
    }

    #endregion

    #region Public Methods

    public int Insert()
    {
        SqlParameter[] param = new SqlParameter[4];
        param[0] = new SqlParameter("@Mode", "Insert");
        param[1] = new SqlParameter("@Topicname", _topic_name);
        param[2] = new SqlParameter("@Topic_description", _topic_description);
        param[3] = new SqlParameter("@Post_by", _post_by);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }

    public int Update()
    {
        SqlParameter[] param = new SqlParameter[4];
        param[0] = new SqlParameter("@Mode", "Update");
        param[1] = new SqlParameter("@Topicname", _topic_name);
        param[2] = new SqlParameter("@Topic_description", _topic_description);
        param[3] = new SqlParameter("@Post_by", _post_by);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }
    public int Delete()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "Delete");
        param[1] = new SqlParameter("@Topicname", _topic_name);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }

    public DataSet Select()
    {
        SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("@Mode", "ViewActive");
        return objDBBridge.ExecuteDataset(_spName, param);
    }
    public DataSet SelectInActive()
    {
        SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("@Mode", "ViewInActive");
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataSet SelectAll()
    {
        SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("@Mode", "View");
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataSet SelectById()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByID");
        param[1] = new SqlParameter("@Topicname", _topic_name);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _topic_description = drEmployee["Topic_Description"].ToString();
            _post_by = drEmployee["Post_by"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }
    #endregion
}