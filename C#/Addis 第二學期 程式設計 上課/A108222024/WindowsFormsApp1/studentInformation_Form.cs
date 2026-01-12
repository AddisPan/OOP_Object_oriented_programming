using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//number:A108222024
//student:張訓瑋
namespace WindowsFormsApp1
{
    public partial class studentInformation_Form : Form
    {
        enum Uni
        {
            管理學院,傳播學院,人文學院,其他
        }
        enum dep
        {
            資管系,經濟系,財金系,中文系,英文系,新聞系,傳管系,口傳系
        }
        enum LanG
        {
            英語,法語,德語,日語,韓語,西班牙語
        }
        struct studentdata
        {
            public string ID;
            public Uni UniS;
            public dep depS;
            public LanG[] LanGS;
        }
        public studentInformation_Form()
        {
            InitializeComponent();
        }
        
        private void studentInformation_Form_Load(object sender, EventArgs e)
        {
            setting();
        }
        private void setting()
        {
            foreach (var item in Enum.GetValues(typeof(Uni)))
            {
                comboBox1.Items.Add(item);
            }
            
            foreach (var item in Enum.GetValues(typeof(LanG)))
            {
                comboBox3.Items.Add(item);
                comboBox4.Items.Add(item);
            }
        }
        private List<studentdata> stuList = new List<studentdata>();
        private int[] UniNumber;
        private int[] LanNumber;

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewData();
            CountNumber();

        }

        private void LANGG(ref studentdata stuTemp ,string Temp,int i)
        {
            switch (Temp)
            {
                case "英語":
                    stuTemp.LanGS[i] = LanG.英語;
                    break;
                case "法語":
                    stuTemp.LanGS[i] = LanG.法語;
                    break;
                case "德語":
                    stuTemp.LanGS[i] = LanG.德語;
                    break;
                case "日語":
                    stuTemp.LanGS[i] = LanG.日語;
                    break;
                case "韓語":
                    stuTemp.LanGS[i] = LanG.韓語;
                    break;
                case "西班牙語":
                    stuTemp.LanGS[i] = LanG.西班牙語;
                    break;
            }
        }
        private void CountNumber()
        {
            UniNumber = new int[4];
            LanNumber = new int[6];
            foreach ( var item in stuList)
            {
                switch (item.UniS)
                {
                    case Uni.管理學院:
                        UniNumber[0] += 1;
                        break;
                    case Uni.傳播學院:
                        UniNumber[1] += 1;
                        break;
                    case Uni.人文學院:
                        UniNumber[2] += 1;
                        break;
                    case Uni.其他:
                        UniNumber[3] += 1;
                        break;
                }
                foreach (var item2 in item.LanGS)
                {
                    switch (item2)
                    {
                        case LanG.英語:
                            LanNumber[0] += 1;
                            break;
                        case LanG.法語:
                            LanNumber[1] += 1;
                            break;
                        case LanG.德語:
                            LanNumber[2] += 1;
                            break;
                        case LanG.日語:
                            LanNumber[3] += 1;
                            break;
                        case LanG.韓語:
                            LanNumber[4] += 1;
                            break;
                        case LanG.西班牙語:
                            LanNumber[5] += 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            
        }
        private void AddNewData()
        {
            studentdata stuTemp = new studentdata();
            stuTemp.LanGS = new LanG[2];
            stuTemp.ID = textBox1.Text;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "管理學院":
                    stuTemp.UniS = Uni.管理學院;
                    break;
                case "傳播學院":
                    stuTemp.UniS = Uni.傳播學院;
                    break;
                case "人文學院":
                    stuTemp.UniS = Uni.人文學院;
                    break;
                case "其他":
                    stuTemp.UniS = Uni.其他;
                    break;
            }
            switch (comboBox2.SelectedItem.ToString())
            {
                case "資管系":
                    stuTemp.depS = dep.資管系;
                    break;
                case "經濟系":
                    stuTemp.depS = dep.經濟系;
                    break;
                case "財金系":
                    stuTemp.depS = dep.財金系;
                    break;
                case "中文系":
                    stuTemp.depS = dep.中文系;
                    break;
                case "英文系":
                    stuTemp.depS = dep.英文系;
                    break;
                case "新聞系":
                    stuTemp.depS = dep.新聞系;
                    break;
                case "傳管系":
                    stuTemp.depS = dep.傳管系;
                    break;
                case "口傳系":
                    stuTemp.depS = dep.口傳系;
                    break;
            }

           
            LANGG(ref stuTemp, comboBox3.SelectedItem.ToString(), 0);
            LANGG(ref stuTemp, comboBox4.SelectedItem.ToString(), 1);
            
            stuList.Add(stuTemp);
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"管理學院 : {UniNumber[0]} , 傳播學院 : {UniNumber[1]} , 人文學院 : {UniNumber[2]} , 其他 : {UniNumber[3]}");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == comboBox4.SelectedItem)
            {
                MessageBox.Show("不能相同");
                button1.Enabled =false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == comboBox4.SelectedItem)
            {
                MessageBox.Show("不能相同");
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"英語 : {LanNumber[0]} , 法語 : {LanNumber[1]} , 德語 : {LanNumber[2]} , 日語 : {LanNumber[3]} , 韓語 : {LanNumber[4]} , 西班牙語 : {LanNumber[5]}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] temp = new string[6];
            int count = 0;
            foreach(var item in Enum.GetValues(typeof(LanG)))
            {
                temp[count] = item.ToString();
                count++;
            }

            MessageBox.Show(temp[Array.IndexOf(LanNumber, LanNumber.Max())].ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedItem.ToString())
            {

                case "管理學院":
                    
                    comboBox2.Items.Add(dep.資管系);
                    comboBox2.Items.Add(dep.經濟系);
                    comboBox2.Items.Add(dep.財金系);
                    break;
                case "傳播學院":
                    comboBox2.Items.Add(dep.新聞系);
                    comboBox2.Items.Add(dep.傳管系);
                    comboBox2.Items.Add(dep.口傳系);
                    break;
                case "人文學院":
                    comboBox2.Items.Add(dep.中文系);
                    comboBox2.Items.Add(dep.英文系);
                    break;
                case "其他":
                    comboBox2.Items.Add("無");
                    break;
                default:
                    break;
            }
        }
    }
}
