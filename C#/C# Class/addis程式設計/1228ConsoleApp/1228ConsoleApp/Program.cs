using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1228ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用迴圈讓使用者可以多次使用本程式
            Console.WriteLine("輸入a繼續本程式");

            while (Console.ReadLine() == "a")
            {
                //呼叫找兩個整數間的Method
                findPrimeNumbersBetweenTwoIntgers();

                //再次詢問使用者是否繼續使用本程式
                Console.WriteLine("輸入a繼續本程式");
            } //end of while
        } //end of Main

        //定義MethodfindPrimeNumbersBetweenTwoIntgers()
        static void findPrimeNumbersBetweenTwoIntgers()
        {
            int Number1;
            int Number2;
            bool PrimeNumber = true;
            int counter = 0;

            inputTwoInterger(out Number1,out Number2);

            Console.WriteLine("兩個整數之間的質數如下");

            for (int i = Number1 ; i <= Number2 ; i ++)
            {
                PrimeNumber = isPrimeNumber(i);

                if (PrimeNumber == true)
                {
                    counter ++;
                }
            }

            Console.WriteLine("總共有幾個質數" + counter.ToString());
        }

        static void inputTwoInterger(out int Number1, out int Number2)
        {
            int temp;

            Console.WriteLine("請輸入第一個整數");
            while (int.TryParse(Console.ReadLine(),out Number1) == false)
            {
                Console.WriteLine("請輸入整數");
            }
            Console.WriteLine("第一個整數是" + Number1.ToString());

            Console.WriteLine("請輸入第二個整數");
            while (int.TryParse(Console.ReadLine(),out Number2) == false)
            {
                Console.WriteLine("請輸入整數");
            }
            Console.WriteLine("第二個整數是" + Number2.ToString());

            if (Number1 > Number2)
            {
                temp = Number1;
                Number1 = Number2;
                Number1 = temp;
            }
        }

        static bool isPrimeNumber(int testNumber)
        {
            bool PrimeNumber = true;

            int i;

            if (testNumber < 2)
            {
                PrimeNumber = false;
            }

            for (i = 2 ; i < (int)Math.Sqrt(testNumber) && PrimeNumber == true ; i ++)
            {
                if (testNumber % i  == 0)
                {
                    PrimeNumber = false;
                }
            }
            return PrimeNumber;
        }
    }
}
