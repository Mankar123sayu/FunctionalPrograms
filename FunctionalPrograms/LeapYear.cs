using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LeapYear
    {
        public void Leap(int year) 
        {
            if (year < 999 || year > 10000)
                Console.WriteLine("Please enter a valid year");
            else
                if (year % 400 == 0)
                Console.WriteLine($"{year} is a leap year");
            else if (year % 100 == 0)
                Console.WriteLine($"{year} is not a leap year");
            else if (year % 4 == 0)
                Console.WriteLine($"{year} is a leap year");
            else
                Console.WriteLine($"{year} is not a leap year");
        }
    }
}
