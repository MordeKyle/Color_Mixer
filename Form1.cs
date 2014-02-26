using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program: Color Mixer
//Author: Kyle McBride A02609917
//Date: 02/25/2014
//Description: User selects a color from each side of the form and the porgram mixes the two colors, changing the background
//             to change to the mixed color.
// SEE CHANGELOG IN SOLUTION DIRECTORY

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        //assigning variables
        int firstValue; //variable for the left side
        int secondValue; //variable for the right side
        int backColorValue; //variable for the background
        const int redValue = 2; //value of the color red
        const int blueValue = 10; //value of the color blue
        const int yellowValue = 20; //value of the color yellow
        const int purpleValue = 6; //value of the color purple
        const int orangeValue = 11; //value of the color orange
        const int greenValue = 15; //value of the color green

        public Form1()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            backColorValue = firstValue + secondValue; //adding the value from the colors selected on left and right side

            // testing what the added value is equal to and changing the background color to the added value.
            if (backColorValue == redValue)
            {
                this.BackColor = Color.Red;
            }
            else if (backColorValue == blueValue)
            {
                this.BackColor = Color.Blue;
            }
            else if (backColorValue == yellowValue)
            {
                this.BackColor = Color.Yellow;
            }
            else if (backColorValue == purpleValue)
            {
                this.BackColor = Color.Purple;
            }
            else if (backColorValue == orangeValue)
            {
                this.BackColor = Color.Orange;
            }
            else if (backColorValue == greenValue)
            {
                this.BackColor = Color.Green;
            }
            else
                MessageBox.Show("Please select a color from each side.");
        }
        //the following is changing the values of the left and right side selections to be added on mixButton_click
        private void firstRadRed_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRadRed.Checked)
            {
                firstValue = 1;
            }
        }

        private void secondRadRed_CheckedChanged(object sender, EventArgs e)
        {
            if (secondRadRed.Checked)
            {
                secondValue = 1;
            }
        }

        private void firstRadBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRadBlue.Checked)
            {
                firstValue = 5;
            }
        }

        private void secondRadBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (secondRadBlue.Checked)
            {
                secondValue = 5;
            }
        }

        private void firstRadYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (firstRadYellow.Checked)
            {
                firstValue = 10;
            }
        }

        private void secondRadYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (secondRadYellow.Checked)
            {
                secondValue = 10;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
