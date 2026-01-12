using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    enum grade
    { 大一, 大二, 大三, 大四, 碩一, 碩二 }
    enum department
    { 資管系, 經濟系, 財金系, 企管系, 觀光系 }
    public partial class Form1 : Form
    {
        private List<member> phoneList = new List<member>();
        private List<int> score = new List<int>();
        struct member
        {
            public string ID;
            public grade grade;
            public department department;
            public int[] test;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立一個新的手機物件
            
            member mymember = new member();
            mymember.test = new int[6];
            //取得手機的資料
            getDatae(ref mymember);

            //將新的手機資料加在串列中
            phoneList.Add(mymember);

            //清除資料
            textBox1.Clear();
            //宣告ㄧ個字串放入一台手機的資訊
            string output;
            listBox1.Items.Clear();

            //顯示串列的資料
            foreach (member phone123 in phoneList)
            {
                output = phone123.ID ;
                listBox1.Items.Add(output);
            }
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void getDatae(ref member phone)
        {
            string inputData, inputCarrier;

            try
            {
                //取得使用者輸入的資料
                phone.ID = textBox1.Text;
                inputData = comboBox1.SelectedItem.ToString();

                if (inputData == "大一")
                {
                    phone.grade = grade.大一;
                }

                else if (inputData == "大二")
                {
                    phone.grade = grade.大二;
                }
                else if (inputData == "大三")
                {
                    phone.grade = grade.大三;
                }
                else if (inputData == "大四")
                {
                    phone.grade = grade.大四;
                }
                else if (inputData == "碩一")
                {
                    phone.grade = grade.碩一;
                }
                else if (inputData == "碩二")
                {
                    phone.grade = grade.碩二;
                }





                inputCarrier = comboBox2.SelectedItem.ToString();
                switch (inputCarrier)
                {
                    case "企管系":
                        phone.department = department.企管系;
                        break;
                    case "經濟系":
                        phone.department = department.經濟系;
                        break;
                    case "觀光系":
                        phone.department = department.觀光系;
                        break;
                    case "財金系":
                        phone.department = department.財金系;
                        break;
                    case "資管系":
                        phone.department = department.資管系;
                        break;
                }



                phone.test[0] = getinterger(textBox2.Text);
                phone.test[1] = getinterger(textBox3.Text);
                phone.test[2] = getinterger(textBox4.Text);
                phone.test[3] = getinterger(textBox5.Text);
                phone.test[4] = getinterger(textBox6.Text);
                phone.test[5] = getinterger(textBox7.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int getinterger(string inputtext)
        {
            int result=0;
            try
            {
                if(!int.TryParse(inputtext,out result))
                {
                    MessageBox.Show("成績錯誤");
                }
                if(result<0 || result > 100)
                {
                    MessageBox.Show("範圍錯誤");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }
            
            
            return result;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(grade.大一);
            comboBox1.Items.Add(grade.大二);
            comboBox1.Items.Add(grade.大三);
            comboBox1.Items.Add(grade.大四);
            comboBox1.Items.Add(grade.碩一);
            comboBox1.Items.Add(grade.碩二);


            //將職業的選項放入ComboBox
            comboBox2.Items.Add(department.資管系);
            comboBox2.Items.Add(department.經濟系);
            comboBox2.Items.Add(department.財金系);
            comboBox2.Items.Add(department.企管系);
            comboBox2.Items.Add(department.觀光系);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            int[] score;
            string information;
            


            if (listBox1.SelectedIndex != -1)
            {
                information = listBox1.SelectedItem.ToString();

                foreach (member phone in phoneList)
                {
                    if (information==phone.ID)
                    {
                        name = listBox1.SelectedItem.ToString();
                        MessageBox.Show(phone.ID + " " + phone.department + " " + phone.grade);
                    }
                    
                }
                

            }
            else
            {
                MessageBox.Show("使用者沒有點選隊名");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EverMemberAverage();
            
        }
        private void EverMemberAverage()
        {
            listBox2.Items.Clear();
            double average = 0;
            double total = 0;
            int totalStudent = phoneList.Count;

            double[] studentAverageScore = new double[totalStudent];

            for (int i =0 ; i<totalStudent; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    total += phoneList[i].test[j];
                }
                average = total / 6;
                listBox2.Items.Add(average);
                studentAverageScore[i] = average;
                total = 0;
            }
            label11.Text=totalAverage(studentAverageScore).ToString();
        }
        private double totalAverage(double[] studentAverageScore)
        {
            double average=0;
            double total = 0;

            foreach(double item in studentAverageScore)
            {
                total += item;
            }
            average = total / studentAverageScore.Length;
            
            return average;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] counter = new int[5];
            foreach (member phone in phoneList)
            {
                switch (phone.department)
                {
                    case department.企管系:
                        counter[0]++;
                        break;
                    case department.經濟系:
                        counter[1]++;
                        break;
                    case department.觀光系:
                        counter[2]++;
                        break;
                    case department.財金系:
                        counter[3]++;
                        break;
                    case department.資管系:
                        counter[4]++;
                        break;

                }
            }
            MessageBox.Show("資管系:" + counter[4] + "財金系:" + counter[3] + "觀光系:" + counter[2] + "經濟系:" + counter[1] + "企管系:" + counter[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
