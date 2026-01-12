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

namespace StudentScoreWindowsFormsApp
{
    enum Grade
    {
        大一,大二,大三,大四,碩一,碩二,其他
    }
    enum Department
    {
        資管系,經濟系,財金系,企管系,觀光系
    }
    
    public partial class Form1 : Form
    {
        private List<studentDATA> studentDATAlist = new List<studentDATA>();
        private List<int> score = new List<int>();
        struct studentDATA
        {
            public string id;
            public Grade grade;
            public Department department;
            public int[] test;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GradeComboBox.Items.Add(Grade.大一);
            GradeComboBox.Items.Add(Grade.大二);
            GradeComboBox.Items.Add(Grade.大三);
            GradeComboBox.Items.Add(Grade.大四);
            GradeComboBox.Items.Add(Grade.碩一);
            GradeComboBox.Items.Add(Grade.碩二);
            GradeComboBox.Items.Add(Grade.其他);

            DepartmentComboBox.Items.Add(Department.資管系);
            DepartmentComboBox.Items.Add(Department.企管系);
            DepartmentComboBox.Items.Add(Department.經濟系);
            DepartmentComboBox.Items.Add(Department.觀光系);
            DepartmentComboBox.Items.Add(Department.財金系);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            studentDATA mystudentDATA = new studentDATA();
            mystudentDATA.test = new int[6];
            getData(ref mystudentDATA);
            studentDATAlist.Add(mystudentDATA);
            

            ChineseTextBox.Clear();
            //宣告ㄧ個字串放入一台手機的資訊
            string output;
            IDListBox.Items.Clear();

            //顯示串列的資料
            foreach (studentDATA DATA in studentDATAlist)
            {
                output = DATA.id;
                IDListBox.Items.Add(output);
            }
            ChineseTextBox.Text = "";
            MathTextBox.Text = "";
            EnglishTextBox.Text = "";
            PhysicalTextBox.Text = "";
            HistoryTextBox.Text = "";
            PETextBox.Text = "";

        }

        private void getData(ref studentDATA mystudentDATA)
        {
            string inputData;
            string inputdepartment;
            try
            {
                
                //mystudentDATA.Sscore = new int[6];
                mystudentDATA.id = IDTextBox.Text;

                inputData = GradeComboBox.SelectedItem.ToString();
                if (inputData == "大一")
                {
                    mystudentDATA.grade = Grade.大一;
                }
                else if (inputData == "大二")
                {
                    mystudentDATA.grade = Grade.大二;
                }
                else if (inputData == "大三")
                {
                    mystudentDATA.grade = Grade.大三;
                }
                else if (inputData == "大四")
                {
                    mystudentDATA.grade = Grade.大四;
                }
                else if (inputData == "碩一")
                {
                    mystudentDATA.grade = Grade.碩一;
                }
                else if (inputData == "碩二")
                {
                    mystudentDATA.grade = Grade.碩二;
                }
                else
                {
                    mystudentDATA.grade = Grade.其他;
                }

                inputdepartment = DepartmentComboBox.SelectedItem.ToString();
                switch(inputdepartment)
                {
                    case "資管系":
                        mystudentDATA.department = Department.資管系;
                    break;
                    case "企管系":
                        mystudentDATA.department = Department.企管系;
                        break;
                    case "經濟系":
                        mystudentDATA.department = Department.經濟系;
                        break;
                    case "觀光系":
                        mystudentDATA.department = Department.觀光系; 
                    break;
                    case "財金系":
                        mystudentDATA.department = Department.財金系;
                        break;                      
                }
                mystudentDATA.test[0] = getinteger(ChineseTextBox.Text);
                mystudentDATA.test[1] = getinteger(MathTextBox.Text);
                mystudentDATA.test[2] = getinteger(EnglishTextBox.Text);
                mystudentDATA.test[3] = getinteger(PhysicalTextBox.Text);
                mystudentDATA.test[4] = getinteger(HistoryTextBox.Text);
                mystudentDATA.test[5] = getinteger(PETextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getinteger(string inputtext)
        {
            int result = 0;
            try
            {
                if (!int.TryParse(inputtext,out result))
                {
                    MessageBox.Show("成績錯誤");
                }
                if (result < 0　|| result > 100　　)
                {
                    MessageBox.Show("範圍錯誤");
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            string name;
            int[] score;
            string information;

            if (IDListBox.SelectedIndex != -1)
            {
                information = IDListBox.SelectedItem.ToString();

                foreach (studentDATA phone in studentDATAlist)
                {
                    if (information == phone.id)
                    {
                        name = IDListBox.SelectedItem.ToString();
                        MessageBox.Show(phone.id + " " + phone.department + " " + phone.grade);
                    }

                }


            }
            else
            {
                MessageBox.Show("使用者沒有點選隊名");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EveryMemberAverageGrade();
        }

        private void EveryMemberAverageGrade()
        {
            listBox1.Items.Clear();
            double average = 0;
            double total = 0;
            int totalStudent = studentDATAlist.Count; //目前註冊人數

            double[] studentAverageScore = new double[totalStudent]; //宣告陣列儲存學生的平均成績

            for (int i = 0; i < totalStudent ; i++)
            {
                for (int j = 0 ; j < 6 ; j ++)
                {
                    total += studentDATAlist[i].test[j];
                }
                average = total / 6;
                listBox1.Items.Add(average);
                studentAverageScore[i] = average;
                total = 0;
            }
            　label10.Text = TotalAverage(studentAverageScore).ToString();
        }

        private double TotalAverage(double [] studentAverageScore)
        {
            double average = 0;
            double total = 0;

            foreach (double item in studentAverageScore)
            {
                total += item;
            }
            average = total / studentAverageScore.Length;

            return average;
        }

        private void StudentNumberButton_Click(object sender, EventArgs e)
        {
            int[] counter = new int[5];
            foreach (studentDATA phone in studentDATAlist)
            {
                switch (phone.department)
                {
                    case Department.企管系:
                        counter[0]++;
                        break;
                    case Department.經濟系:
                        counter[1]++;
                        break;
                    case Department.觀光系:
                        counter[2]++;
                        break;
                    case Department.財金系:
                        counter[3]++;
                        break;
                    case Department.資管系:
                        counter[4]++;
                        break;
                }
            }
            MessageBox.Show("資管系:" + counter[4] + "財金系:" + counter[3] + "觀光系:" + counter[2] + "經濟系:" + counter[1] + "企管系:" + counter[0]);
        }
    }
}
