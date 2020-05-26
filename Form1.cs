using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        const int MAX = 6; //number of loops

        public Form1()
        {
            InitializeComponent();
        }


        private void writeText(object sender, PaintEventArgs e)
        {
            int x = 50;
            int y = 20;

            Graphics g = e.Graphics;                // create a new graphics object g
            Font myFont = new Font("Times New Roman", 30);    // create a font myFont

            for (int i = 0; i < MAX; i++)
            {
                System.Threading.Thread.Sleep(500); //sets a 0.5 second delay
                g.DrawString("Dylan is texting a Window", myFont, Brushes.Red, x, y); //writes out text according to the given info
                y += 40; //Moves onto a new line

                //task 6.1.6 when the program is minimised the text is wiped from the form and 
                           //repeats the loop once again.

                //g.Clear(BackColor); task 6.1.7 By adding this to the loop it causes the text
                                     //to be wiped as soon as it appears causing the 
                                     //program to look like nothing is happening
            }
        }
    }
}
