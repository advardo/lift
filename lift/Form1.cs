using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lift
{
    public partial class Form1 : Form
    {
        int speed = 1;
        int floorsize = 20;
        Random rf = new Random();
        int xofperson = 25;
        int yofperson = 12;
        int nfloor = 0;
        int liftnow;


        public Form1()
        {
            InitializeComponent();
            int randfloor = rf.Next(0, 19);
            liftnow = randfloor * floorsize + 12;
            pictureBox2.Location = new Point(14, liftnow);



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Pen p = new Pen(Color.Black, 2);
            System.Drawing.Graphics line = this.CreateGraphics();
            for (int i = 0; i <= 20; i++)
            {
                line.DrawLine(p, 28, 12 + i * 20, 54, 12 + i * 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {




        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            timer1.Interval = 10;

            if (pictureBox2.Location.Y != 412 - floorsize * nfloor)
            {
                if (liftnow < 412 - floorsize * nfloor)
                    pictureBox2.Top += speed;
                else pictureBox2.Top -= speed;
            }
            else
            {
                liftnow = 412 - floorsize * nfloor;
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //______________________--------------------------_______________________________________________
        //
        //                        RADIO ----BUTTONS
        //______________________--------------------------_______________________________________________

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 1;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);
            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 2;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton2.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 3;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton3.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 4;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton4.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 5;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton5.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 6;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton6.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 7;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton7.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 8;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton8.Visible = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 9;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton9.Visible = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 10;
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"img\per.png");
            person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);

            timer1.Tick += timer1_Tick;
            timer1.Start();
            radioButton10.Visible = false;
        }
    }
}
