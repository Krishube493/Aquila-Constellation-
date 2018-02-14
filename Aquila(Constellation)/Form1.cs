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
            //Clear 
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Pen drawPen = new Pen(Color.Red, 10);
            g.Clear(Color.Black);
            
            //Inside Of Card
            // drawn graphics and text describing chosen constellation, At least 2 different fonts used. 
            //At least 3 different colours used.
            //Show an accurate display of the constellation. No images. Draw it all yourself.
            //Display some nicely formatted text with a paragraph about the constellation.
            //Include multiple sounds and timing events. You choose when and how.
            //At least 2 timing effects. (e.g. flashing stars, text appearing one line at a time, etc.).

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Front Of Card
            //Front Page contains a title, your name, and background design
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Pen drawPen = new Pen(Color.Red, 10);
            g.DrawString("Hello", drawFont, drawBrush, 50, 40);

        }
    }
}
