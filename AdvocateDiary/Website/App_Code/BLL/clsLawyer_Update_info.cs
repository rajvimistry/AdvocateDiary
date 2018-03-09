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
/// Summary description for clsLawyer_Update_info
/// </summary>
public class clsLawyer_Update_info
{
	public clsLawyer_Update_info()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    #region Variables
    DBBridge objDBBridge = new DBBridge();
    protected int _id;
    protected string _lawyer_name = String.Empty;
    protected string _working_field = String.Empty;
    protected string _experience = String.Empty;
    protected string _address = String.Empty;
    protected string _city = String.Empty;
    protected string _state = String.Empty;
    protected string _contact_1 = String.Empty;
    protected string _contact_2 = String.Empty;
    protected string _email = String.Empty;
    protected string _about_me = String.Empty;
    const string _spName = "sp_tblLawyer_info";
    #endregion

    #region Class Property

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Lawyername
    {
        get { return _lawyer_name; }
        set { _lawyer_name = value; }
    }

    public string Workingfield
    {
        get { return _working_field; }
        set { _working_field = value; }
    }

    public string Experience
    {
        get { return _experience; }
        set { _experience = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public string Contact
    {
        get { return _contact_1; }
        set { _contact_1 = value; }
    }

    public string Contact2
    {
        get { return _contact_2; }
        set { _contact_2 = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string About
    {
        get { return _about_me; }
        set { _about_me = value; }
    }

    #endregion

    #region Public Methods

    public int Insert()
    {
        SqlParameter[] param = new SqlParameter[11];
        param[0] = new SqlParameter("@Mode", "Insert");
        param[1] = new SqlParameter("@Lawyername", _lawyer_name);
        param[2] = new SqlParameter("@Working_field", _working_field);
        param[3] = new SqlParameter("@Experience", _experience);
        param[4] = new SqlParameter("@Address", _address);
        param[5] = new SqlParameter("@City", _city);
        param[6] = new SqlParameter("@State", _state);
        param[7] = new SqlParameter("@Contact_O", _contact_1);
        param[8] = new SqlParameter("@Contact_M", _contact_2);
        param[9] = new SqlParameter("@Email", _email);
        param[10] = new SqlParameter("@About", _about_me);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }

    public int Update()
    {
        SqlParameter[] param = new SqlParameter[11];
        param[0] = new SqlParameter("@Mode", "Update");
        param[1] = new SqlParameter("@Lawyername", _lawyer_name);
        param[2] = new SqlParameter("@Working_field", _working_field);
        param[3] = new SqlParameter("@Experience", _experience);
        param[4] = new SqlParameter("@Address", _address);
        param[5] = new SqlParameter("@City", _city);
        param[6] = new SqlParameter("@State", _state);
        param[7] = new SqlParameter("@Contact_O", _contact_1);
        param[8] = new SqlParameter("@Contact_M", _contact_2);
        param[9] = new SqlParameter("@Email", _email);
        param[10] = new SqlParameter("@About", _about_me);
        return objDBBridge.ExecuteNonQuery(_spName, param);
    }
    public int Delete()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "Delete");
        param[1] = new SqlParameter("@Topicname", _lawyer_name);
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

    public DataSet SelecByWorkingfield()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByWorkingField");
        param[1] = new SqlParameter("@Working_field", Workingfield);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _working_field = drEmployee["Working_field"].ToString();
            _experience = drEmployee["Experience"].ToString();
            _address = drEmployee["Address"].ToString();
            _city = drEmployee["City"].ToString();
            _state = drEmployee["State"].ToString();
            _contact_1 = drEmployee["Contact_O"].ToString();
            _contact_2 = drEmployee["Contact_M"].ToString();
            _email = drEmployee["Email"].ToString();
            _about_me = drEmployee["About_me"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataSet SelecByCity()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByCity");
        param[1] = new SqlParameter("@City", City);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _working_field = drEmployee["Working_field"].ToString();
            _experience = drEmployee["Experience"].ToString();
            _address = drEmployee["Address"].ToString();
            _city = drEmployee["City"].ToString();
            _state = drEmployee["State"].ToString();
            _contact_1 = drEmployee["Contact_O"].ToString();
            _contact_2 = drEmployee["Contact_M"].ToString();
            _email = drEmployee["Email"].ToString();
            _about_me = drEmployee["About_me"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public DataSet SelectByName()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByName");
        param[1] = new SqlParameter("@Lawyername", Lawyername);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _working_field = drEmployee["Working_field"].ToString();
            _experience = drEmployee["Experience"].ToString();
            _address = drEmployee["Address"].ToString();
            _city = drEmployee["City"].ToString();
            _state = drEmployee["State"].ToString();
            _contact_1 = drEmployee["Contact_O"].ToString();
            _contact_2 = drEmployee["Contact_M"].ToString();
            _email = drEmployee["Email"].ToString();
            _about_me = drEmployee["About_me"].ToString();
        }
        return objDBBridge.ExecuteDataset(_spName, param);
    }

    public void SelectById()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByID");
        param[1] = new SqlParameter("@Lawyername", Lawyername);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _working_field = drEmployee["Working_field"].ToString();
            _experience = drEmployee["Experience"].ToString();
            _address = drEmployee["Address"].ToString();
            _city = drEmployee["City"].ToString();
            _state = drEmployee["State"].ToString();
            _contact_1 = drEmployee["Contact_O"].ToString();
            _contact_2 = drEmployee["Contact_M"].ToString();
            _email = drEmployee["Email"].ToString();
            _about_me = drEmployee["About_me"].ToString();
        }
    }
    #endregion
}