using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testnumber;
            bool isPrime;
            Console.WriteLine("是否開始判斷質數?");

            while (Console.ReadLine() == "是")
            {
                //使用者輸入測試整數
                Console.WriteLine("請輸入要判斷的整數:");
                if (int.TryParse(Console.ReadLine(),out testnumber))
                {
                    //呼叫Method判斷是否為質數
                    isPrime = findPrimeNumber(testnumber);
                    if (isPrime == true)
                    {
                        Console.WriteLine(testnumber.ToString() + "是質數");
                    }
                    else
                    {
                        Console.WriteLine("不是質數");
                    }
                }
                Console.WriteLine("是否開始判斷質數?");
            } //end of while
            Console.ReadKey();
        }
        //定義findPrimeNumber() method
        static bool findPrimeNumber(int number)
        {
            int counter = 0; //統計這個整數總共有幾個因數
            bool isPrime = true;
            for (int i = 1;i <= number;i ++ )
            {
                if ((number % i) == 0) //number可以被i整除,餘數為零,i是因數
                {
                    counter++; //因數總數加一
                }
            } //end of for
            //如果因數總數為2就是質數,反之則否
            if (counter != 2)
            {
                isPrime = false;
            }
            return isPrime;
        }
        //定義findPrimeNumber2() method
        static bool findPrimeNumber2(int number)
        {

            bool isPrime = true;
            for (int i = 2; i < number && isPrime; i++)
            {
                if ((number % i) == 0) //number可以被1跟本身整除,所以number不是質數
                {
                    isPrime = false;

                }
            } //end of for
            return isPrime;
        }
    }
}
