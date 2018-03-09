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
/// Summary description for clsEvent
/// </summary>
public class clsEvent
{
	public clsEvent()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    #region Variables
    DBBridge objDBBridge = new DBBridge();
    protected int _event_id;
    protected string _event_name = String.Empty;
    protected string _time = String.Empty;
    protected DateTime _date;
    protected string _lawyername=String.Empty;
    const string _spName = "sp_tblEvent";
    #endregion

    #region Class Property

    public int event_id
    {
        get { return _event_id; }
        set { _event_id = value; }
    }

    public string Eventname
    {
        get { return _event_name; }
        set { _event_name = value; }
    }

    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Lawyername
    {
        get{ return _lawyername; }
        set{ _lawyername=value; }
    }

    #endregion

    #region Public Methods

    public int Insert()
    {
        SqlParameter[] param = new SqlParameter[5];
        param[0] = new SqlParameter("@Mode", "Insert");
        param[1] = new SqlParameter("@Eventname", _event_name);
        param[2] = new SqlParameter("@Time", _time);
        param[3] = new SqlParameter("@Date", _date);
        param[4] = new SqlParameter("@Lawyername", _lawyername);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }

    public int Update()
    {
        SqlParameter[] param = new SqlParameter[5];
        param[0] = new SqlParameter("@Mode", "Insert");
        param[1] = new SqlParameter("@Eventname", _event_name);
        param[2] = new SqlParameter("@Time", _time);
        param[3] = new SqlParameter("@Date", _date);
        param[4] = new SqlParameter("@Lawyername", _lawyername);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }
    public int Delete()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "Delete");
        param[1] = new SqlParameter("@Eventname", _event_name);
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
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "View");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataSet SelectById()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByID");
        param[1] = new SqlParameter("@Topicname", _event_name);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _time = drEmployee["Topic_Description"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataTable CheckDate()
    {
        SqlParameter[] param = new SqlParameter[3];
        param[0] = new SqlParameter("@Mode", "ChkDate");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        param[2] = new SqlParameter("@Date", _date);
        return objDBBridge.ExecuteDataset(_spName, param).Tables[0];
    }

    public DataTable CheckDateForTommorrow()
    {
        SqlParameter[] param = new SqlParameter[3];
        param[0] = new SqlParameter("@Mode", "ChkDate");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        param[2] = new SqlParameter("@Date", _date);
        return objDBBridge.ExecuteDataset(_spName, param).Tables[0];
    }

    #endregion
}