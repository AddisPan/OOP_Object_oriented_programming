using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int hundred;
            int ten;
            int one;
            int temp;

            try
            {
                Console.WriteLine("請輸入一個三位數");
                Number = int.Parse(Console.ReadLine());
                if (Number >= 100 && Number <= 999)
                {
                    one = Number % 10;
                    ten = (Number % 100) / 10;
                    hundred = Number / 100;

                    temp = (hundred * hundred * hundred) + (ten * ten * ten) + (one * one * one);

                    if (temp == Number)
                    {
                        Console.WriteLine("This is AmstrongNumber");
                    }
                    else
                    {
                        Console.WriteLine("This is not AmstrongNumber");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("這不是一個三位數");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}
