using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace line_algo
{
    public partial class Form1 : Form
    {
        public void ddaline(Point p1, Point p2)
        {
            int k ;
            double xinc, yinc, x, x1, y, y1, steps;

            Bitmap p = new Bitmap(this.Width, this.Height);
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            if (deltaX > deltaY) steps = deltaX;
            else steps = deltaY;
            xinc = deltaX / steps;
            yinc = deltaY / steps;
            x = x1 = p1.X;
            y = y1 = p1.Y;

            //casting

            p.SetPixel((int)x, (int)y, Color.Red);


            // k1 steps
            
            for (k = 1; k <= steps; k++)
            {
                x = x + xinc;
                x = Math.Round(x, 0);

                y = y + yinc;
                y = Math.Round(y, 0);

                p.SetPixel((int)x, (int)y, Color.Red );
                 


            }
            
            picture.Image = p;

        }
        /// <summary>
         
        public void bresenham (Point p1 , Point p2 )
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.X;
            int x, y;
            Bitmap po = new Bitmap(this.Width, this.Height);
            int p = 2 * deltaY - deltaX;
            int twoDy = 2 * deltaY;
            int twoDyMinusDx = 2 * (deltaY - deltaX);

            if (p1.X > p2.X)
            {
                x = p2.X;
                y = p2.Y;
                p2.X = p1.X;
            }
            else { x = p1.X;
                y = p1.Y;
            }

            po.SetPixel((int)x, (int)y, Color.Red);

            while(x < p2.X)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;

                }

                po.SetPixel((int)x, (int)y, Color.Green);

            }

            picture2.Image = po;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(text_X1.Text);
            int y1 = Convert.ToInt32(text_Y1.Text);

            int x2 = Convert.ToInt32(text_X2.Text);
            int y2 = Convert.ToInt32(text_Y2.Text);


            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            // call DDA_fun

            //ddaline(p1,p2);
            ddaline(p1, p2);


        }



        

        private void panel_DDA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(text_X1.Text);
            int y1 = Convert.ToInt32(text_Y1.Text);

            int x2 = Convert.ToInt32(text_X2.Text);
            int y2 = Convert.ToInt32(text_Y2.Text);


            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            // call DDA_fun

            //ddaline(p1,p2);
            bresenham(p1, p2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
