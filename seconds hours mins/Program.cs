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

namespace seconds_hours_mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            int hours;
            int minutes;
            Console.Write("Please enter the number of seconds: ");
            seconds = int.Parse( Console.ReadLine());
            hours = seconds / 3600;
            minutes = seconds % 3600 / 60;
            seconds = seconds % 3600 % 60;
            Console.WriteLine("The number of hours is {0}, the number of minutes is {1}, and the number of seconds is {2}", hours, minutes, seconds);
        }
    }
}
