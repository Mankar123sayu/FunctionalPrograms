using FunctionalPrograms;
using System;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute \n 1. Flip Coin"); //\n 2.Power of 2 \n 3. Prime Factor \n 4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: FlipCoin flip = new FlipCoin();
                        Console.WriteLine("Enter num of flips: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        flip.Flip(num);
                        break;
                    /*case 2: 
                        PowerOfTwo power = new PowerOfTwo();
                        Console.WriteLine("Enter the power: ");
                        int num1 = Convert.ToByte(Console.ReadLine());
                        power.Display(num1);
                        break;
                    case 3:
                        PrimeFactor prime = new PrimeFactor();
                        Console.WriteLine("Enter the number: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        prime.factor(num2);
                        break;*/
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
