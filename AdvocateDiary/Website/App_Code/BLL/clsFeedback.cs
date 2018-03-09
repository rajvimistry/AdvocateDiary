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
/// Summary description for clsFeedback
/// </summary>
public class clsFeedback
{
	public clsFeedback()
	{
		//
		// TODO: Add constructor logic here
		//
	}
     #region Variables
    DBBridge objDBBridge = new DBBridge();
    protected int _id;
    protected string _lawyername = String.Empty;
    protected string _consumername = String.Empty;
    protected string _comments = String.Empty;
    const string _spName = "sp_tblFeedback";
    #endregion

    #region Class Property

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _lawyername; }
        set { _lawyername = value; }
    }

    public string Consumername
    {
        get { return _consumername; }
        set { _consumername = value; }
    }

    public string Comments
    {
        get { return _comments; }
        set { _comments = value; }
    }

    #endregion

    #region Public Methods

    public int Insert()
    {
        SqlParameter[] param = new SqlParameter[4];
        param[0] = new SqlParameter("@Mode", "Insert");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        param[2] = new SqlParameter("@Consumername", _consumername);
        param[3] = new SqlParameter("@Comment", _comments);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }

    public int Update()
    {
        SqlParameter[] param = new SqlParameter[4];
        param[0] = new SqlParameter("@Mode", "Update");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        param[2] = new SqlParameter("@Consumername", _consumername);
        param[3] = new SqlParameter("@Comments", _comments);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }
    public int Delete()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "Delete");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
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
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _consumername = drEmployee["consumername"].ToString();
            _comments = drEmployee["comments"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }
    #endregion
}