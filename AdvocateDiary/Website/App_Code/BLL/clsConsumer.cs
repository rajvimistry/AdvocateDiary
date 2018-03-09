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
/// Summary description for clsConsumer
/// </summary>
public class clsConsumer
{
	public clsConsumer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    #region Variables
    DBBridge objDBBridge = new DBBridge();
    protected int _Id;
    protected string _FirstName = String.Empty;
    protected string _LastName = String.Empty;
    protected string _username = String.Empty;
    protected DateTime _DOB;
    protected string _Address = String.Empty;
    protected string _password = String.Empty;
    protected string _Mobile = String.Empty;
    protected string _Email = String.Empty;
    protected string _seq_que = String.Empty;
    protected string _answer = String.Empty;
    const string _spName = "sp_tblconsumer";
    #endregion

    #region Class Property

    public int ConsumerId
    {
        get { return _Id; }
        set { _Id = value; }
    }

    public string Name
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }

    public string L_Name
    {
        get { return _LastName; }
        set { _LastName = value; }
    }

    public string Uname
    {
        get { return _username; }
        set { _username = value; }
    }

    public DateTime DOB
    {
        get { return _DOB; }
        set { _DOB = value; }
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

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }

    public string Question
    {
        get { return _seq_que; }
        set { _seq_que = value; }
    }
    public string Answer
    {
        get { return _answer; }
        set { _answer = value; }
    }

     #endregion

        #region Public Methods

        public int Insert()
        {
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@Mode", "Insert");
            param[1] = new SqlParameter("@First_Name", _FirstName);
            param[2] = new SqlParameter("@Last_Name", _LastName);
            param[3] = new SqlParameter("@UserName", _username);
            param[4] = new SqlParameter("@DOB", _DOB);
            param[5] = new SqlParameter("@Address", _Address);
            param[6] = new SqlParameter("@Mobile", _Mobile);
            param[7] = new SqlParameter("@Email", _Email);
            param[8] = new SqlParameter("@Password", _password);
            param[9] = new SqlParameter("@Seq_que", _seq_que);
            param[10] = new SqlParameter("@Ans", _answer);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int Update()
        {
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@Mode", "Update");
            param[1] = new SqlParameter("@First_Name", _FirstName);
            param[2] = new SqlParameter("@Last_Name", _LastName);
            param[3] = new SqlParameter("@Username", _username);
            param[4] = new SqlParameter("@DOB", _DOB);
            param[5] = new SqlParameter("@Address", _Address);
            param[6] = new SqlParameter("@Mobile", _Mobile);
            param[7] = new SqlParameter("@Email", _Email);
            param[8] = new SqlParameter("@Password", _password);
            param[9] = new SqlParameter("@Seq_que", _seq_que);
            param[10] = new SqlParameter("@Ans", _answer);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int Update_password()
        { 
            SqlParameter[] param=new SqlParameter[3];
            param[0] = new SqlParameter("@Mode", "Up_Password");
            param[1] = new SqlParameter("@Username", _username);
            param[2] = new SqlParameter("@Password", _password);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int Delete()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Mode", "Delete");
            param[1] = new SqlParameter("@Id", _Id);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int DeleteByName()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Mode", "DeleteByName");
            param[1] = new SqlParameter("@Username", _username);
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
        
    public string EmployeeCount()
        {
            //string cntEmp = "0";
            //SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@Mode", "EmpCount");
            //DataTable dtEmployee = new DataTable();
            //dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
            //if (dtEmployee.Rows.Count != 0)
            //{
            //    DataRow drEmployee;
            //    drEmployee = dtEmployee.Rows[0];
            //    cntEmp = drEmployee["EmpCount"].ToString();
            //}
            //return cntEmp;
            return null;
        }

    public void SelectById()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewById");
        param[1] = new SqlParameter("@Id", _Id);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _FirstName = drEmployee["First_Name"].ToString();
            _DOB = Convert.ToDateTime(drEmployee["DOB"]);
            _Address = drEmployee["Address"].ToString();
            _LastName = drEmployee["Last_Name"].ToString();
            _username = drEmployee["Username"].ToString();
            //_City = drEmployee["City"].ToString();
            //_State = drEmployee["State"].ToString();
            //_Zip = drEmployee["Zip"].ToString();
            //_Phone = drEmployee["Phone"].ToString();
            _Mobile = drEmployee["Mobile"].ToString();
            _Email = drEmployee["Email"].ToString();
            _password = drEmployee["Password"].ToString();
            _seq_que = drEmployee["Seq_que"].ToString();
            _answer = drEmployee["Answer"].ToString();
            //_Designation = drEmployee["Designation"].ToString();
            //_DepartmentId = Convert.ToInt32(drEmployee["DepartmentId"]);
            //_DOJ = Convert.ToDateTime(drEmployee["DOJ"]);
            //_DOC = Convert.ToDateTime(drEmployee["DOC"]);
            //_Bio = drEmployee["Bio"].ToString();
            //_Degree = drEmployee["Degree"].ToString();
            //_Photo = drEmployee["Photo"].ToString();
            //_Status = Convert.ToInt32(drEmployee["Status"]);
        }
    }

    public void SelectByName()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ViewByName");
        param[1] = new SqlParameter("@Username", _username);
        DataTable dtEmployee = new DataTable();
        dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        if (dtEmployee.Rows.Count != 0)
        {
            DataRow drEmployee;
            drEmployee = dtEmployee.Rows[0];
            _FirstName = drEmployee["First_Name"].ToString();
            _DOB = Convert.ToDateTime(drEmployee["DOB"]);
            _Address = drEmployee["Address"].ToString();
            _LastName = drEmployee["Last_Name"].ToString();
            _username = drEmployee["Username"].ToString();
            //_City = drEmployee["City"].ToString();
            //_State = drEmployee["State"].ToString();
            //_Zip = drEmployee["Zip"].ToString();
            //_Phone = drEmployee["Phone"].ToString();
            _Mobile = drEmployee["Mobile"].ToString();
            _Email = drEmployee["Email"].ToString();
            _password = drEmployee["Password"].ToString();
            _seq_que = drEmployee["seq_que"].ToString();
            _answer = drEmployee["answer"].ToString();
            //_type = drEmployee["Type"].ToString();
            //_Designation = drEmployee["Designation"].ToString();
            //_DepartmentId = Convert.ToInt32(drEmployee["DepartmentId"]);
            //_DOJ = Convert.ToDateTime(drEmployee["DOJ"]);
            //_DOC = Convert.ToDateTime(drEmployee["DOC"]);
            //_Bio = drEmployee["Bio"].ToString();
            //_Degree = drEmployee["Degree"].ToString();
            //_Photo = drEmployee["Photo"].ToString();
            //_Status = Convert.ToInt32(drEmployee["Status"]);
        }
    }

    public DataTable ValidateLogin()
    {
        SqlParameter[] param = new SqlParameter[3];
        param[0] = new SqlParameter("@Mode", "ChkLogin");
        param[1] = new SqlParameter("@Username", _username);
        param[2] = new SqlParameter("@Password", _password);
        return objDBBridge.ExecuteDataset(_spName, param).Tables[0];
    }

    public DataTable chkName()
    {
        SqlParameter[] param = new SqlParameter[2];
        param[0] = new SqlParameter("@Mode", "ChkName");
        param[1] = new SqlParameter("@Username", _username);
        return objDBBridge.ExecuteDataset(_spName, param).Tables[0];
    }

    public DataTable chkAnswer()
    {
        SqlParameter[] param = new SqlParameter[3];
        param[0] = new SqlParameter("@Mode", "ChkAns");
        param[1] = new SqlParameter("@Username", _username);
        param[2] = new SqlParameter("@Ans",_answer);
        return objDBBridge.ExecuteDataset(_spName, param).Tables[0];
    }

        #endregion
}