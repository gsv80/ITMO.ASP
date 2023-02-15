using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using WebMVCR1_L2.Models;

namespace WebMVCR1_L2.Controllers
{
    public class HomeController : Controller
    {
        // GET: My
        //public ActionResult Index()
        //{
        //    return View();
        //}

        StringBuilder str= new StringBuilder();

        Shape[] sh =
        {
            new Triangle(1,2,3),
            new Circle(5),
            new Triangle(5,6,8)
        };

        public string ExePolim()
        {
            foreach (Shape shape in sh)
            {
                str.AppendFormat($"Это фигура  {shape.Name}  <p> ");
            }
            return str.ToString();
        }
        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского счета {0}", goldAccount);
            string res2 = String.Format("Тип банковского счета {0}", platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            string res = String.Format("Информация о банковском  счете: {0}", goldBankAccount);


            return res;
        }

        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
            {
                return String.Format("Факториал числа {0} равен {1}", x, f);

            }
            else
            {
                return "Невозможно вычислить факториал";
            }
        }

        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0}  равна: {1:0.##}", tr1.Name, tr1.Area);
            return sq1;
        }

        public string ExeCircle()
        {
            Circle cr1 = new Circle(3);
            string ar1 = String.Format("Площадь фигуры {0}  равна: {1:0.##}", cr1.Name, cr1.Area);
            return ar1;
        }

        // task 5 Collection 

        public string ExeCollection() 
        {
            List<Circle> circles = new List<Circle>
            {
                new Circle(12),
                new Circle(5),
                new Circle(15),
                new Circle(6)
            };
            circles.Add(new Circle(7));
            circles.Sort();
            StringBuilder str= new StringBuilder();
            foreach(Shape item in circles)
            {
                str.AppendFormat($"Это фигура {item.Name} <p>");
            }
            return str.ToString();
        }
        public string Index()
        {
            //string res = ExeEnum();
            //string res = ExeStruct();
            //string res = StudyCsharp.SetStatus(3);
            //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(15));
            //string res = StudyCsharp.GetFunction(0, 9);

            //string res = ExeFactorial(7);

            //string res = ExeTriangle();

            //string res = ExeCircle();

                    // --- Task 4 ----

            //string res = ExePolim();
                
                    // --- Task 5 ---
            string res = ExeCollection();

            return res;
        }

        
    }
}