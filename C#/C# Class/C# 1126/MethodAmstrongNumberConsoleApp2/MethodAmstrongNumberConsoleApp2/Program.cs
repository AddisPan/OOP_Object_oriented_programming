using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/11/25
//Author:A108222040_潘凌徵
//Objective:Method AmstrongNumber
namespace MethodAmstrongNumberConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用迴圈讓使用者可以多次使用程式
            Console.WriteLine("輸入j繼續使用本程式");
            //宣告變數儲存使用者輸入的字串

            //判斷使用者的輸入,決定迴圈是否繼續
            while (Console.ReadLine() == "j")
            {
                //呼叫兩個整數間所有的阿姆斯壯數
                findAmstrongNumbersBetweenTwoIntgers();

                //再次詢問使用者是否繼續使用本程式
                Console.WriteLine("輸入j繼續使用本程式");
            }//end of while
        }//end of main

        //定義Method findAmstrongNumbersBetweenTwoIntgers()
        static void findAmstrongNumbersBetweenTwoIntgers()
        {
            int Number1;
            int Number2;
            bool AmstrongNumber = true;
            int counter = 0;
            //讀入兩個整數
            inputTwoIntgers(out Number1,out Number2);
            Console.WriteLine("兩整數之間所有阿姆斯壯數如下:");

            //根據整數範圍,依據測試每個數是否為阿姆斯壯數
            for (int i = Number1 ; i <= Number2 ; i ++)
            {
                //呼叫測試阿姆斯壯數的函數
                AmstrongNumber = isAmstrongNumber(i);

                //如果是阿姆斯壯數則印出,加總阿姆斯壯數的個數
                if (AmstrongNumber == true)
                {
                    counter++;
                    //Console.WriteLine(i.ToString());
                }
                //印出阿姆斯壯數的個數
                Console.WriteLine("總共有幾個阿姆斯壯數:" + counter.ToString());
            }
        }// end of findAmstrongNumbersBetweenTwoIntgers()

        //定義Method inputTwoIntgers(),成功讀取使用者輸入的兩個整數,第一個數 <= 第二個數
        static void inputTwoIntgers(out int one,out int second)
        {
            int temp; //宣告變數儲存兩數互換時的某一數
            Console.WriteLine("請輸入第一個整數:");
            while (int.TryParse(Console.ReadLine(),out one) == false) //當使用者沒輸入整數時再詢問一次
            {
                Console.WriteLine("請輸入整數:");
            }
            Console.WriteLine("第一個整數數是:" + one.ToString());

            Console.WriteLine("請輸入第二個整數:");
            while (int.TryParse(Console.ReadLine(), out second) == false) //當使用者沒輸入整數時再詢問一次
            {
                Console.WriteLine("請輸入整數:");
            }
            Console.WriteLine("第二個整數是" + second.ToString());
            //確定one為較小的數,second為較大的數

            //兩數互換
            if (one > second)
            {
                temp = one; //將比較大的數存在temp
                one = second; //將真正比較小的數存在small
                second = temp; //將真正比較大的數存在big
            }
        }// end of inputTwoIntgers()

        //定義 method isAmstrongNumber(),判斷某數是否為阿姆斯壯數
        static bool isAmstrongNumber(int i)
        {
            bool AmstrongNumber = true; //Flag:標示某數是否為阿姆斯壯數,初始值設定為真
            int  remainder, sum = 0;

            for (i = 0; sum != 0; i++)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (sum == i)
            {
                AmstrongNumber = true;
            }
            else
            {
                AmstrongNumber = false;
            }
            return AmstrongNumber;
        }
     }
  }
 

