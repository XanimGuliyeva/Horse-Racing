using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random texmini = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int soldanuzaqliq1 = pictureBox1.Left;
            int soldanuzaqliq2 = pictureBox2.Left;
            int soldanuzaqliq3 = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int geniwlik1 = pictureBox1.Width;
            int geniwlik2 = pictureBox2.Width;
            int geniwlik3 = pictureBox3.Width;

            int bitiwxetti = label5.Left;

            int timer = Convert.ToInt32(label7.Text);
            timer++;
            label7.Text = timer.ToString();

            pictureBox1.Left= pictureBox1.Left + texmini.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + texmini.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + texmini.Next(5, 15);
            if (pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+5)
            {
                label6.Text = ("Birinci At Ondedir");
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = ("Ikinci At Ondedir");
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = ("Birinci At Ondedir");
            }

            if (geniwlik1+pictureBox1.Left>bitiwxetti)
            {
                timer1.Enabled = false;
                label6.Text = ("Birinci At Qalibdir");
            }
            if (geniwlik2+pictureBox2.Left>bitiwxetti)
            {
                timer1.Enabled = false;
                label6.Text = ("Ikinci At Qalibdir");
            }
            if (geniwlik3+pictureBox3.Left>bitiwxetti)
            {
                timer1.Enabled = false;
                label6.Text = ("Ucuncu At Qalibdir");
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }
    }
}
