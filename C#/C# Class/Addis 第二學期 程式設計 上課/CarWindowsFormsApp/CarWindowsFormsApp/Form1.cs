using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWindowsFormsApp
{
    public partial class Form1 : Form
    {
        Car myCar = new Car(2022, "S-逐星者");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            YearLabel.Text = myCar.Year.ToString();
            ModelLabel.Text = myCar.Model.ToString();
            SpeedLabel.Text = myCar.Speed.ToString();
        }

        private void AccelerateButton_Click(object sender, EventArgs e)
        {
            myCar.Accelerate();
            SpeedLabel.Text = myCar.Speed.ToString();
        }

        private void BreakButton_Click(object sender, EventArgs e)
        {
            myCar.Break();
            SpeedLabel.Text = myCar.Speed.ToString();
        }

        private void SeeButton_Click(object sender, EventArgs e)
        {
            myCar.Speed = 400;
        }
    }
}
