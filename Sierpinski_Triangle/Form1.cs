using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sierpinski_Triangle
{
    public partial class Form1 : Form
    {
        public float dotWidth;

        public Form1()
        {
            InitializeComponent();
        }


        List<PointF> Corners;

        PointF LastPoint;

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (numericUpDownDotAmount.Value == 0)
                timerDraw.Enabled = true;
            else
                timerDraw_Tick(sender, e);
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
        }

        private void DefineCorners()
        {
            Corners = new List<PointF>();
            Corners.Add(new PointF(pictureBoxScreen.Width / 2, 10));
            Corners.Add(new PointF(10, pictureBoxScreen.Height - 10));
            Corners.Add(new PointF(pictureBoxScreen.Width - 10, pictureBoxScreen.ClientSize.Height - 10));


            LastPoint = Corners[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DefineCorners();
            numericUpDownDotSpeed_ValueChanged(sender, e);
            comboBoxColor.SelectedIndex = 0;
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {

                if(numericUpDownDotAmount.Value == 0)
                    for (int i = 1; i <= 1000; i++)
                    {
                    int j = rand.Next(0, 3);
                    LastPoint = new PointF(
                        (LastPoint.X + Corners[j].X) / 2,
                        (LastPoint.Y + Corners[j].Y) / 2);
                    Pen pen = new Pen(Color.FromName(comboBoxColor.SelectedItem.ToString()), dotWidth);
                    gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y,
                        dotWidth, dotWidth);
                    }
                else
                    for (int i = 1; i <= numericUpDownDotAmount.Value; i++)
                    {
                        int j = rand.Next(0, 3);
                        LastPoint = new PointF(
                            (LastPoint.X + Corners[j].X) / 2,
                            (LastPoint.Y + Corners[j].Y) / 2);
                        Pen pen = new Pen(Color.FromName(comboBoxColor.SelectedItem.ToString()), dotWidth);
                        gr.DrawEllipse(pen, LastPoint.X, LastPoint.Y,
                            dotWidth, dotWidth);
                    }
            }
        }

        private void pictureBoxScreen_Resize(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
            DefineCorners();

            //using (Graphics gr = pictureBoxScreen.CreateGraphics())
            //{
            //    gr.Clear(this.BackColor);
            //}
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerDraw.Enabled = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            using (Graphics gr = pictureBoxScreen.CreateGraphics())
            {
                gr.Clear(this.BackColor);
            }
            timerDraw.Enabled = false;
        }

        private void numericUpDownDotSpeed_ValueChanged(object sender, EventArgs e)
        {
            timerDraw.Interval = Convert.ToInt16(numericUpDownDotSpeed.Value);
        }

        private void numericUpDownDotWidth_ValueChanged(object sender, EventArgs e)
        {
            dotWidth = Convert.ToInt64(numericUpDownDotWidth.Value);
        }
    }
}
