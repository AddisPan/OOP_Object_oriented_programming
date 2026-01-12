using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/9/28
//Autor:A108222040 潘凌徵
//Objective:成績等第計算
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;

            //使用者輸入成績
            Console.WriteLine("輸入成績!");

            //讀入使用者資料,並轉換成整數型態
            first = int.Parse(Console.ReadLine());

            //判斷平均成績為哪個等第,(90以下為B,80以下為C,70以下為D,60以下為F,其他為A)用訊息通知
            if (first < 60)
            {
                Console.WriteLine("等第為F");
            }
            else if (first < 70)
            {
                Console.WriteLine("等第為D");
            }
            else if (first < 80)
            {
                Console.WriteLine("等第為C");
            }
            else if (first < 90)
            {
                Console.WriteLine("等第為B");
            }
            else if (first < 100)
            {
                Console.WriteLine("等第為A!");
            }

            //暫停
            Console.ReadLine();
        }
    }
}
