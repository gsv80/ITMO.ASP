using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ASP.ExamTask.Models
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(): base("StudentsScores")
        {

        }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }      
    }
}