using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        int rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < rnd)
            {
                label2.Text = "Too low, try again!";
            }
            else if (int.Parse(textBox1.Text) > rnd)
            {
                label2.Text = "Too high, try again!";
            }
            else
            {
                label2.Text = "You are right!";
                Random random = new Random();
                rnd = random.Next(1, 101);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            rnd = random.Next(1, 101);
        }
    }
}
