using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Factors
    {
        public void Fact(int n)
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if( n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
