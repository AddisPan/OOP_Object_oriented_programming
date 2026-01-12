using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1230ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 6;
            int[] lotteryNumber = new int[SIZE];
            int choice;
            choice = menu();

            if (choice == 1)
            {
                autoNumber(lotteryNumber);
            }
            else
            {
                myNumber(lotteryNumber);
            }
            printArray(lotteryNumber);
            Console.ReadKey();
        }

        static int menu()
        {
            int choice;
            Console.WriteLine("電腦選號請選1,自己選號2");
            do
            {
                choice = getInteger();
            }
            while (choice != 1 && choice != 2);
            return choice;
        }

        static int getInteger()
        {
            int data;
            Console.WriteLine("請輸入一個整數");
            while (int.TryParse(Console.ReadLine(),out data) == false)
            {
                Console.WriteLine("請輸入一個整數");
            }
            return data;
        }

        static void autoNumber(int [] lotteryNumber)
        {
            int data;
            int[] check = new int[43];
            Console.WriteLine("請自行輸入六個1~42的數字");
            for (int index = 0; index < lotteryNumber.Length; index++)
            {
                do
                {
                    data = getInteger();
                }
                while ((data < 1 || data > 42) && check[data] == 1);
                lotteryNumber[index] = data;
                check[data] = 1;
            }
        }

        static void myNumber(int[] lotteryNumber)
        {
            int data;
            int[] check = new int[43];
            Random rand = new Random();

            for (int index = 0 ; index < lotteryNumber.Length ; index ++ )
            {
                do
                {
                    data = rand.Next(1, 42);
                }
                while (data < 1 || data < 42 || check[index] == 1);
                lotteryNumber[index] = data;
                check[data] = 1;
            }
        }

        static void printArray(int [] array)
        {
            Console.WriteLine("陣列的內容");
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("  " + array[index].ToString());
            }
        }
    }
}
