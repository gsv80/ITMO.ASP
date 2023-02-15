using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace WebMVCR1_L2.Models
{
    public class Circle : Shape , IComparable<Circle>
    {
        
        override public string Name => String.Format($"\"Окружность с радиусом {St} \"");
        public Circle(double a)=> St = a;

        public double Length
        {
            get
            {
                double p = 2 * Math.PI * St;
                return p;
            }
        } 

        public double Area
        {
            get
            {
                double ar = Math.PI * St*St;
                return ar;
            }
        }

        //Task 5 - using IComparable interface
        public int CompareTo(Circle other)
        {
            if(this.Area == other.Area) return 0;
            else if(this.Area> other.Area) return 1;
            else return -1;
        }
    }
}