using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1_L2.Models
{
    public class Triangle : Shape
    {
        //public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }

        
        public Triangle(double sta, double stb, double stc)
        {
            St = sta;
            Stb = stb;
            Stc = stc;
        }

        public double Perimetr => Math.Round(St+Stb+Stc);
        override public string Name => $"\"Треугольник со  сторонами {St}, {Stb} и {Stc}\"";



        public double Area
        {
            get
            {
                double pHalf = Perimetr / 2;
                double area = Math.Sqrt(pHalf*(pHalf - St)*(pHalf-Stb)*(pHalf-Stc));
                return area;
            }
        }
    }
}