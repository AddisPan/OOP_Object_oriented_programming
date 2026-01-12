using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 6;
            int[] lotteryNumbers = new int[SIZE];
            int choice;
            //呼叫選單Method
            choice = menu();
            if (choice == 1) //如果要電腦選號的話,就要呼叫電腦選號的Method
            {
                autoNumbers(lotteryNumbers);
            }
            else //自己選號
            {
                myNumbers(lotteryNumbers);
            }
            //列印出樂透的號碼
            //呼叫printArray()
            printArray(lotteryNumbers);
            Console.ReadKey();
        }

        static int menu()
        {
            int choice;
            Console.WriteLine("要電腦選號請按1還是自選號請按2?");
            do
            {
                choice = getInteger();
            }
            while (choice != 1 && choice != 2); //不是選1和2的時候,要讓使用者從新輸入一個整數 
            return choice;
        }

        //定義getInteger()
        static int getInteger()
        {
            int data;
            Console.WriteLine("請輸入一個整數");
            while (int.TryParse(Console.ReadLine(), out data) == false)
            {
                Console.WriteLine("請輸入一個整數");
            }
            return data;
        }

        //定義myNumbers(int [] lotteryNumbers)
        static void myNumbers(int [] lotteryNumbers)
        {
            int data;
            int[] check = new int [43]; //第一個位置不用
            Console.WriteLine("請輸入自選的六個樂透號碼,數字範圍是1~42");
            for (int index = 0 ; index < lotteryNumbers.Length ; index ++)
            {
                do
                {
                    data = getInteger();
                }
                while ((data < 1 || data > 42) && check[data] == 1);
                lotteryNumbers[index] = data;  //將使用者選入合法的1~42之間的數給陣列
                check[data] = 1;
            }
        }

        //定義autoNumbers(int[]lotterNumbers)
        static void autoNumbers(int[] lotterNumbers)
        {
            int data;
            int[] check = new int[43];
            Random rand = new Random();
            //將亂數產生的整數放入陣列中
            for (int index = 0 ; index < lotterNumbers.Length ; index ++)
            {
                do
                {
                    data = rand.Next(1, 42);
                }
                while (data < 1 || data > 42 || check[data] == 1);
                lotterNumbers[index] = data;
                check[data] = 1;
            }
        }

        static void printArray(int [] array)
        {
            Console.WriteLine("陣列的內容");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write( "  " + array [index].ToString());
            }
        }
    }
}
