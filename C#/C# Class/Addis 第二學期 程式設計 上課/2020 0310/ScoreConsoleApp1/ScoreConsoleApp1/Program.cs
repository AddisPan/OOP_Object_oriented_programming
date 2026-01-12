using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScoreConsoleApp1
{
    class Program
    {
        //常數宣告
        const int SIZE = 12;
        const int HIGH = 100;
        const int LOW = 0;
        const int MAX = 80;//每班人數上限80人

        static void Main(string[] args)
        {
            //將成績資料儲存到檔案裡
            //呼叫存檔的Method
            WriteScoreDataToFile();
            //讀取檔案將資料顯示在螢幕上

            //宣告一個整數的陣列
            int[] studentScore = new int[MAX];
            //呼叫讀檔的Method           
            int numberOfStudents = ReadScoreDataFromFile(studentScore);
            //呼叫Method,找出全班的平均分數
            double highestScore = computehighestScore(studentScore, numberOfStudents);
            Console.WriteLine("全班人數 :" + numberOfStudents.ToString() + "全班最高分 :" + highestScore.ToString());
            //呼叫Method,找出全班的平均分數
            double lowestScore = computelowestScore(studentScore, numberOfStudents);
            Console.WriteLine("全班人數 :" + numberOfStudents.ToString() + "全班最低分 :" + lowestScore.ToString());
            //呼叫Method,找出全班的平均分數
            double averageScore = computeaverageScore(studentScore, numberOfStudents);
            Console.WriteLine("全班人數 :" + numberOfStudents.ToString() + "全班平均 :" + averageScore.ToString());
            Console.ReadLine();

            Console.WriteLine("離開程式按a");
            while (Console.ReadLine() == "a")
            {
                Console.WriteLine("結束本程式");
            }
        }
        static void WriteScoreDataToFile()
        {
            try
            {
                //Define a write file thing
                StreamWriter outputfile;
                //把寫檔的物件跟實際的檔案連結
                outputfile = File.CreateText("Score.txt");
                int score;
                
                //讀取使用者的資料,經過驗證後再存入檔案
                for (int i = 0;i < SIZE; i++)
                {
                    //呼叫Method讓使用者輸入正確資料
                    score = readUserInputData(HIGH,LOW); 
                    outputfile.WriteLine(score);
                }
                outputfile.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int ReadScoreDataFromFile(int [] studentScore)
        {
            //計算學生人數
            int counter = 0;
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Score.txt");
                //計算學生人數               
                int score;
      
                //讀取檔案的所有資料並一一列在螢幕上
                while (! inputFile.EndOfStream) //當資料沒有讀取到檔尾就要進入迴圈
                {
                    score = int.Parse(inputFile.ReadLine());
                    //顯示在螢幕上
                    Console.WriteLine(score);
                    //將資料儲存到陣列,再將學生人數加一
                    studentScore[counter++] = score;
                }
                //關閉檔案
                inputFile.Close();
                //停住螢幕
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return counter;
        }

        static int readUserInputData(int high, int low)
        {
            int score = 0;
            bool OK = false;

            while (!OK)
            {
                Console.WriteLine("請輸入資料 " + high.ToString() + "-" + low.ToString());
                OK = int.TryParse(Console.ReadLine(), out score);
                //檢查數值是否在有效的範圍值內
                if (score < 0 || score > 100)
                {
                    OK = false;
                }
            }
            return score;
        }

        static double computeaverageScore(int [] studentScore,int numberOfStudents)
        {
            double averageScore = 0;
            int total = 0;
            //將全班總分利用迴圈加總起來
            for (int i = 0 ; i < numberOfStudents ; i++ )
            {
                total = total + studentScore[i]; //total += studentScore[i]
            }
            averageScore = (double)total / numberOfStudents;
            return averageScore;
        }

        static double computehighestScore(int [] studentScore,int numberOfStudents)
        {
            double highestScore = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (studentScore[i] > highestScore)
                {
                    highestScore = studentScore[i];
                }
            }
            return highestScore;
        }

        static double computelowestScore(int[] studentScore, int numberOfStudents)
        {
            double lowestScore = 100;
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (studentScore[i] < lowestScore)
                {
                    lowestScore = studentScore[i];
                }
            }
            return lowestScore;
        }
    }
}
