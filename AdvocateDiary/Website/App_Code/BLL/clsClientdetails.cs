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
/// Summary description for clsClientdetails
/// </summary>
public class clsClientdetails
{
	public clsClientdetails()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    #region Variables
    DBBridge objDBBridge = new DBBridge();
    protected int _no;
    protected string _lawyername = String.Empty;
    protected string _clientname = String.Empty;
    protected string _Address = String.Empty;
    protected string _Mobile = String.Empty;
    protected string _Email = String.Empty;
    protected string _Details = String.Empty;
    protected string _Remarks = String.Empty;
    const string _spName = "sp_tblClientDetails1";
    #endregion

    #region Class Property

    public int client_id
    {
        get { return _no; }
        set { _no = value; }
    }

    public string Lawyername
    {
        get { return _lawyername; }
        set { _lawyername = value; }
    }

    public string Clientname
    {
        get { return _clientname; }
        set { _clientname = value; }
    }

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    public string Mobile
    {
        get { return _Mobile; }
        set { _Mobile = value; }
    }
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    public string Remarks
    {
        get { return _Remarks; }
        set { _Remarks = value; }
    }
    public string Details
    {
        get { return _Details; }
        set { _Details = value; }
    }

    #endregion

    #region Public Methods

    public int Insert()
    {
        SqlParameter[] param = new SqlParameter[9];
        param[0] = new SqlParameter("@Mode", "Insert");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        param[2] = new SqlParameter("@Clientname", _clientname);
        param[3] = new SqlParameter("@Remarks", _Remarks);
        param[4] = new SqlParameter("@Details", _Details);
        param[5] = new SqlParameter("@Address", _Address);
        param[6] = new SqlParameter("@Mobile", _Mobile);
        param[7] = new SqlParameter("@Email", _Email);
        param[8] = new SqlParameter("@id", _no);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }

    public int Update()
    {
        SqlParameter[] param = new SqlParameter[9];
        param[0] = new SqlParameter("@Mode", "Update");
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        param[2] = new SqlParameter("@Clientname", _clientname);
        param[3] = new SqlParameter("@Remarks", _Remarks);
        param[4] = new SqlParameter("@Details", _Details);
        param[5] = new SqlParameter("@Address", _Address);
        param[6] = new SqlParameter("@Mobile", _Mobile);
        param[7] = new SqlParameter("@Email", _Email);
        param[8] = new SqlParameter("@id", _no);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }
    public int Delete()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "Delete");
        param[1] = new SqlParameter("@Clientname", _clientname);
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
        param[1] = new SqlParameter("@Lawyername", _lawyername);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _clientname = drEmployee["Name"].ToString();
            _Address = drEmployee["Address"].ToString();
            _Remarks = drEmployee["Remarks"].ToString();
            _Details = drEmployee["Details"].ToString();
            _Mobile = drEmployee["Mobile"].ToString();
            _Email = drEmployee["Email"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataSet SelectByName()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByName");
        param[1] = new SqlParameter("@Clientname", _clientname);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _clientname = drEmployee["client_name"].ToString();
            _Address = drEmployee["Address"].ToString();
            _Remarks = drEmployee["Remarks"].ToString();
            _Details = drEmployee["Details"].ToString();
            _Mobile = drEmployee["Mobile"].ToString();
            _Email = drEmployee["Email"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }
    #endregion
}