using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/9/24
//Autor:A108222040
//Objective:資料型態轉換練習
namespace averageConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputdata;
            int first;
            int second;
            int third;
            float averageScore;

            //使用者輸入第一筆成績
            Console.WriteLine("請輸入第一本成績:");

            //inputdata = Console.ReadLine();
            //first = int.Parse(inputdata);

            //讀入使用者資料,並轉成整數型態
            first = int.Parse(Console.ReadLine());

            //使用者輸入第二筆成績
            Console.WriteLine("請輸入第二本成績:");

            //inputdata = Console.ReadLine();
            //second = int.Parse(inputdata);

            //讀入使用者資料,並轉成整數型態
            second = int.Parse(Console.ReadLine());

            //使用者輸入第三筆成績
            Console.WriteLine("請輸入第三本成績:");

            //inputdata = Console.ReadLine();
            //third = int.Parse(inputdata);

            //讀入使用者資料,並轉成整數型態
            third = int.Parse(Console.ReadLine());

            //計算平均
            averageScore = (float)(first + second + third) / 3;

            //輸出結果
            Console.WriteLine(averageScore.ToString("n1"));

            //判斷成績是否及格,及格會用訊息恭喜
            if (averageScore>=60)
            {
                Console.WriteLine("恭喜你及格了");
            }
            //暫停
            Console.ReadLine();
        }
    }
}
