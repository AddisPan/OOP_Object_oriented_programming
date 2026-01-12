using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BasketballWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int players; //球員的數量代表二維陣列中的ROW
        int games; //場次的數量代表二維陣列中的COL

        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputfile;

                string line;
                char[] delim = {','};

                string [] tokens;

                inputfile = File.OpenText("Scores.txt");

                line = inputfile.ReadLine();

                ScoreListBox.Items.Add(line);

                players = 0;
                tokens = line.Split(null);

                games = tokens.Length;

                while (!inputfile.EndOfStream)
                {
                    players++;

                    line = inputfile.ReadLine();
                    tokens = line.Split(null);

                    line = tokens[0];

                    for (int i = 1 ; i < games ; i++)
                    {
                        line = line + "\t" + tokens[i];
                    }
                    ScoreListBox.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int[,] scoreData = new int[players,games];

            storeDataToArray(scoreData);

            showArray(scoreData);
        }

        private void storeDataToArray(int [,] scoreData)
        {
            string[] tokens;

            int players = 0;
            int games = 0;

            for (int i = 1 ; i < ScoreListBox.Items.Count ; i++)
            {
                tokens = ScoreListBox.Items[i].ToString().Split(null);

                games = 0;

                for (int j = 1 ; j < tokens.Length ; j++)
                {
                    scoreData[players, games++] = int.Parse(tokens[j]);
                }
                players++;
            }
        }

        private void showArray(int[,] scoreData)
        {
            string record;

            for (int i = 0 ; i < players ; i++)
            {
                record = "";

                for (int j = 0 ; j < games ; j++)
                {
                    record += scoreData[i,j].ToString() + "\t";
                }
                ShowArrayListBox.Items.Add(record);
            }
        }
    }
}
