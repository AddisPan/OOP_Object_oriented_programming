using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:11/19
//autor:A108222040_Addis Pan
//Objective:method及各種method寫法及迴圈語法的使用
namespace ConsoleApplicationV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用迴圈讓使用者可以多次使用的程式
            Console.WriteLine("輸入a繼續使用本程式");
            //宣告變數儲存使用者的輸入字串

            //判斷使用者的輸入,決定迴圈是否繼續
            while (Console.ReadLine() == "a")
            {
                //呼叫找兩個整數之間所有的質數
                findPrimeNumbersBetweenTwoIntgers();

                //再次詢問使用者是否繼續使用本程式
                Console.WriteLine("輸入a繼續使用本程式");

            }//end of while
        }//end of Main

        //定義 method findPrimeNumbersBetweenTwoIntgers()
        static void findPrimeNumbersBetweenTwoIntgers()
        {
            int smallNumber;
            int bigNumber;
            bool primeNumber = true;
            int counter = 0;
            //讀入兩個整數
            inputTwoIntegers(out smallNumber, out bigNumber);
            Console.WriteLine("兩整數之間所有的質數如下:");

            //根據整數的範圍,依據測試每個數是否為質數
            for (int i = smallNumber; i <= bigNumber; i++)
            {
                //呼叫測試質數的函數
                primeNumber = isPrimeNumber(i);

                //如果是質數則印出,加總質數的個數
                if (primeNumber == true)
                {
                    counter++;
                    //Console.WriteLine(i.ToString());
                }
            }
            //印出質數個數
            Console.WriteLine("總共有幾個質數:" + counter.ToString());

        }//end of findPrimeNumbersBetweenTwoIntgers
        //定義 method getInterger() //回傳一個整數
        static int getInterger()
        {
            int anInterger;
            Console.WriteLine("請輸入第一個整數:");
            while (!int.TryParse(Console.ReadLine(), out anInterger)) //當使用者沒輸入整數時再詢問一次
            {
                Console.WriteLine("請輸入整數:");
            }
            return anInterger;
        }

        //定義 method inputTwoIntegers(),成功讀取使用者輸入的兩個整數,第一個數 <= 第二個數
        static void inputTwoIntegers(out int small, out int big)
        {
            int temp; //宣告變數儲存兩數互換時的某一數
            //讀取兩個整數
            small = getInterger(); //呼叫Method
            big = getInterger();

            //確定small為較小的數,big為較大的數

            //兩數互換
            if (small > big)
            {
                //呼叫兩數互換的method
                exchange(ref small,ref big);
            }
        }//end of inputTwoIntegers

        //兩個整數互換
        static void exchange(ref int small,ref int big)
        {
            int temp;
            temp = small; //將比較大的數存在temp
            small = big; //將真正比較小的數存在small
            big = temp; //將真正比較大的數存在big
        }

        //定義 method isPrimeNumber(),判斷某數是否為質數
        static bool isPrimeNumber(int testNumber)
        {
            bool primeNumber = true; //Flag:標示某數是否為質數,初始值設定為真
            int i;
            if (testNumber < 2) //最小的質數為2
            {
                primeNumber = false;
            }
            for (i = 2; i < (int)Math.Sqrt(testNumber) && primeNumber; i++)
            {
                if (testNumber % i == 0) //如果測試值i整除,表示不是質數
                {
                    primeNumber = false; //將質數的標示改為否
                }
            }

            return primeNumber;
        }//end of isPrimeNumber()
    }
 }
