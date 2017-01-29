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
        int speed = 0;
        int floorsize = 20;
        Random rf = new Random();
        
            
  
        public Form1()
        {
            InitializeComponent();
            int randfloor = rf.Next(0, 19);
            pictureBox2.Location = new Point(14, randfloor * floorsize + 12);

          
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pen fp = new Pen(Color.IndianRed, 1);
            System.Drawing.Graphics person = this.CreateGraphics();
            Image per = Image.FromFile(@"C:\Users\advar\Desktop\per.png");
            person.DrawImage(per, 50, 50);
            Pen p = new Pen(Color.Black, 2);
            System.Drawing.Graphics line = this.CreateGraphics();
            for (int i = 0; i <= 20; i++)
            {
                line.DrawLine(p, 28, 12 + i * 20, 54, 12 + i * 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            speed = 1;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y <= 412-20)
                pictureBox2.Top += speed;
            else timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
