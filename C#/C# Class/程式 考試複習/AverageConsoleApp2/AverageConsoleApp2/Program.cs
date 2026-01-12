using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;
            float averagescore;
            string inputdata;

            Console.WriteLine("Enter first score");
            inputdata = Console.ReadLine();

            first = int.Parse(inputdata);

            Console.WriteLine("Enter second score");
            inputdata = Console.ReadLine();

            second = int.Parse(inputdata);

            Console.WriteLine("Enter third score");
            inputdata = Console.ReadLine();

            third = int.Parse(inputdata);

            averagescore = (first + second + third ) / 3;

            Console.WriteLine("平均成績:" + averagescore);

            Console.ReadKey();
            

        }
    }
}
