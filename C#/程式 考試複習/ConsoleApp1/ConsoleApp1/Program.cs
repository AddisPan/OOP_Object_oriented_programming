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
            
            string inputdata;
            float timesalary;
            float week;
            float totalsalary;

            Console.WriteLine("請輸入你的時薪?");
            inputdata = Console.ReadLine();

            timesalary = int.Parse(inputdata);

            Console.WriteLine("請輸入你的工作週數?");
            inputdata = Console.ReadLine();

            week = int.Parse(inputdata);

            
            totalsalary = timesalary * week;

            Console.WriteLine("這次薪水" + totalsalary);
            
            Console.ReadKey();
        }
    }
}
