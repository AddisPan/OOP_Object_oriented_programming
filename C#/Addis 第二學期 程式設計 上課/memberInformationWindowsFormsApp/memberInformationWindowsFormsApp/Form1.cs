using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memberInformationWindowsFormsApp
{
    //定義會員資料
    //定義性別列舉
    enum Gender
    {
        male,female,tertiary
    }

    //定義職業列舉
    enum Carrier
    {
        公職或教育,商業,工業,漁民,其他
    }

    //定義會員的結構
    struct member
    {
        public string id;
        public string name;
        public int year;
        public Gender sex;
        public Carrier job;
    }

    public partial class Form1 : Form
    {
        private List<member> memberlist = new List<member>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //將性別的選項放入ComboBox
            GenderComboBox.Items.Add(Gender.female);
            GenderComboBox.Items.Add(Gender.male);
            GenderComboBox.Items.Add(Gender.tertiary);

            //將職業的選項放入ComboBox
            CarrierComboBox.Items.Add(Carrier.公職或教育);
            CarrierComboBox.Items.Add(Carrier.商業);
            CarrierComboBox.Items.Add(Carrier.工業);
            CarrierComboBox.Items.Add(Carrier.漁民);
            CarrierComboBox.Items.Add(Carrier.其他);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            member mymember = new member();
            getData(ref mymember);
            memberlist.Add(mymember);
            NumberTextBox.Clear();
            NameTextBox.Clear();
            YearTextBox.Clear();
            
            NumberTextBox.Focus();
        }

        private void getData(ref member mymember)
        {
            try
            {
                string inputData;
                string inputCarrier;
                mymember.id = NumberTextBox.Text;
                mymember.name = NameTextBox.Text;
                mymember.year = int.Parse(YearTextBox.Text.ToString());

                if (NumberTextBox.Text == NumberTextBox.Text)
                {
                    memberlist.Clear();
                }
                else
                {
                    MessageBox.Show("錯誤");
                }
                if (NameTextBox.Text == NameTextBox.Text)
                {
                    memberlist.Clear();
                }
                else
                {
                    MessageBox.Show("錯誤");
                }
                if (YearTextBox.Text == YearTextBox.Text)
                {
                    memberlist.Clear();
                }
                else
                {
                    MessageBox.Show("錯誤");
                }

                //從表單讀取性別
                inputData = GenderComboBox.SelectedItem.ToString();
                if (inputData == "male")
                {
                    mymember.sex = Gender.male;
                }
                else if (inputData == "female")
                {
                    mymember.sex = Gender.female;
                }
                else
                {
                    mymember.sex = Gender.tertiary;
                }

                inputCarrier = CarrierComboBox.SelectedItem.ToString();
                switch (inputCarrier)  
                {
                    case "公職或教育":
                        mymember.job = Carrier.公職或教育;
                        break;
                    case "商業":
                        mymember.job = Carrier.商業;
                        break;
                    case "工業":
                        mymember.job = Carrier.工業;
                        break;
                    case "漁民":
                        mymember.job = Carrier.漁民;
                        break;
                    case "其他":
                        mymember.job = Carrier.其他;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listbutton_Click(object sender, EventArgs e)
        {
            string output;
            MemberListBox.Items.Clear();

            foreach(member mymember in memberlist)
            {
                output = mymember.id + "  " + mymember.name + "  " + mymember.year + "  "
                    + mymember.sex + "  " + mymember.job;
                MemberListBox.Items.Add(output);
            }
        }
    }
}
