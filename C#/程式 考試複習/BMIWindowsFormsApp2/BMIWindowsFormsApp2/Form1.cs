using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int height;
        int weight;
        float BMI;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            BMI = weight / (height / 100) * (height /100);
            BMI = int.Parse(BMI2abel.Text);
            
            if (BMI < 18.5)
            {
                ThinRadioButton.Checked = true;
            }
            if (18.5 < BMI && BMI < 24)
            {
                MiddleRadioButton.Checked = true;
            }
            if (BMI > 24 && BMI < 27)
            {
                OverweightRadioButton.Checked = true;
            }
            if (BMI > 27)
            {
                FatRadioButton.Checked = true;
            }
        }
    }
}
