using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        int i;
        int n;
        double s = 0.0;
        public void Harmonic(int n)
        {   
            for (int i = 1; i <=n; i++) 
            {
                Console.Write("1/{0} + " ,i);
                s+= 1/(float)i;              
            }
        }
    }
}
