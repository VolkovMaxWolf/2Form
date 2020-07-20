using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2Form
{
    public partial class Form1 : Form
    {
        private const int PIX_IN_ONE = 20;
        private const int Ox = 8 * PIX_IN_ONE; 
        private const int Oy = 12 * PIX_IN_ONE; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Сheck(textBox1.Text) && textBox2.Text != "" && Сheck(textBox2.Text))
            {
                Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graphics = Graphics.FromImage(btm);
                Pen pen = new Pen(Brushes.Black);
                Pen pen1 = new Pen(Brushes.DarkGray);


                int ver = 0;
                while (ver < pictureBox1.Width)
                {
                    graphics.DrawLine(pen1, ver, 0, ver, pictureBox1.Height);
                    ver += PIX_IN_ONE;
                }

                int gor = 0;
                while (gor < pictureBox1.Height)
                {
                    graphics.DrawLine(pen1, 0, gor, pictureBox1.Width, gor);
                    gor += PIX_IN_ONE;
                }

                
                graphics.DrawLine(pen, 8 * PIX_IN_ONE, 0, 8 * PIX_IN_ONE, pictureBox1.Height);

                
                graphics.DrawLine(pen, 0, 12 * PIX_IN_ONE, pictureBox1.Width, 12 * PIX_IN_ONE);
                
                graphics.DrawLine(pen, Ox + 10 * PIX_IN_ONE, Oy, Ox + 10 * PIX_IN_ONE, Oy - 5 * PIX_IN_ONE);
                
                graphics.DrawLine(pen, Ox , Oy - 5 * PIX_IN_ONE, Ox + 10 * PIX_IN_ONE, Oy - 5 * PIX_IN_ONE);

                

                int step = 10;

                for (int i = 0; i < 20; i++)
                {
                    graphics.DrawLine(pen, Ox + step, Oy, Ox + step, Oy - 5 * PIX_IN_ONE);
                    step += 10;
                }
                step = 10;
                for (int i = 0; i < 10; i++)
                {
                    graphics.DrawLine(pen, Ox, Oy - 5 * PIX_IN_ONE + step, Ox + 10 * PIX_IN_ONE, Oy - 5 * PIX_IN_ONE + step);
                    step += 10;
                }
                graphics.FillEllipse(Brushes.Red, Ox + (Convert.ToInt32(textBox1.Text) * PIX_IN_ONE) - 5, Oy - (Convert.ToInt32(textBox2.Text) * PIX_IN_ONE) - 5, 10, 10);

                textBox3.Text = CheckCoordinates(float.Parse(textBox1.Text), float.Parse(textBox2.Text));

                pictureBox1.Image = btm;

            }
        }
        private bool Сheck(String s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]) && arr[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }
        private String CheckCoordinates(float x, float y)
        {
            if (x > 0 && x < 10 && y > 0 && y < 5) return "Да";
            else if (x < 0 || x > 10 || y < 0 || y > 5) return "Нет";
            else return "На границе";
        }
    }
}
