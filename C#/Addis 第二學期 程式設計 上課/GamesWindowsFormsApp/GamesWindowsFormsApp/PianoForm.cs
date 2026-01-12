using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesWindowsFormsApp
{
    public partial class PianoForm : Form
    {
        public PianoForm()
        {
            InitializeComponent();
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            Console.Beep(262,500);
        }

        private void ReButton_Click(object sender, EventArgs e)
        {
            Console.Beep(294, 500);
        }

        private void MiButton_Click(object sender, EventArgs e)
        {
            Console.Beep(330, 500);
        }

        private void FaButton_Click(object sender, EventArgs e)
        {
            Console.Beep(349, 500);
        }

        private void SoButton_Click(object sender, EventArgs e)
        {
            Console.Beep(392, 500);
        }

        private void LaButton_Click(object sender, EventArgs e)
        {
            Console.Beep(440, 500);
        }

        private void SiButton_Click(object sender, EventArgs e)
        {
            Console.Beep(493, 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(523, 500);
        }

        private void PianoForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    Console.Beep(262, 500);
                    break;
                case Keys.D2:
                    Console.Beep(294, 500);
                    break;
                case Keys.D3:
                    Console.Beep(330, 500);
                    break;
                case Keys.D4:
                    Console.Beep(349, 500);
                    break;
                case Keys.D5:
                    Console.Beep(392, 500);
                    break;
                case Keys.D6:
                    Console.Beep(440, 500);
                    break;
                case Keys.D7:
                    Console.Beep(493, 500);
                    break;
                case Keys.D8:
                    Console.Beep(523, 500);
                    break;

                default:
                    MessageBox.Show("你按錯了!");
                    break;
            }
        }
    }
}
