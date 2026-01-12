using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaWindowsFormsApp
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int n1, n2, n3, prize = 0, desposit = 0, totalWin = 0;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You inserted" + desposit.ToString("c") + "You win" + totalWin.ToString("c"));
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            checkWinner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getImage();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            getImage();

            desposit += int.Parse(textBox1.Text);
            checkWinner();
        }

        private void getImage()
        {
            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);

            pictureBox1.Image = imageList1.Images[n1];
            pictureBox2.Image = imageList1.Images[n2];
            pictureBox3.Image = imageList1.Images[n3];
        }

        private void checkWinner()
        {
            if (n1 == n2 && n2 == n3)
            {
                prize = int.Parse(textBox1.Text) * 2;
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                prize = int.Parse(textBox1.Text) * 2;
            }
            else
            {
                prize = 0;
            }

            totalWin += prize;
            MessageBox.Show("You win" + prize.ToString("c"));
        }
    }
}
