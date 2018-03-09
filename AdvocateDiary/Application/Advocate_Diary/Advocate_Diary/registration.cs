using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Advocate_Diary
{
    class registration
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string type { get; set; }
        public string contactno { get; set; }
        public string emailid { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public string seq_qes { get; set; }
        public string answer { get; set; }    
    }
}
