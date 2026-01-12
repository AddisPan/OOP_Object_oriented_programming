using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherWindowsFormsApp
{
    public partial class temperature : Form
    {
        public temperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            int month;
            bool yearOk;
            bool monthOk;

            //檢查年份及月份輸入的資料,格式是否正確,合法
            //呼叫method checkYear() 檢查輸入的年份是否合法，如果合法回傳false
            yearOk = checkYear();
            //呼叫method checkMonth 輸入的月份是否為1~12數字  如果的話回傳true 不適回傳false
            monthOk = checkMonth();

            if (yearOk == true)//輸入年份資料合法
            {
                if (monthOk == true) //年份及月份都合法
                {//呼叫method showData(),將該年該月份的資料，在表單的listbox顯示出來
                    showData();
                }//end of if (monthOk == true)
                else //月份輸入不正確
                {
                    MessageBox.Show("月份輸入不正確");
                    inputMonthMaskedTextBox.Text = "";//將不合法的月份清除
                    inputMonthMaskedTextBox.Focus();//將游標移到月份輸入處
                }
            }//end of if (yearOk == true)
            else//年份輸入不正確
            {
                MessageBox.Show("年份輸入不正確");
                inputYearMaskedTextBox.Text = "";//將不合法的年份清除
                inputYearMaskedTextBox.Focus();//將游標移到年分輸入處
            }
        }
        //defind showData()
        //定義showData()根據使用者輸入的年份及月分,將正確的資料個數及溫度範圍在listbox中顯示
        private void showData()
        {
            int totalDays;
            int lowBound = 0; //溫度的下限
            int highBound = 0; //溫度的上限

            //呼叫Method查該月份有幾天，回傳該月份的天數
            totalDays = checkDays();

            //呼叫Method查出該月最高溫跟最低溫是多少，呼叫[method時要給兩個參考的變數存放最高溫及最低溫
            checkTemperature(ref lowBound, ref highBound);

            //呼叫Method將相關的資料在listbox上顯示，呼叫method時要給三個變數，天數、最高溫、最低溫
            displayData(totalDays,lowBound,highBound);
        }//end of showData()

        //定義displayData()，呼叫Method將相關的資料在listbox上顯示，呼叫method時要給三個變數，天數、最高溫、最低溫
        private void displayData(int totalDays,int lowBound,int highBound)
        {
            Random rand = new Random();
            for (int i = 0 ; i < totalDays ; i ++ )//利用迴圈產生totalDays筆資料，
            {//交隨機亂數產生的資料存放到listbox中，產生的數值介於lowbound-1 ~ highbound+1
                TemperatureListBox.Items.Add(rand.Next(lowBound,highBound + 1));
                
            }
        }

        //定義checkTemperature()，沒有回傳值，有兩個參考的整數變數，分別代表最低溫和最高溫
        private void checkTemperature(ref int low, ref int high)
        {
            int month = int.Parse(inputMonthMaskedTextBox.Text);
            //利用一維陣列儲存每月最低溫最高溫
            int[] temperature = new int[24] {1,18,2,19,3,10,4,24,5,25,6,26,7,27,8,28,9,29,10,28,11,26,12,24};
            
            //查核一維陣列找出該月的最高溫
            high = temperature[month * 2 - 1];
            //查核一維陣列找出該月的最低溫
            low = temperature [month * 2 - 2];
                
        }

        //定義checkDays()
        private int checkDays()//回傳該年該月份的日數
        {
            int days = 0;
            bool leapYear;
            int month = int.Parse(inputMonthMaskedTextBox.Text);
            //利用一為陣列儲存每月日數
            int[] daysOfMonth = new int[12] {31,28,31,30,31,30,31,31,30,31,30,31};

            //查表即可知道日數是多少
            days = daysOfMonth[month - 1];

            //檢查是否為閏年,如果是閏年的話,2月的日期應該是29
            //呼叫method isLeapYear(),呼叫的時候要給一個整數的變數，表示查詢的年份，回傳布林值true的話表示閏年false的話表示不是閏年
            leapYear = isLeapYear(int.Parse(inputYearMaskedTextBox.Text));

            //如果是閏年的話,2月的日期應該是29天
            if (leapYear == true && month == 2)
            {
                days = 29;
            }
            return days;
        }

        //定義isLeapYear()，回傳該年是否為閏年Method有一個整數參數即為查核是否為閏年的年份，回傳true該年為閏年 false則不為閏年
        private bool isLeapYear(int year)
        {
            bool leapYear = true;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)//一百年不潤
                {
                    if (year % 400 == 0)//四百年潤
                    {
                        leapYear = true;//是閏年
                    }
                    else
                    {
                        leapYear = false;//不是閏年
                    }
                }
                else 
                {
                    leapYear = true;//被4除盡，但是不被100除盡
                }
            }
            else//不被4除盡
            {
                leapYear = false;
            }
            return leapYear;
        }

        //define checkYear(),method回傳一個布林值，true表示合法false表示不合法
        private bool checkYear()
        {
            bool dataOk = false;
            int validYear;//有效的年份為2000~2018

            if (int.TryParse(inputYearMaskedTextBox.Text, out validYear) == true &&
                validYear >= 2000 && validYear <= 2018)
            {
                dataOk = true;
            }
            return dataOk;
        }// end of private bool checkYear()

        //define checkMonth()
        private bool checkMonth()
        {
            bool dataOk = false;
            int validMonth;//有效的月份為1~12

            if (int.TryParse(inputMonthMaskedTextBox.Text, out validMonth) == true &&
                validMonth >= 1 && validMonth <= 12)
            {
                dataOk = true;
            }
            return dataOk;
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int[] temp = new int[31];//每月的溫度資料
            int length;
            int[] high = new int [31];//該月高溫的日期
            int highest;
            int counter = 0;

            //呼叫Method將listbox資料存放陣列中，回傳陣列實際使用的長度，
            length = readData(temp);

            //呼叫Method找出最高溫度及最高溫日期，回傳最高溫度 呼叫Method時要給int陣列，陣列的使用長度，int陣列，陣列的使用長度參考int形式的值
            highest = findHigh(temp,length,high,ref counter);

            //呼叫Method顯示最高溫度及最高溫日期
            displayHighestemperature(highest,high,counter);
        }
        //定義displayHighestTemperature()，呼叫時要給一個整數，一個整數陣列，一個整數，共三個參數
        private void displayHighestemperature(int highest,int [] high,int counter)
        {
            theHighestTemperatureLabel.Text = highest.ToString();
            theHighestTemperatureLabel.Text += "日期為 : ";

            for (int i = 0 ; i < counter ; i ++)
            {
                theHighestTemperatureLabel.Text += high[i].ToString();
                theHighestTemperatureLabel.Text += ",";
            }
        }
        //定義findHigh()，呼叫Method找出最高溫度及最高溫日期
        //回傳最高溫度 呼叫Method時要給int陣列，int 陣列的使用長度，int陣列，參考int形式陣列的使用長度
        private int findHigh(int[] temp,int length,int [] high,ref int counter)
        {
            int highest = -1000;
            //呼叫Method找到最高溫度
            highest = findHighesttemperature(temp, length);
       
            //呼叫Method找到和最高溫度相同的日期
            findthesame(highest, high,temp,length,ref counter);
            return highest;
        }
        //定義method findthesame()，呼叫method時共有五個參數
        //整數(最高溫)，整數陣列(存放最高溫的日期)，整數陣列(存放當月每日溫度)，整數(當月存放溫度的日數)，參數整數(最高溫度的日數)
        private int findthesame(int compare,int [] highTemperature, int [] temp,int length,ref int counter)
        {//利用迴圈將每日的溫度拿出來與最高溫比對
            for (int i = 0 ; i < length ; i ++ )
            {
                if (temp[i] == compare) //找到最高溫日期
                {
                    highTemperature[counter] = i+1; //將最高溫的日期存入陣列中，+1的用意為從1開始，原本為序號0
                    counter++; //將最高溫陣列的索引直向後移
                }
            }
            return counter;
        }
        //定義findHighestTemperature()，回傳最高溫度呼叫Method時要給一個整數的陣列和整數
        private int findHighesttemperature(int [] temp,int length)
        {
            int highest = temp[0];//將陣列中的第一個元素設為最高溫
            for (int i = 1 ; i < length ; i ++)
            {
                if (temp [i] > highest)//如果目前陣列的元素值大於最高溫
                {
                    highest = temp[i];//將最高溫度重新設定
                }
            }
            return highest;
        }

        //定義readData()，呼叫method的時候要給一個整數的陣列，回傳整數代表陣列使用的個數
        private int readData(int [] temp)
        {
            int length = TemperatureListBox.Items.Count;
            //依序將listBox的元素存放到陣列中
            for (int i = 0 ; i < TemperatureListBox.Items.Count ; i ++ )
            {
                temp[i] = int.Parse(TemperatureListBox.Items[i].ToString());
            }
            return length;
        }
    }
}
