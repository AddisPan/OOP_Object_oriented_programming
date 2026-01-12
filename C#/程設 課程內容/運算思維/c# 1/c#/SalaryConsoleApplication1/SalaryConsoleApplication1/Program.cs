using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/10/15
//autor:A108222040_潘凌徵
//Objective:巢狀條件是練習
namespace SalaryConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //宣告變數.儲存使用者輸入
            int salary; //使用者月薪
            int YearOnJob; //工作年資

            try
            {
                //讀取使用者輸入薪水
                Console.WriteLine("請輸入你的薪水!");
                salary = int.Parse(Console.ReadLine());
                Console.WriteLine("請輸入年資!");
                YearOnJob = int.Parse(Console.ReadLine());

                //判斷使用者是否符合申請貸款的條件:1.salary >= 400000
                if (salary >= 40000)
                {
                    if (YearOnJob >= 2) //條件二:年資大於等於二
                    {
                        Console.WriteLine("恭喜妳達到條件!");
                    }
                    else
                    {
                        Console.WriteLine("不符合最低年資之條件!");
                    }
                } //end of if (salary >= 40000)
                else //salary < 400000
                {
                    Console.WriteLine("不合薪水之條件!");
                }
            } //end of try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } //end of catch

            //暫停螢幕
            Console.ReadKey();
        }
    }
}
