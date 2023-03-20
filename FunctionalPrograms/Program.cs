using FunctionalPrograms;
using System;

namespace FunctionalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Functional Programs");
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" \n Choose an option to execute \n 1. Flip Coin \n 2. LeapYear \n 3. PowerOf2 \n 4. HarmonicNumber \n 5. Factors \n 6. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: FlipCoin flip = new FlipCoin();
                        Console.WriteLine("Enter num of flips: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        flip.Flip(num);
                        break;
                    case 2: 
                        LeapYear find = new LeapYear();
                        Console.WriteLine("Enter the year: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        find.Leap(num1);
                        break;
                    case 3:
                        PowerOf2 power = new PowerOf2();
                        Console.WriteLine("Enter the degree of power: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        power.Display(num2);
                        break;
                    case 4:
                        HarmonicNumber number = new HarmonicNumber();
                        Console.WriteLine("Enter the number: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        number.Harmonic(num3);
                        break;

                   case 5:
                        Factors fac = new Factors();
                        Console.WriteLine("Enter the number: ");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        fac.Fact(num4);
                        break;

                    case 6:
                        flag = false;
                        break;
                }
            }      
        }
    }
}
