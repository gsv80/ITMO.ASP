using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.ExamTask_v1._1.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeDescr { get; set; }

        [Required]
        public int GradeValue { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}