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
            string fruit;
            Console.WriteLine("請選擇一項水果?");
            fruit = Console.ReadLine();

            switch (fruit)
            {
                case "西瓜":
                    Console.WriteLine("最喜歡的水果是西瓜");
                    break;

                case " 香蕉":
                    Console.WriteLine("最喜歡的水果是香蕉");
                    break;

                case "葡萄":
                    Console.WriteLine("最喜歡的水果是葡萄");
                    break;


            }
        }
    }
}
