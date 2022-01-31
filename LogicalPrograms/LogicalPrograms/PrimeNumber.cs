using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void Prime()
        {
            int num = 7, count = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("Number is Prime Number \n");
            }
            else
            {
                Console.WriteLine("Number is not Prime Number \n");
            }
        }
    }
}
