using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.ExamTask.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ScoreId { get; set; }
        public virtual Score Score { get; set; }
    }
}