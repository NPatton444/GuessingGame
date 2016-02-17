using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //Display Number of guesses
            label1.Text = "Number of Guesses: " + Convert.ToString(Form1.guesses.Count());

            //Display Order of Guesses\
            label1.Text += "\nOriginal order:\n";
            for (int i = 0; i < Form1.guesses.Count(); i++)
            {
                label1.Text += " " + Form1.guesses[i];
            }

            //Sorted order
            label1.Text += "\nSorted order:\n";
            Form1.guesses.Sort();
            for (int i = 0; i < Form1.guesses.Count(); i++)
            {
                label1.Text += " " + Convert.ToString(Form1.guesses[i]);
            }
        }
    }
}
