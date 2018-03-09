using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Advocate_Diary
{
    class qna
    {
        [AutoIncrement,PrimaryKey]
        public int qno { get; set; }
        public string question { get; set; }
        public string ans1 { get; set; }
        public string ans2 { get; set; }
        public string ans3 { get; set; }
        public string ans4 { get; set; }
        public string ans5 { get; set; }
        public string ans6 { get; set; }
        public string ans7 { get; set; }
        public string ans8 { get; set; }
        public string ans9 { get; set; }
        public string ans10 { get; set; }
    }
}
