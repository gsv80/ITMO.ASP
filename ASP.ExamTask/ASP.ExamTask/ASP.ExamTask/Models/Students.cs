using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.ExamTask
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ScoreID { get; set; }


        public override string ToString()
        {
            string s = FirstName + " " + LastName;
            return s;
        }


    }
}