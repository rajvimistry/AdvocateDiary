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

namespace Employee.BLL
{
    public class clsEmployee
    {
        public clsEmployee()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #region Variables
        DBBridge objDBBridge = new DBBridge();
        protected int _LawyerId;
        protected string _FirstName = String.Empty;
        protected string _LastName = String.Empty;
        protected string _username = String.Empty;
        protected DateTime _DOB;
        protected string _Address = String.Empty;
        protected string _password = String.Empty;
        //protected string _City = String.Empty;
        //protected string _State = String.Empty;
        //protected string _Zip = String.Empty;
        //protected string _Phone = String.Empty;
        protected string _Mobile = String.Empty;
        protected string _Email = String.Empty;
        protected string _type = String.Empty;
        protected string _seq_que = String.Empty;
        protected string _answer = String.Empty;
        //protected string _Designation = String.Empty;
        //protected int _DepartmentId;
        //protected DateTime _DOJ;
        //protected DateTime _DOC;
        //protected string _Bio = String.Empty;
        //protected string _Degree = String.Empty;
        //protected string _Photo = String.Empty;
        //protected int _Status;
        //protected int _Years;
        const string _spName = "sp_tblLawyer1";
        #endregion

        #region Class Property
        public int EmployeeId
        {
            get { return _LawyerId; }
            set { _LawyerId = value; }
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
        //public string City
        //{
        //    get { return _City; }
        //    set { _City = value; }
        //}
        //public string State
        //{
        //    get { return _State; }
        //    set { _State = value; }
        //}
        //public string Zip
        //{
        //    get { return _Zip; }
        //    set { _Zip = value; }
        //}
        //public string Phone
        //{
        //    get { return _Phone; }
        //    set { _Phone = value; }
        //}
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

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //public string Designation
        //{
        //    get { return _Designation; }
        //    set { _Designation = value; }
        //}
        //public int DepartmentId
        //{
        //    get { return _DepartmentId; }
        //    set { _DepartmentId = value; }
        //}
        //public DateTime DOJ
        //{
        //    get { return _DOJ; }
        //    set { _DOJ = value; }
        //}
        //public DateTime DOC
        //{
        //    get { return _DOC; }
        //    set { _DOC = value; }
        //}
        //public string Bio
        //{
        //    get { return _Bio; }
        //    set { _Bio = value; }
        //}
        //public string Degree
        //{
        //    get { return _Degree; }
        //    set { _Degree = value; }
        //}
        //public string Photo
        //{
        //    get { return _Photo; }
        //    set { _Photo = value; }
        //}
        //public int Status
        //{
        //    get { return _Status; }
        //    set { _Status = value; }
        //}
        //public int Years
        //{
        //    get { return _Years; }
        //    set { _Years = value; }
        //}
        #endregion

        #region Public Methods

        public int Insert()
        {
            SqlParameter[] param = new SqlParameter[12];
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
            param[11] = new SqlParameter("@Type", _type);
            //param[9] = new SqlParameter("@Type",_type);
            //param[4] = new SqlParameter("@City", _City);
            //param[5] = new SqlParameter("@State", _State);
            //param[6] = new SqlParameter("@Zip", _Zip);
            //param[7] = new SqlParameter("@Phone", _Phone);
            //param[8] = new SqlParameter("@Mobile", _Mobile);
            //param[9] = new SqlParameter("@Email", _Email);
            //param[10] = new SqlParameter("@Designation", _Designation);
            //param[11] = new SqlParameter("@DepartmentId", _DepartmentId);
            //param[12] = new SqlParameter("@DOJ", _DOJ);
            //param[13] = new SqlParameter("@DOC", _DOC);
            //param[14] = new SqlParameter("@Bio", _Bio);
            //param[15] = new SqlParameter("@Degree", _Degree);
            //param[16] = new SqlParameter("@Photo", _Photo);
            //param[17] = new SqlParameter("@Status", _Status);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int Update()
        {
            SqlParameter[] param = new SqlParameter[12];
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
            param[11] = new SqlParameter("@Type", _type);
            //param[9] = new SqlParameter("@Type", _type);

            //SqlParameter[] param = new SqlParameter[19];
            //param[0] = new SqlParameter("@Mode", "Update");
            //param[1] = new SqlParameter("@Name", _FirstName);
            //param[2] = new SqlParameter("@DOB", _DOB);
            //param[3] = new SqlParameter("@Address", _Address);
            //param[4] = new SqlParameter("@City", _City);
            //param[5] = new SqlParameter("@State", _State);
            //param[6] = new SqlParameter("@Zip", _Zip);
            //param[7] = new SqlParameter("@Phone", _Phone);
            //param[8] = new SqlParameter("@Mobile", _Mobile);
            //param[9] = new SqlParameter("@Email", _Email);
            //param[10] = new SqlParameter("@Designation", _Designation);
            //param[11] = new SqlParameter("@DepartmentId", _DepartmentId);
            //param[12] = new SqlParameter("@DOJ", _DOJ);
            //param[13] = new SqlParameter("@DOC", _DOC);
            //param[14] = new SqlParameter("@Bio", _Bio);
            //param[15] = new SqlParameter("@Degree", _Degree);
            //param[16] = new SqlParameter("@Photo", _Photo);
            //param[17] = new SqlParameter("@Status", _Status);
            //param[18] = new SqlParameter("@EmployeeId", _LawyerId);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int Update_password()
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Mode", "Up_Password");
            param[1] = new SqlParameter("@Username", _username);
            param[2] = new SqlParameter("@Password", _password);
            return objDBBridge.ExecuteNonQuery(_spName, param);
        }

        public int Delete()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Mode", "Delete");
            param[1] = new SqlParameter("@LawyerId", _LawyerId);
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

        //public DataSet SelectByExperience()
        //{
        //    SqlParameter[] param = new SqlParameter[2];
        //    if (_Years == -1)
        //    {
        //        param[0] = new SqlParameter("@Mode", "ViewService");
        //    }
        //    else
        //    {
        //        param[0] = new SqlParameter("@Mode", "FilterService");
        //    }
        //    param[1] = new SqlParameter("@Years", _Years);
        //    return objDBBridge.ExecuteDataset(_spName, param);
        //}

        //public DataSet ViewYears()
        //{
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@Mode", "ViewYears");
        //    return objDBBridge.ExecuteDataset(_spName, param);
        //}


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

        public DataSet Birthday()
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mode", "Birthday");
            return objDBBridge.ExecuteDataset(_spName, param);
        }

        public void SelectById()
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Mode", "ViewByID");
            param[1] = new SqlParameter("@LawyerId", _LawyerId);
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
                _username=drEmployee["User_name"].ToString();
                //_City = drEmployee["City"].ToString();
                //_State = drEmployee["State"].ToString();
                //_Zip = drEmployee["Zip"].ToString();
                //_Phone = drEmployee["Phone"].ToString();
                _Mobile = drEmployee["Mobile"].ToString();
                _Email = drEmployee["Email"].ToString();
                _password = drEmployee["Password"].ToString();
                _seq_que = drEmployee["seq_que"].ToString();
                _answer = drEmployee["answer"].ToString();
                _type = drEmployee["Type"].ToString();
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
                _username = drEmployee["User_name"].ToString();
                //_City = drEmployee["City"].ToString();
                //_State = drEmployee["State"].ToString();
                //_Zip = drEmployee["Zip"].ToString();
                //_Phone = drEmployee["Phone"].ToString();
                _Mobile = drEmployee["Mobile"].ToString();
                _Email = drEmployee["Email"].ToString();
                _password = drEmployee["Password"].ToString();
                _seq_que = drEmployee["seq_que"].ToString();
                _answer = drEmployee["answer"].ToString();
                _type = drEmployee["Type"].ToString();
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

        public string EmployeeCount()
        {
            string cntEmp = "0";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Mode", "EmpCount");
            DataTable dtEmployee = new DataTable();
            dtEmployee = objDBBridge.ExecuteDataset(_spName, param).Tables[0];
            if (dtEmployee.Rows.Count != 0)
            {
                DataRow drEmployee;
                drEmployee = dtEmployee.Rows[0];
                cntEmp = drEmployee["EmpCount"].ToString();
            }
            return cntEmp;
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
            param[2] = new SqlParameter("@Ans", _answer);
            return objDBBridge.ExecuteDataset(_spName, param).Tables[0];
        }

        #endregion
    }
}