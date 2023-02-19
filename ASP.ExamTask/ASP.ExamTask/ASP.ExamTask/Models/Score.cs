using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.ExamTask.Models
{
    public class Score
    {
        public int ScoreID { get; set; }
        public string ScoreName { get; set; }
        public int ScoreValue { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}