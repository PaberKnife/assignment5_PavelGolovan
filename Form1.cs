using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rnd;
        int count = 0;

        private void generate()
        {
            Random rand = new Random();
            rnd = rand.Next(0, 100) + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(guessTextBox.Text, out n))
            {
                count++;
                attemptsLabel.Text = "Total attempts: " + count.ToString();
                if (n > rnd)
                {
                    resultLabel.Text = "Too high, try again.";
                }
                else if (n < rnd)
                {
                    resultLabel.Text = "Too low, try again.";
                }
                else
                {
                    resultLabel.Text = "Congratulations!";
                    generate();
                    count = 0;
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a number in the range of 1 through 100.");
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            generate();
            count = 0;
            attemptsLabel.Text = "Total attempts: " + count.ToString();
            guessTextBox.Text = "";
            resultLabel.Text = "";
            guessTextBox.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            guessTextBox.Text = "";
            resultLabel.Text = "";
            guessTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}