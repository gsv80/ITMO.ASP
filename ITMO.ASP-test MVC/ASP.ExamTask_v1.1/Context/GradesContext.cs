using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ASP.ExamTask_v1._1.Models;

namespace ASP.ExamTask_v1._1.Context
{
    public class GradesContext: DbContext
    {
        public GradesContext():base("GradesConnectionStr")
        {

        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

    }
} 