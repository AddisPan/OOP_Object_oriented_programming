using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/11/26
//Author:A108222040
//Objective:Method Pratice
namespace ManuPraticeConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlocity; //重力加速度
            double KE; //動能
            double r; //根
            double BMI; //BMI
            double PrimeNumber; //質數
            double AmstrongNumber; //阿姆斯壯數
            int option;
            //宣告變數儲存使用者是否繼續使用系統的回答            
            Console.WriteLine("繼續使用本系統請按y");           
            while (Console.ReadLine() == "y")
            {
                //呼叫功能選項單,回傳使用者選擇的功能代號
                option = menu();
                switch (option)
                {
                    case 1: //呼叫計算重力加速度的Method
                        vlocity = fallingVlocity();
                        Console.WriteLine("這個是重力加速度" + vlocity.ToString());
                        break;
                    case 2: //呼叫計算動能的Method
                        KE = kineticEnergy();
                        Console.WriteLine("這個是動能" + KE.ToString());
                
                        break;
                    case 3: //呼叫一元二次方程式最佳解的Method
                        r = quadraticEquation();
                        Console.WriteLine("最佳解" + r.ToString());
                        break;
                    case 4: //呼叫BMI的Method
                        BMI = CalculateBMI();
                        Console.WriteLine("BMI是" + BMI.ToString());
                        break;
                    case 5: //呼叫判斷質數的Method
                         PrimeNumber = CalculatePrimeNumber();
                        Console.WriteLine("這個數是" + PrimeNumber.ToString());
                        break;
                    case 6: //呼叫判斷阿姆斯壯數的Method
                        AmstrongNumber = CalculateAmstrongNumber();
                        Console.WriteLine("這個數是" + AmstrongNumber.ToString());
                        break;
                }
                 
                Console.WriteLine("你的選項是" + option.ToString());                
                //在迴圈終止之前,要有更新進入迴圈條件的陳述
                Console.WriteLine("繼續使用本系統請按y");
            }
        }//end of Main()

        static double CalculateAmstrongNumber()
        {
            double B;
            double AmstrongNumber = 0;

            Console.WriteLine("請輸入數字");
            while (double.TryParse(Console.ReadLine(), out B) == false)
            {
                Console.WriteLine("請輸入數字");
            }

            AmstrongNumber = computeAmstrongNumber(B);
            return AmstrongNumber;
        }

        static double computeAmstrongNumber()
        {
            bool AmstrongNumber = true; //Flag:標示某數是否為阿姆斯壯數,初始值設定為真
            int i,remainder, sum = 0;

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

        }

        static double CalculatePrimeNumber()
        {
            double A;
            double PrimeNumber = 0;

            Console.WriteLine("請輸入數字");
            while (double.TryParse(Console.ReadLine(), out A) == false)
            {
                Console.WriteLine("請輸入數字");
            }

            PrimeNumber = computePrimeNumber(A);
            return PrimeNumber;
        }

        static double computePrimeNumber(double number)
        {
            double PrimeNumber;
            int remainder, sum = 0;
            for (int i = number ; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (sum == number)
            {
                Console.WriteLine("這是質數");
            } 
            else
            {
                Console.WriteLine("這不是質數");
            }           
        }

        static double CalculateBMI()
        {
            double height;
            double weight;
            double BMI = 0;

            Console.WriteLine("請輸入身高");
            while (double.TryParse(Console.ReadLine(), out height) == false)
            {
                Console.WriteLine("請輸入身高");
            }

            Console.WriteLine("請輸入體重");
            while (double.TryParse(Console.ReadLine(), out weight) == false)
            {
                Console.WriteLine("請輸入體重");
            }

            BMI = computeCalculateBMI(height, weight);
            return BMI;
        }

        static double computeCalculateBMI(double height,double weight)
        {
            double BMI;
            return BMI = weight / (height / 100 * height / 100);
        }

        static double quadraticEquation()
        {
            double a;
            double b;
            double c;
            double r = 0;

            Console.WriteLine("請輸入a");
            while (double.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("請輸入a");
            }

            Console.WriteLine("請輸入b");
            while (double.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.WriteLine("請輸入b");
            }

            Console.WriteLine("請輸入c");
            while (double.TryParse(Console.ReadLine(), out c) == false)
            {
                Console.WriteLine("請輸入c");
            }

            r = computequadraticEquation(a, b, c);
            return r;
        }

        static double computequadraticEquation(double a,double b,double c)
        {
            return (Math.Sqrt(b * b - 4 * a * c) - b) / (2 * a );
        }

        //定義KE的Method
        static double kineticEnergy()
        {
            double KE;
            double m = 0;
            double v = 0;
            Console.WriteLine("請輸入質量");
            while (double.TryParse(Console.ReadLine(), out m) == false)
            {
                Console.WriteLine("請輸入質量");
            }
            
            Console.WriteLine("請輸入速度");
            while (double.TryParse(Console.ReadLine(), out v) == false)
            {
                Console.WriteLine("請輸入速度");
            }

            KE = computeKE(m,v);
            return KE;
        }

        static double computeKE(double mass,double velocity)
        {
            double KE;
            return KE =  mass * velocity * velocity / 2;
        }

        //定義vlocity的Method
        static double fallingVlocity()
        {
            double vlocity = 0;
            double time;
            Console.WriteLine("請輸入一個時間");
            while (double.TryParse(Console.ReadLine(),out time) == false)
            {
                Console.WriteLine("請輸入一個時間");
            }
            //呼叫計算重力加速度的Method
            vlocity = computeFallingVlocity(time);
            return vlocity;
        }

        //定義computeFallingVlocity
        static double computeFallingVlocity(double time)
        {
            return 9.8 * time;
        }

        //定義Menu的Method,回傳int
        static int menu()
        {
            int option = 1;
            const int HIGH = 4;
            const int LOW = 1;

            //將使用者輸入的資料轉成整數型態            
            do
            {
                //列出功能選項
                Console.WriteLine("請選擇功能");
                Console.WriteLine("1. 計算重力加速度");
                Console.WriteLine("2. 計算動能");
                Console.WriteLine("3. 一元二次方程式最佳解");
                Console.WriteLine("4. 計算BMI");
                Console.WriteLine("5. 判斷是否為質數");
                Console.WriteLine("6. 判斷是否為阿姆斯壯數");
            } while (int.TryParse(Console.ReadLine(), out option) == false  || option < LOW || option > HIGH);
            //在Method結束前利用保留字return,將資料回傳
            return option;
        }
    }
}
