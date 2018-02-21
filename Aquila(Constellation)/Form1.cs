/// Aquila 
/// Created By Kristianna H. 
/// Feb. 2018
/// A program that informs the user about the star constellation Aquila, The eagle.

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
            starLabel.Visible = false;
            titleLabel.Visible = false;
            nameLabel.Visible = false;
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Copperplate Gothic Bold", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.White, 3);
            g.Clear(Color.Black);
            Thread.Sleep(300);

            //Draw stars in order of 1,2,7,3,9,5,8,4,10,6
            g.FillEllipse(drawBrush, 130, 130, 18, 18);
            Thread.Sleep(300);           
            g.FillEllipse(drawBrush, 153, 112, 16, 16);
            Thread.Sleep(300);           
            g.FillEllipse(drawBrush, 112, 172, 14, 14);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 312, 51, 17, 17);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 340, 31, 12, 12);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 232, 223, 18, 18);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 126, 259, 14, 14);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 48, 290, 14, 14);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 190, 297, 12, 12);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 313, 355, 18, 18);
            Thread.Sleep(300);

            //Sound effect
            SoundPlayer player = new SoundPlayer(Properties.Resources.ShootingStar);
            player.Play();
            Thread.Sleep(1000);

            //Draw line from star1 to star7,2
            g.DrawLine(drawPen, 138, 138, 120, 180);
            g.DrawLine(drawPen, 138, 138, 161, 120);

            //Draw line from star5 to star2,3,8,6
            g.DrawLine(drawPen, 239, 229, 161, 120);
            g.DrawLine(drawPen, 239, 229, 319, 55);
            g.DrawLine(drawPen, 239, 229, 129, 265);
            g.DrawLine(drawPen, 239, 229, 319, 358);

            //Draw line from star3 to star6,9
            g.DrawLine(drawPen, 319, 55, 319, 358);
            g.DrawLine(drawPen, 319, 55, 345, 35);

            //Draw line from star10 to star4,6
            g.DrawLine(drawPen, 190, 300, 50, 300);
            g.DrawLine(drawPen, 190, 300, 319, 358);

            //Draw line from star8 to star4
            g.DrawLine(drawPen, 129, 265, 50, 300);

            //Sound effect
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.ComputerSiFi);
            player2.Play();
            Thread.Sleep(1000);

            //Change colours of stars and lines
            Thread.Sleep(300);
            Refresh();
            g.Clear(Color.Black);
            drawPen.Color = Color.Red;
            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, 130, 130, 18, 18);
            g.FillEllipse(drawBrush, 153, 112, 16, 16);
            g.FillEllipse(drawBrush, 112, 172, 14, 14);
            g.FillEllipse(drawBrush, 312, 51, 17, 17);
            g.FillEllipse(drawBrush, 340, 31, 12, 12);
            g.FillEllipse(drawBrush, 232, 223, 18, 18);
            g.FillEllipse(drawBrush, 126, 259, 14, 14);
            g.FillEllipse(drawBrush, 48, 290, 14, 14);
            g.FillEllipse(drawBrush, 190, 297, 12, 12);
            g.FillEllipse(drawBrush, 313, 355, 18, 18);
            g.DrawLine(drawPen, 138, 138, 120, 180);
            g.DrawLine(drawPen, 138, 138, 161, 120);
            g.DrawLine(drawPen, 239, 229, 161, 120);
            g.DrawLine(drawPen, 239, 229, 319, 55);
            g.DrawLine(drawPen, 239, 229, 129, 265);
            g.DrawLine(drawPen, 239, 229, 319, 358);
            g.DrawLine(drawPen, 319, 55, 319, 358);
            g.DrawLine(drawPen, 319, 55, 345, 35);
            g.DrawLine(drawPen, 190, 300, 50, 300);
            g.DrawLine(drawPen, 190, 300, 319, 358);
            g.DrawLine(drawPen, 129, 265, 50, 300);
            Thread.Sleep(300);
            Refresh();
            g.Clear(Color.Black);
            drawPen.Color = Color.Blue;
            drawBrush.Color = Color.Blue;
            g.FillEllipse(drawBrush, 130, 130, 18, 18);
            g.FillEllipse(drawBrush, 153, 112, 16, 16);
            g.FillEllipse(drawBrush, 112, 172, 14, 14);
            g.FillEllipse(drawBrush, 312, 51, 17, 17);
            g.FillEllipse(drawBrush, 340, 31, 12, 12);
            g.FillEllipse(drawBrush, 232, 223, 18, 18);
            g.FillEllipse(drawBrush, 126, 259, 14, 14);
            g.FillEllipse(drawBrush, 48, 290, 14, 14);
            g.FillEllipse(drawBrush, 190, 297, 12, 12);
            g.FillEllipse(drawBrush, 313, 355, 18, 18);
            g.DrawLine(drawPen, 138, 138, 120, 180);
            g.DrawLine(drawPen, 138, 138, 161, 120);
            g.DrawLine(drawPen, 239, 229, 161, 120);
            g.DrawLine(drawPen, 239, 229, 319, 55);
            g.DrawLine(drawPen, 239, 229, 129, 265);
            g.DrawLine(drawPen, 239, 229, 319, 358);
            g.DrawLine(drawPen, 319, 55, 319, 358);
            g.DrawLine(drawPen, 319, 55, 345, 35);
            g.DrawLine(drawPen, 190, 300, 50, 300);
            g.DrawLine(drawPen, 190, 300, 319, 358);
            g.DrawLine(drawPen, 129, 265, 50, 300);
            Thread.Sleep(300);
            Refresh();
            g.Clear(Color.Black);
            drawPen.Color = Color.Yellow;
            drawBrush.Color = Color.Yellow;
            g.FillEllipse(drawBrush, 130, 130, 18, 18);
            g.FillEllipse(drawBrush, 153, 112, 16, 16);
            g.FillEllipse(drawBrush, 112, 172, 14, 14);
            g.FillEllipse(drawBrush, 312, 51, 17, 17);
            g.FillEllipse(drawBrush, 340, 31, 12, 12);
            g.FillEllipse(drawBrush, 232, 223, 18, 18);
            g.FillEllipse(drawBrush, 126, 259, 14, 14);
            g.FillEllipse(drawBrush, 48, 290, 14, 14);
            g.FillEllipse(drawBrush, 190, 297, 12, 12);
            g.FillEllipse(drawBrush, 313, 355, 18, 18);
            g.DrawLine(drawPen, 138, 138, 120, 180);
            g.DrawLine(drawPen, 138, 138, 161, 120);
            g.DrawLine(drawPen, 239, 229, 161, 120);
            g.DrawLine(drawPen, 239, 229, 319, 55);
            g.DrawLine(drawPen, 239, 229, 129, 265);
            g.DrawLine(drawPen, 239, 229, 319, 358);
            g.DrawLine(drawPen, 319, 55, 319, 358);
            g.DrawLine(drawPen, 319, 55, 345, 35);
            g.DrawLine(drawPen, 190, 300, 50, 300);
            g.DrawLine(drawPen, 190, 300, 319, 358);
            g.DrawLine(drawPen, 129, 265, 50, 300);
            Thread.Sleep(300);
            Refresh();
            g.Clear(Color.Black);
            drawPen.Color = Color.White;
            drawBrush.Color = Color.White;
            g.FillEllipse(drawBrush, 130, 130, 18, 18);
            g.FillEllipse(drawBrush, 153, 112, 16, 16);
            g.FillEllipse(drawBrush, 112, 172, 14, 14);
            g.FillEllipse(drawBrush, 312, 51, 17, 17);
            g.FillEllipse(drawBrush, 340, 31, 12, 12);
            g.FillEllipse(drawBrush, 232, 223, 18, 18);
            g.FillEllipse(drawBrush, 126, 259, 14, 14);
            g.FillEllipse(drawBrush, 48, 290, 14, 14);
            g.FillEllipse(drawBrush, 190, 297, 12, 12);
            g.FillEllipse(drawBrush, 313, 355, 18, 18);
            g.DrawLine(drawPen, 138, 138, 120, 180);
            g.DrawLine(drawPen, 138, 138, 161, 120);
            g.DrawLine(drawPen, 239, 229, 161, 120);
            g.DrawLine(drawPen, 239, 229, 319, 55);
            g.DrawLine(drawPen, 239, 229, 129, 265);
            g.DrawLine(drawPen, 239, 229, 319, 358);
            g.DrawLine(drawPen, 319, 55, 319, 358);
            g.DrawLine(drawPen, 319, 55, 345, 35);
            g.DrawLine(drawPen, 190, 300, 50, 300);
            g.DrawLine(drawPen, 190, 300, 319, 358);
            g.DrawLine(drawPen, 129, 265, 50, 300);
            Thread.Sleep(1000);

            //Paragraph About Aquila with 2 Diffrent Fonts 
            g.DrawString("Aquila, The Eagle", drawFont, drawBrush, 367, 25);
            drawFont = new Font("Times New Roman", 14, FontStyle.Bold);
            g.DrawString("Aquila is a constellation on \n the celestial equator. \n Its name is Latin for eagle. \n It represents the bird that \n carried Jupiter's thunderbolts \n in Greak mythology.", drawFont, drawBrush, 367, 75);
            Thread.Sleep(900);
            g.DrawString("Aquila was one of the 48 \n constellations described \n by the second-century \n astronomer Ptolemy.", drawFont, drawBrush, 367, 200);
            Thread.Sleep(900);
            g.DrawString("In illustrations of Aquila \n that represent it as an eagle, \n a nearly straight line of three \n stars symbolizes part of the wings. \n The center and brightest of \n these three stars is Altair. \n The tips of the wings extend \n further to the southeast \n and northwest. \n The head of the eagle stretches \n off to the southwest.", drawFont, drawBrush, 367, 285);
            Thread.Sleep(900);
        }
        
    }
}
