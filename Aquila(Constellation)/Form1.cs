/// Aquila 
/// Created By Kristianna H. 
/// Feb. 2018
/// program that informs the user about the star constellation Aquila, The eagle 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Aquila_Constellation_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Create Stars 
            AquilaT.Visible = false;
            MyName.Visible = false;
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 25, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.Red, 1);
            g.Clear(Color.Black);
            Thread.Sleep(300);
            //Number1 star
            g.FillEllipse(drawBrush, 130, 130, 18, 18);
            Thread.Sleep(300);
            //Number2 star 
            g.FillEllipse(drawBrush, 153, 112, 16, 16);
            Thread.Sleep(300);
            //Number 7 star
            g.FillEllipse(drawBrush, 112, 172, 14, 14);
            Thread.Sleep(300);
            //Number 3 star
            g.FillEllipse(drawBrush, 312, 51, 17, 17);
            Thread.Sleep(300);
            //Number9 star
            g.FillEllipse(drawBrush, 340, 31, 12, 12);
            Thread.Sleep(300);
            //Number5 star 
            g.FillEllipse(drawBrush, 232, 223, 18, 18);
            Thread.Sleep(300);
            //Number8 star 
            g.FillEllipse(drawBrush, 126, 259, 14, 14);
            Thread.Sleep(300);
            //Number4 star 
            g.FillEllipse(drawBrush, 48, 290, 14, 14);
            Thread.Sleep(300);
            //Number10 star
            g.FillEllipse(drawBrush, 190, 297, 12, 12);
            Thread.Sleep(300);
            //Number6 star
            g.FillEllipse(drawBrush, 313, 355, 18, 18);
            Thread.Sleep(300);
            g.DrawLine(drawPen, 138, 138, 120, 180);


            //Inside Of Card
            // drawn graphics and text describing chosen constellation, At least 2 different fonts used. 
            //At least 3 different colours used.
            //Display some nicely formatted text with a paragraph about the constellation.
            //Include multiple sounds and timing events. You choose when and how.
            //At least 2 timing effects. (e.g. flashing stars, text appearing one line at a time, etc.).

        }

       
    }
}
