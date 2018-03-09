using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Advocate_Diary
{
    public partial class client_details
    {
        [PrimaryKey , AutoIncrement]
        public int cno { get; set; }
        public string lawyername { get; set; }
        public string clientname { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string remark { get; set; }
        public string case_details { get; set; }
    }
}
