using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Series()
        {
            int firstNum=1, secondNum=1;
            int thirdNum;

            Console.WriteLine(firstNum + "\t" + secondNum);
            for(int i=3; i<=10; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;

                Console.Write("\t"+ thirdNum);
            }
        }
    }
}
