using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1_L2.Models
{
    public class Shape
    {
        public double St { get; set; }
        virtual public string Name { 
            get
            {
                return String.Format("\"Фигура\"");
            }
        }

    }
}