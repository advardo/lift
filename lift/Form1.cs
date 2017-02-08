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

namespace lift
{
    public partial class Form1 : Form
    {
        int speed = 1;
        int floorsize = 20;
        Random rf = new Random();
        int nfloor = 0;
        int liftnow;
        bool edem;


        
        public Form1()
        {
            InitializeComponent();
            int randfloor = rf.Next(0, 19);
            liftnow = randfloor * floorsize + 12;
            pictureBox2.Location = new Point(14, liftnow);



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black, 2);
            System.Drawing.Graphics line = this.CreateGraphics();
            for (int i = 0; i <= 20; i++)
            {
                line.DrawLine(p, 28, 12 + i * 20, 54, 12 + i * 20);
            }



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
                Thread.Sleep(2000);

                

                Form2 f = new Form2();
                f.ShowDialog();
                edem = f.go;
                nfloor = Convert.ToInt16(f.label1.Text);
                if (edem) {
                    timer2.Tick -= timer2_Tick;
                    timer2.Tick += timer2_Tick;
                    timer2.Start();
                    edem = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 10;

            if (pictureBox2.Location.Y != 412 - floorsize * nfloor)
            {
                if (liftnow < 412 - floorsize * nfloor)
                    pictureBox2.Top += speed;
                else pictureBox2.Top -= speed;
            }
            else
            {
                liftnow = 412 - floorsize * nfloor;
                timer2.Stop();
                Thread.Sleep(2000);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //______________________--------------------------_______________________________________________
        //
        //                        RADIO ----BUTTONS
        //______________________--------------------------_______________________________________________

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    timer1.Tick -= timer1_Tick;
        //    nfloor = 1;
        //    System.Drawing.Graphics person = this.CreateGraphics();
        //    Image per = Image.FromFile(@"../../Resources/per.png");
        //    person.DrawImage(per, xofperson, yofperson + floorsize * (20 - nfloor), 20, 20);
        //    timer1.Tick += timer1_Tick;
        //    timer1.Start();
        //    radioButton1.Visible = false;
        //}


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 1;
            pictureBox1.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 2;
            pictureBox3.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 3;
            pictureBox4.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 4;
            pictureBox5.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 5;
            pictureBox6.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 6;
            pictureBox7.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 7;
            pictureBox8.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 8;
            pictureBox9.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 9;
            pictureBox10.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            nfloor = 10;
            pictureBox11.Image = lift.Properties.Resources.per;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }
    }
}
