/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : money and time manipulation
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double r;
            double PV;
            double MonthlyRepayments;
   
            Console.Write("enter the number of payments: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("enter the rate of interest: ");
            r = double.Parse(Console.ReadLine())/100;

            Console.Write("enter the value of the loan: ");
            PV = double.Parse(Console.ReadLine());

            double MonthlyRepayment = r * (PV) / 1 - (1 + r) * -n;
            Console.WriteLine("{0}", MonthlyRepayment);




        }
    }
}
