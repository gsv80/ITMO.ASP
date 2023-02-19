using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.ExamTask_v1._1.Models
{
    public class Student
    {
        public int StudentId { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage ="Превышено допустимое число символов") ]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Превышено допустимое число символов")]
        public string LastName { get; set; }
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }

    }
}