using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace password_generator
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        Stopwatch stopwatch;

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2Button1.Text == "Start")
            {
                stopwatch.Start();

                guna2Button1.Text = "Stop";
                    
                    }
            else {
                stopwatch.Stop();
                guna2Button1.Text = "Start";
                    }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            stopwatch.Reset();
            guna2Button1.Text = "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopwatch.Elapsed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }
    }
}
