using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//date:2019/11/26
//Author:a108222016
//Objective:Method Pratice
namespace Methodclication
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI;
            double prinenumber;
            double armstrongNumber;
            double vlocity;//重力加速度
            double KE;//動能
            double r;//根
            int option;
            //宣告變數儲存使用者是否繼續使用系統的回答
            Console.WriteLine("繼續使用此系統請按y");
            while (Console.ReadLine()=="y")
            {
                //呼叫功能選項單，回傳使用者選擇的功能
                option = menu();
                switch (option)
                {
                    case 1:
                        BMI = methodBMI();
                        Console.WriteLine("BMI為"+BMI.ToString());
                        break;

                    case 2:
                        prinenumber = methodPrinenumber();                      
                        break;

                    case 3:
                        armstrongNumber = methodArmStrongNumber();
                        break;


                    case 4: //呼叫計算重力加速度的Method
                        vlocity = fallingVlocity();
                        Console.WriteLine("重力加速度為"+vlocity.ToString());
                        break;

                    case 5: //呼叫計算動能的Method
                        KE = kineticEnergy();
                        Console.WriteLine("動能為" + KE.ToString());
                        break;

                    case 6: //呼叫一元二次方程式最佳解的Method
                        r = quadraticEquation();
                        if (r>0)
                        {
                            Console.WriteLine("r為"+r.ToString()+"有兩個實數解");
                        }
                        else if (r==0)
                        {
                            Console.WriteLine("r為"+r.ToString()+"有一個解");
                        }
                        else if (r<0)
                        {
                            Console.WriteLine("r為"+r.ToString()+"無解");
                        }
                        
                        
                        break;                        
                }
                
                Console.WriteLine("你的選項是" + option.ToString());
                //在迴圈終止之前 要有更新迴圈條件的陳述
                Console.WriteLine("繼續使用此系統請按y");                                       
            }
        }//end of Main()
        static double methodBMI()
        {
            double BMI=0 ;
            double weight;
            double height;
            Console.WriteLine("請輸入你的體重");
            while (double.TryParse(Console.ReadLine(),out weight)==false)
            {
                Console.WriteLine("請輸入你的體重");
            }
            Console.WriteLine("請輸入你的身高(公尺)");
            while (double.TryParse(Console.ReadLine(),out height)==false)
            {
                Console.WriteLine("請輸入你的身高(公尺)");
            }
            BMI = computeBMI(weight,height);
            return BMI;
        }
        static double computeBMI(double weight,double height)
        {
            return weight / (height * height);
        }

        static double methodPrinenumber()
        {
            int textnumber;
            bool isPrine;

            Console.WriteLine("請輸入要判斷的整數");
            if (int.TryParse(Console.ReadLine(), out textnumber))
            {
                //呼叫method判斷是否為質數
                isPrine = FindPrineNumber(textnumber);
                if (isPrine == true)
                {
                    Console.WriteLine(textnumber.ToString() + "是質數");
                }
                else
                {
                    Console.WriteLine("不是質數");
                }
            }
            return textnumber;
        }

        static bool FindPrineNumber(int number)
        {
            bool isPrine = true;
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if ((number % i) == 0)//number可被1跟本身整除，餘數為零，i是因數
                {
                    counter++;
                }
            }//end off for
            if (counter != 2)
            {
                isPrine = false;
            }

            return isPrine;

        }

        static int methodArmStrongNumber()
        {
            int number;
            int armstrongnumber;
            Console.WriteLine("請輸入一個三位數");
            if (int.TryParse(Console.ReadLine(), out number)==false)
            {
                Console.WriteLine("請輸入一個三位數");
            }
            armstrongnumber = computeArmStrongNumber(number);
            return number;
        }

        static int computeArmStrongNumber(int number)
        {
            int digitOne, digitTen, digitHundred, temp;
            digitOne = number % 10;
            digitTen = (number % 100) / 10;
            digitHundred = number / 100;
            temp = digitOne * digitOne * digitOne + digitTen * digitTen * digitTen + digitHundred * digitHundred * digitHundred;
            if (temp==number)
            {
                Console.WriteLine("這是阿姆斯壯數");
            }
            else
            {
                Console.WriteLine("這不是阿姆斯壯數");
            }
            return number;
        }


        //定義vlocity的Method
        static double fallingVlocity()
        {
            double vlocity = 0;
            double time;
            Console.WriteLine("請輸入一個時間");
            while(double.TryParse(Console.ReadLine(),out time) == false)
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

        //定義kineticEnergy
        static double kineticEnergy()
        {
            double KE=0;
            double mass;//質量
            double v;
            Console.WriteLine("請輸入質量");
            while (double.TryParse(Console.ReadLine(),out mass)==false)
            {
                Console.WriteLine("請輸入質量");
            }
            Console.WriteLine("請輸入平均速度");
            while(double.TryParse(Console.ReadLine(),out v) == false)
            {
                Console.WriteLine("請輸入平均速度");
            }
            KE = computeKE(mass,v);
            

            return KE;
        }
        static double computeKE(double mass, double v)
        {
            return (mass * v * v) / 2;
        }

        //
        static double quadraticEquation()
        {
            double r = 0;
            double a,b,c;//x平方的係數，x的係數，常數
            Console.WriteLine("請輸入x平方的係數");
            while (double.TryParse(Console.ReadLine(), out a)==false )
            {
                Console.WriteLine("請輸入x平方的係數");
            }
            Console.WriteLine("請輸入x的係數");
            while (double.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.WriteLine("請輸入x的係數");
            }
            Console.WriteLine("請輸入常數");
            while (double.TryParse(Console.ReadLine(), out c) == false)
            {
                Console.WriteLine("請輸入常數");
            }
            r = compute(a,b,c);
            
            return r;
        }
        static double compute(double a,double b,double c)
        {
            return (Math.Sqrt(b * b - 4 * a * c) - b) / (2*a);
        }
        

        //定義Menu的Method,回傳int
        static int menu()
        {
            //bool dateOk;
            //string answer;
            int option=1;
            const int HIGH = 6;
            const int LOW = 1;

            
            //answer = Console.ReadLine();
            //將使用者輸入的資料轉乘整數型態
            //dateOk = int.TryParse(answer, out option);//如果使用者輸入不是數字dataok為false，沒有回傳成功
            //將使用者輸入的資料轉乘整數型態
            do
            {
                //列出功能選項
                Console.WriteLine("請選擇功能");
                Console.WriteLine("1.計算BMI");
                Console.WriteLine("2.判斷是否為質數");
                Console.WriteLine("3.判斷是否為阿姆斯壯數");
                Console.WriteLine("4.計算重力加速度");
                Console.WriteLine("5.計算動能");
                Console.WriteLine("6.計算一元二次方程式");
                //answer = Console.ReadLine();
            } while ((int.TryParse(Console.ReadLine(), out option) == false) || option < LOW || option > HIGH);
             
            //在Method結束前利用保留自return,將資料回傳
            return option;          
        }

    }
}
