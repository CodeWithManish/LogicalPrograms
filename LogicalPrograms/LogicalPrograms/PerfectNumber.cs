using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int number = 28, sum = 0;

            for(int i=1; i<=number/2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if(sum == number)
            {
                Console.WriteLine("A perfect Number \n");

            }
            else
            {
                Console.WriteLine("Not a Perfect Number \n");
            }
        }
    }
}
