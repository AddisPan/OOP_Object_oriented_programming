using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/12/3
//author:A108222040
//Objective:array practice
namespace _0449ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 6;
            // 宣告一個整數陣列
            int[] lotteryNumbers; //宣告一個參考陣列的變數
            lotteryNumbers = new int[SIZE]; //要建立整數的物件,並且讓變數(array)參考
            //呼叫選單Method
            //int choice = menu();
            double[] arraytwo = new double[SIZE];

            int data;
            //利用迴圈將資料放入陣列中,資料由使用者輸入
            for (int index = 0 ; index < lotteryNumbers.Length ; index ++)
            {
                Console.WriteLine("放入陣列第" + (index + 1) .ToString() + "筆資料");
                //呼叫MethodGetInterger() 
                data = getInteger();
                lotteryNumbers[index] = data; //將99放在陣列的元素中
            }
            //將陣列的內容顯示在螢幕上
            for (int index = 0 ; index < lotteryNumbers.Length ; index ++)
            {
                Console.WriteLine(lotteryNumbers[index].ToString());
            }
            Console.ReadKey();
        }

        //定義getInteger()
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

    }
}
