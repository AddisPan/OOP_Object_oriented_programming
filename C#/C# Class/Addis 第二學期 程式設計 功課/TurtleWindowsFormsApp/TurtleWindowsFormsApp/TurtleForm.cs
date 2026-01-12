using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleWindowsFormsApp
{
    public partial class TurtleForm : Form
    {
        Random rand = new Random();
        public TurtleForm()
        {
            InitializeComponent();
        }

        private void TurtleButton_Click(object sender, EventArgs e)
        {
            if (ThumbRadioButton.Checked == true || IndexFingerRadioButton.Checked == true || MiddleFingerRadioButton.Checked == true
                || RingFingerRadioButton.Checked == true || LittleFingerRadioButton.Checked == true)
            {
                Winner();
            }
            else
            {
                MessageBox.Show("請選擇");
            }
        }

        private void Winner()
        {
            int number;
            number = rand.Next(1, 6);
            ShowLabel.Text = number.ToString();
            if (ShowLabel.Text == "1" && ThumbRadioButton.Checked == true || ShowLabel.Text == "2" && IndexFingerRadioButton.Checked == true
                || ShowLabel.Text == "3" && MiddleFingerRadioButton.Checked == true || ShowLabel.Text == "4" && RingFingerRadioButton.Checked == true
                || ShowLabel.Text == "5" && LittleFingerRadioButton.Checked == true)
            {
                MessageBox.Show("You win the game!");
            }
        }
    }
}
