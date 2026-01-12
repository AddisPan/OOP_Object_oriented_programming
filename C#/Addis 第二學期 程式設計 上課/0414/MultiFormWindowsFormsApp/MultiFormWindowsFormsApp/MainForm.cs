using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //利用new產生一個自訂的openFileForm表單物件
            openFileForm myopenFileForm = new openFileForm();

            //開啟新的自訂的表單物件
            myopenFileForm.ShowDialog();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //利用new產生一個自訂的saveFileForm表單物件
            saveFileForm mysaveFileForm = new saveFileForm();

            //開啟新的自訂的表單物件
            mysaveFileForm.ShowDialog();
        }
    }
}
