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

namespace change
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountDue = 1.98;
            int TotalCents = Convert.ToInt32(amountDue * 100);
            int euros;
            int fifties;
            int twenties;
            int fives;
            int twos;
            int ones;

            euros = TotalCents / 100;
            TotalCents = TotalCents % 100;
            fifties = TotalCents / 50;
            TotalCents = TotalCents % 50;
            twenties = TotalCents / 20;
            TotalCents = TotalCents % 20;
            fives = TotalCents / 5;
            TotalCents = TotalCents % 5;
            twos = TotalCents / 2;
            TotalCents = TotalCents % 2;
            ones = TotalCents;
            Console.WriteLine("{0} euro, {1} fifties, {2} twenties, {3} fives, {4} twos, {5} ones", euros, fifties, twenties, fives, twos, ones);
        }
    }
}
