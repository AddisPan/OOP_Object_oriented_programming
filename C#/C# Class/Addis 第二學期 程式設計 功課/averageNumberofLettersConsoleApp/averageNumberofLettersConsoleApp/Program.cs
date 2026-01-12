using System;
using System.Collections.Generic;

namespace averageNumberofLettersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s;
            List<string> wordsToList = new List<string>();
            int count;

            Console.WriteLine("輸入句子");
            s = Console.ReadLine().Split(null);

            foreach (var w in s)
            {
                wordsToList.Add(w);
            }

            count = wordsToList.Count;
            double average = averageOfChar(wordsToList, count);
            Console.WriteLine($"有{count}個字,一個字平均{average}個字元");

            Console.ReadKey();
        }

        static double averageOfChar(List<string> wordsToList,int count) 
        {
            float total = 0;

            for (var index = 0;index< wordsToList.Count;index++) 
            {
                total += wordsToList[index].Length;
            }
            return Math.Round(total / count,2);
        }
    }
}
