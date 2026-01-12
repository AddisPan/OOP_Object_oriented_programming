using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> WordCounterList = new List<string>();
            //List<int> counter = new List<int>();

            int counter = 1;

            Console.WriteLine("請輸入一個句子");

            WordCounterList.Add(Console.ReadLine());

            string line = " ";

            foreach (string item in WordCounterList)
            {
                line = line + item + '\n';
            }
            WordCounterList.Add(line);

            for (int i = 0 ; i < WordCounterList.Count ; i++)
            {
                counter++;
            }

            Console.WriteLine("總共有 : " + counter.ToString());

            Console.ReadKey();
        }
    }
}
