using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 加減乘除WindowsFormsApp2
{
    public partial class form1 : Form
    {
        public form1() => InitializeComponent();

        private void ResultButton_Click(object sender, EventArgs e)
        {
            float N1;
            float N2;

            float AdditionResult;
            float SubtractionResult;
            float MultiplicationResult;
            float DivisionResult;

            N1 = float.Parse(Number1.Text);
            N2 = float.Parse(Number2.Text);

            AdditionResult = N1 + N2;
            SubtractionResult = N1 - N2;
            MultiplicationResult = N1 * N2;
            DivisionResult = N1 / N2;

            AdditionLebel.Text = AdditionResult.ToString();
            SubtractionLebel.Text = SubtractionResult.ToString();
            MultiplicationLebel.Text = MultiplicationResult.ToString();
            DivisionLebel.Text = DivisionResult.ToString();
        }
    }
}
