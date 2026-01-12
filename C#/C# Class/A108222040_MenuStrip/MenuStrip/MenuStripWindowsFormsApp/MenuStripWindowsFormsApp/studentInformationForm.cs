using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripWindowsFormsApp
{
    //A108222040
    //潘凌徵
    enum College
    {
        管理學院,傳播學院,人文學院,其他
    }
    enum Department
    {
        資管系,經濟系,財金系,中文系,英文系,新聞系,傳管系,口傳系
    }
    enum Language
    {
        英語, 法語, 德語, 日語, 韓語, 西班牙語
    }

    public partial class studentInformationForm : Form
    {
        private List<studentData> studentDataList = new List<studentData>();

        struct studentData
        {
            public string id;
            public College C;
            public Department D;
            public Language L;
        }
        public studentInformationForm()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            studentData mystudentData = new studentData();
            getData(ref mystudentData);
            studentDataList.Add(mystudentData);
            IDTextBox.Clear();

            string output;
            StudentDatalistBox.Items.Clear();
            foreach (studentData data in studentDataList)
            {
                output = mystudentData.id;
                StudentDatalistBox.Items.Add(output);
            }
            IDTextBox.Text = "";
        }

        private void getData (ref studentData mystudentData)
        {
            string inputCollege,inputDepartment,inputLanguage;
            try
            {
                mystudentData.id = IDTextBox.Text;

                inputCollege = CollegecomboBox1.SelectedItem.ToString();
                switch (inputCollege)
                {
                    case "管理學院":
                        mystudentData.C = College.管理學院;
                        break;
                    case "傳播學院":
                        mystudentData.C = College.傳播學院;
                        break;
                    case "人文學院":
                        mystudentData.C = College.人文學院;
                        break;
                    case "其他":
                        mystudentData.C = College.其他;
                        break;
                }

                inputDepartment = DepartmentcomboBox1.SelectedItem.ToString();
                switch (inputDepartment)
                {
                    case "資管系":
                        mystudentData.D = Department.資管系;
                        break;
                    case "經濟系":
                        mystudentData.D = Department.經濟系;
                        break;
                    case "財金系":
                        mystudentData.D = Department.財金系;
                        break;
                    case "中文系":
                        mystudentData.D = Department.中文系;
                        break;
                    case "英文系":
                        mystudentData.D = Department.英文系;
                        break;
                    case "新聞系":
                        mystudentData.D = Department.新聞系;
                        break;
                    case "傳管系":
                        mystudentData.D = Department.傳管系;
                        break;
                    case "口傳系":
                        mystudentData.D = Department.口傳系;
                        break;
                }

                inputLanguage = SecondLanguagecomboBox1.SelectedItem.ToString();
                switch (inputLanguage)
                {
                    case "英語":
                        mystudentData.L = Language.英語;
                        break;
                    case "法語":
                        mystudentData.L = Language.法語;
                        break;
                    case "德語":
                        mystudentData.L = Language.德語;
                        break;
                    case "日語":
                        mystudentData.L = Language.日語;
                        break;
                    case "韓語":
                        mystudentData.L = Language.韓語;
                        break;
                    case "西班牙語":
                        mystudentData.L = Language.西班牙語;
                        break;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentInformationForm_Load(object sender, EventArgs e)
        {
            CollegecomboBox1.Items.Add(College.管理學院);
            CollegecomboBox1.Items.Add(College.傳播學院);
            CollegecomboBox1.Items.Add(College.人文學院);
            CollegecomboBox1.Items.Add(College.其他);

            DepartmentcomboBox1.Items.Add(Department.資管系);
            DepartmentcomboBox1.Items.Add(Department.經濟系);
            DepartmentcomboBox1.Items.Add(Department.財金系);
            DepartmentcomboBox1.Items.Add(Department.中文系);
            DepartmentcomboBox1.Items.Add(Department.英文系);
            DepartmentcomboBox1.Items.Add(Department.新聞系);
            DepartmentcomboBox1.Items.Add(Department.傳管系);
            DepartmentcomboBox1.Items.Add(Department.口傳系);

            SecondLanguagecomboBox1.Items.Add(Language.英語);
            SecondLanguagecomboBox1.Items.Add(Language.法語);
            SecondLanguagecomboBox1.Items.Add(Language.德語);
            SecondLanguagecomboBox1.Items.Add(Language.日語);
            SecondLanguagecomboBox1.Items.Add(Language.韓語);
            SecondLanguagecomboBox1.Items.Add(Language.西班牙語);
        }

        private void Listbutton_Click(object sender, EventArgs e)
        {
            string name;
            string information;
            if (StudentDatalistBox.SelectedIndex != -1)
            {
                information = StudentDatalistBox.SelectedItem.ToString();
                foreach (studentData data in studentDataList)
                {
                    if (information == data.id)
                    {
                        name = StudentDatalistBox.SelectedItem.ToString();
                        MessageBox.Show(data.id + "  " + data.C + "  " + data.D + "  " + data.L);
                    }
                    else
                    {
                        MessageBox.Show("錯誤");
                    }
                }
            }
        }

        private void Countbutton_Click(object sender, EventArgs e)
        {
            int[] counter = new int[4];
            foreach (studentData data in studentDataList)
            {
                switch (data.C)
                {
                    case College.管理學院:
                        counter[0]++;
                        break;
                    case College.傳播學院:
                        counter[1]++;
                        break;
                    case College.人文學院:
                        counter[2]++;
                        break;
                    case College.其他:
                        counter[3]++;
                        break;
                }              
            }
            MessageBox.Show("管理學院:" + counter[0] + "傳播學院:" + counter[1] + "人文學院:" + counter[2] + "其他:" + counter[3]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] counter = new int[6];
            
            foreach (studentData data in studentDataList)
            {
                switch (data.L)
                {
                    case Language.英語:
                        counter[0]++;
                        break;
                    case Language.法語:
                        counter[1]++;
                        break;
                    case Language.德語:
                        counter[2]++;
                        break;
                    case Language.日語:
                        counter[3]++;
                        break;
                    case Language.韓語:
                        counter[4]++;
                        break;
                    case Language.西班牙語:
                        counter[5]++;
                        break;
                }              
            }
            MessageBox.Show("英語:" + counter[0] + "法語:" + counter[1] + "德語:" + counter[2] + "日語:" + counter[3] + "韓語:" + counter[4] + "西班牙語:" + counter[5]);

            int most;
            //最多人學的語言
            for (int i = 0; i < counter.Length;i++)
            {
                most = counter[i];
                MessageBox.Show("最多:" + most.ToString());
            }           
        }

        private void CollegecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
