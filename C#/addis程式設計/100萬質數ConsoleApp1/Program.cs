using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100萬質數ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int prim = 2;
            bool isPrime = false;
            Console.WriteLine("prim={0}", prim);//2為最小質數，所以先打印出來         
            for (prim = 3; prim <= 1000000; prim++)//質數
            {
                for (count = 2; count < prim; count++)//用於統計循環次數，除數
                {

                    if (prim % count == 0)
                    {
                        isPrime = true;
                        break;
                    }
                    else
                    {
                        isPrime = false;

                    }
                }
                if (isPrime == false)
                    Console.WriteLine("prim={0}", prim);
            }
            Console.ReadKey();
        }
    }
}
