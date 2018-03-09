using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Advocate_Diary
{
    class lawyer
    {
        [PrimaryKey , AutoIncrement]
        public string username { get; set; }
        public string working_field { get; set; }
        public string exp { get; set; }
        public string about { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public string contactno { get; set; }
        public string image { get; set; }
    }
}
