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
    public partial class funGameForm : Form
    {
        Random rand = new Random();
        int n1, n2, n3, n4, n5, n6, point = 0, totalWin = 0;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You inserted" + point.ToString("c") + totalWin.ToString("c"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {

            }
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            getImage();
            checkWinner();
        }

        private void checkWinner()
        {
            if (n1 + n4 + n6 > n2 + n3 + n5)
            {
                point = 11;
                totalWin = point;
                MessageBox.Show("You win" + totalWin.ToString());
            }
        }

        private void getImage()
        {
            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);
            n4 = rand.Next(imageList1.Images.Count);
            n5 = rand.Next(imageList1.Images.Count);
            n6 = rand.Next(imageList1.Images.Count);

            pictureBox1.Image = imageList1.Images[n1];
            pictureBox1.Image = imageList1.Images[n4];
            pictureBox1.Image = imageList1.Images[n6];

            pictureBox2.Image = imageList1.Images[n2];
            pictureBox2.Image = imageList1.Images[n3];
            pictureBox2.Image = imageList1.Images[n5];
        }

        public funGameForm()
        {
            InitializeComponent();
        }

        private void funGameForm_Load(object sender, EventArgs e)
        {
            getImage();
        }
    }
}
