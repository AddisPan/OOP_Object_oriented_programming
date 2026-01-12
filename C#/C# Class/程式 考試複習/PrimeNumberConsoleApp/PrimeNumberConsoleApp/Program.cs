using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNumber;
            bool isPrimeNumber = true;

            Console.WriteLine("請開始本程式,請按y");
            while (Console.ReadLine() == "y")
            {
                Console.WriteLine("請輸入要判斷的整數");
                if (int.TryParse(Console.ReadLine(), out testNumber))
                {
                    isPrimeNumber = findisPrimeNumber(testNumber);
                    Console.WriteLine("這是植樹");
                }
                else
                {
                    Console.WriteLine("這不是");
                }
            }
        }


        static bool findisPrimeNumber(int Number)
        {
            bool isPrime = true;
            int counter = 0;
            for (int i  = 1 ; i <= Number ; i++ )
            {
                if ((Number % i) == 0)
                {
                    counter++;
                }
            }
            if (counter != 2)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
            }
            return isPrime;
        }
    }
}
