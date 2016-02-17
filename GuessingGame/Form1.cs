/// Description: The program generates a random number between 1-100 which
///              the use must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        //int rand = randNum.Next(1, 101);
        int rand = randNum.Next(1, 101);
        //Creates List
        public static List<int> guesses = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // get the users guess and place into a variable
            int guess = Convert.ToInt16(inputBox.Text);

            //Add to List
            guesses.Add(guess);

            // check guess against the random value and output appropriate message
            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";

                Thread.Sleep(3000);

                UserControl1 rs = new UserControl1();
                this.Controls.Add(rs);

                //Make form invisible
                titleLabel.Visible = false;
                promptLabel.Visible = false;
                inputBox.Visible = false;
                guessButton.Visible = false;
            }

            // clear out the input box 
            inputBox.Text = "";
        }
    }
}