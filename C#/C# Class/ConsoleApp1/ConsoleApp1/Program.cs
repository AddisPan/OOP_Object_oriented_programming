using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name1, name2, name3; //學生名字
            int grade1, grade2, grade3, grade4, grade5, grade6; //範圍0~100
            double weight1, weight2, weight3;
            double  LowestGrade = 68.55;

            Console.WriteLine("請輸入第一個同學的姓名:");
            name1 = Console.ReadLine();

            Console.WriteLine("請輸入第一個同學的第一個成績:");
            grade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入第一個同學的第二個成績:");
            grade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("最低入取加權分數:" + LowestGrade);
            weight1 = (grade1 * 0.4 + grade2 * 0.6);
            Console.Write(name1 + "的兩科加權:" + weight1.ToString("n2"));

            if (weight1 > LowestGrade)
            {
                Console.WriteLine(name1 + "恭喜妳通過本次考試,取得智慧網管證照!");
            }
            else
            {
                Console.WriteLine(name1 + "很遺憾妳未能通過本次考試");
                Console.WriteLine(name1 + "不必氣餒!下次再來!");
            }
            Console.ReadKey();

            Console.WriteLine("請輸入第二個同學的姓名:");
            name2 = Console.ReadLine();

            Console.WriteLine("請輸入第二個同學的第一個成績:");
            grade3 = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入第二個同學的第二個成績:");
            grade4 = int.Parse(Console.ReadLine());

            Console.WriteLine("最低入取加權分數:" + LowestGrade);
            weight2 = (byte)(grade3 * 0.4 + grade4 * 0.6);
            Console.WriteLine(name2 + "的加權分數:" + weight2.ToString("n2"));

            if (weight2 > LowestGrade)
            {
                Console.WriteLine(name2 + "恭喜妳通過本次考試,取得智慧網管證照");
            }
            else
            {
                Console.WriteLine(name2 + "很遺憾妳未能通過本次考試");
                Console.WriteLine(name2 + "不必氣餒!下次再來!");
            }

            Console.ReadKey();

            Console.WriteLine("請輸入第三個同學的姓名:");
            name3 = Console.ReadLine();

            Console.WriteLine("請輸入第三個同學的第一個成績:");
            grade5 = int.Parse(Console.ReadLine());

            Console.WriteLine("請輸入第三個同學的第二個成績:");
            grade6 = int.Parse(Console.ReadLine());

            Console.WriteLine("最低入取加權分數:" + LowestGrade);
            weight3 = (byte)(grade5 * 0.4 + grade6 * 0.6);
            Console.WriteLine(name3 + "的加權分數:" + weight3.ToString("n2") + "\n");

            if (weight3 > LowestGrade)
            {
                Console.WriteLine(name3 + "恭喜妳通過本次考試,取得智慧網管證照");
            }
            else
            {
                Console.WriteLine(name3 + "很遺憾妳未能通過本次考試");
                Console.WriteLine(name3 + "不必氣餒!下次再來!");
            }
            Console.ReadKey();
        }
    }
}
