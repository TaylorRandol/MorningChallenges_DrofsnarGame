using MethodReviewSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodHolder helper = new MethodHolder();
            int catcher = helper.Number("This is a long string because it is a long string that is very long.");

            Console.WriteLine("The number number gave back is: " + catcher);
            Console.ReadLine();
        }
    }
}
