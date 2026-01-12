using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSelectWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MixButton_Click(object sender, EventArgs e)
        {

            if (Red1RadioButton.Checked && Blue2RadioButton.Checked || Blue1RadioButton.Checked && Red2RadioButton.Checked == true)
            {
                BackColor = Color.Purple;
            }
            else if (Blue1RadioButton.Checked && Yellow2RadioButton.Checked || Yellow1RadioButton.Checked && Blue2RadioButton.Checked == true)
            {
                BackColor = Color.Green;
            }
            else if (Red1RadioButton.Checked && Yellow2RadioButton.Checked || Yellow1RadioButton.Checked && Red2RadioButton.Checked == true)
            {
                BackColor = Color.Orange;
            }
            else if (Red1RadioButton.Checked && Red2RadioButton.Checked == true)
            {
                BackColor = Color.Red;
            }
            else if (Blue1RadioButton.Checked && Blue2RadioButton.Checked == true)
            {
                BackColor = Color.Blue;
            }
            else if (Yellow1RadioButton.Checked && Yellow2RadioButton.Checked == true)
            {
                BackColor = Color.Yellow;
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            //關閉表單
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("你確定要清除上一筆資料嗎?", "清除表單", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                Red1RadioButton.Checked = false;
                Red2RadioButton.Checked = false;
                Blue1RadioButton.Checked = false;
                Blue2RadioButton.Checked = false;
                Yellow1RadioButton.Checked = false;
                Yellow2RadioButton.Checked = false;
                BackColor = Color.White;
            }
                
        }
    }
}
