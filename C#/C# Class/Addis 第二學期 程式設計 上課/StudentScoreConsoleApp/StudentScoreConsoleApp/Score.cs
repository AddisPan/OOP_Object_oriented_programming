using System;

namespace StudentScoreConsoleApp
{
    class Score
    {
        const int ROWS = 42;
        const int COLS = 8;

        static void Main(string[] args)
        {
            int[,] studentScores = new int[ROWS,COLS]; //宣告一個整數的二維陣列 ROW * COLUMNS (42*4)
            //將資料放入二維陣列
            inputData(studentScores);

            //讀取二維陣列的資料
            display2DArray(studentScores);

            //算出每一位同學的平均成績
            double[] studentAverage = new double[ROWS]; //宣告一個一維陣列儲存每位同學的成績
            computeStudentAverage(studentScores,studentAverage);
            //顯示每位同學的平均成績
            Console.WriteLine("現在我下面要印的是每位同學同學的平均");
            displayArray(studentAverage);

            //計算每個科目的平均成績
            Console.WriteLine("現在要印的是各科目的平均成績");
            double[] subjectAverage = new double[COLS]; //宣告一個一維陣列儲存每科的平均成績
            computeSubjectAverage(studentScores,subjectAverage);
            displayArray(subjectAverage);

            Console.ReadKey();
        }

        static void inputData(int[,] studentScores)
        {
            Random rand = new Random();
            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLS; column++)
                {
                    //隨機給定第Row個學生第Column科目的成績
                    studentScores[row, column] = rand.Next(0,100);
                }
            }
        }

        static void display2DArray(int [,] studentScores)
        {
            for (int student = 0 ; student < ROWS ; student ++)
            {
                //列印學生的所有單科成績
                for (int subject = 0 ; subject < COLS ; subject++)
                {
                    Console.Write(studentScores[student,subject] + "\t");
                }
                //換行列印下一位同學的成績
                Console.WriteLine();
            }
        }

        static void computeStudentAverage(int [,] studentScores , double [] studentAverage)
        {
            int total = 0;
            for (int student = 0 ; student < ROWS ; student ++)
            {
                total = 0; //歸0,清除前一位同學的成績總和
                //計算每一位同學的平均成績
                for (int subject = 0 ; subject < COLS ; subject ++ )
                {
                    total = total + studentScores[student,subject];
                }
                //除以學生的人數
                studentAverage[student] = (double)total / COLS;
            }
        }

        static void computeSubjectAverage(int [,] studentScores,double [] subjectAverage)
        {
            double total = 0;
            //加總該科目的成績
            for (int subject = 0 ; subject < COLS ; subject ++ )
            {
                //上一科目清空
                total = 0;
                for (int student = 0 ; student < ROWS ; student ++ )
                {
                    total += studentScores[student,subject];
                }
                subjectAverage[subject] = total / ROWS;
            }
        }

        static void displayArray (double [] array)
        {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + "\n");
                }
                Console.WriteLine();
        }
    }
}
