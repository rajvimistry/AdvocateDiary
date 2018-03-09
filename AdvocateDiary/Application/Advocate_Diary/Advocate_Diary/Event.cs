using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Advocate_Diary
{
    class Event
    {
        [PrimaryKey , AutoIncrement]
        public int eno { get; set;}
        public string username { get; set; }
        public string event_name { get; set; }
        public DateTime date { get; set; }
        public string time { get; set; }
    }
}
