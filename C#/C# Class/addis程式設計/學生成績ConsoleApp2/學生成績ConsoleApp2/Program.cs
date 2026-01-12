using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/12/9
//author:A108222040
//Objective:student score
namespace 學生成績ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 50;
            int[] studentscoreNumbers = new int[SIZE];
            int[] iArray = new int[SIZE];
            
            //呼叫studentsocre()
            studentsocre(studentscoreNumbers);

            //呼叫highestsocre()
            highestsocre(studentscoreNumbers);
  
            //呼叫lowestsocre()
            lowestsocre(studentscoreNumbers);

            //呼叫averagesocre()
            averagesocre(studentscoreNumbers);

            //呼叫printArray()
            printArray(studentscoreNumbers);
            Console.ReadKey();
        }

        static void averagesocre(int[] studentscoreNumbers)
        {
            float sum = 0;

            for (int i = 0; i < studentscoreNumbers.Length; i ++)

            {
                sum = studentscoreNumbers[i];
            }
            Console.WriteLine("平均分數為" + sum.ToString());
        }

        static void lowestsocre(int[] studentscoreNumbers)
        {
            int min = int.MaxValue; //最小值
            for (int index = 0; index < studentscoreNumbers.Length; index++)
            {
                if (studentscoreNumbers[index] < min)
                {
                    min = studentscoreNumbers[index];
                }
            }
            Console.WriteLine("最低分數為" + min.ToString());
        }

        static void highestsocre(int[] studentscoreNumbers)
        {
            int[] check = new int[100];
            int max = int.MaxValue; //最大值
            for (int index = 0 ; index < studentscoreNumbers.Length ; index ++)
            {
                if (studentscoreNumbers[index] > max)
                {
                    max = studentscoreNumbers[index];
                }
            }
            Console.WriteLine("最高分數為" + max.ToString());
        }

        static void studentsocre(int[] studentscoreNumbers)
        {
            int data;
            int[] check = new int[100];
            Random rand = new Random();
            //將亂數產生的整數放入陣列中
            for (int index = 0; index < studentscoreNumbers.Length; index++)
            {
                do
                {
                    data = rand.Next(1, 100);
                }
                while (data < 1 || data > 100 || check[data] == 1);
                studentscoreNumbers[index] = data;
                check[data] = 1;
            }
        }

        static void printArray(int[] array)
        {
            Console.WriteLine("陣列的內容");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("  " + array[index].ToString());
            }
        }

    }
 }

