using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.05;
        const double dt = 0.01;
        double t;
        int day = 1;

        double rate1, rate2;

        Random random = new Random();
        private void btPredict_Click(object sender, EventArgs e)
        {
            rate1 = (double)zxcDollar.Value;
            rate2 = (double)zxcEuro.Value;

            t = 0;

            if (graphic.Series[0].Points.Count == 0 && graphic.Series[1].Points.Count == 0)
            {
                rate1 = (double)zxcDollar.Value;
                rate2 = (double)zxcEuro.Value;

                graphic.Series[0].Points.Clear();
                graphic.Series[1].Points.Clear();
                graphic.Series[0].Points.AddXY(0, rate1);
                graphic.Series[1].Points.AddXY(0, rate2);

                timer1.Start();
            }
            else
            {
                if (timer1.Enabled == true)
                {
                    timer1.Stop();
                }
                else timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            day++;
            t += dt;
            rate1 = rate1 * (1 + k * (random.NextDouble() - 0.5));
            graphic.Series[0].Points.AddXY(day, rate1);
            rate2 = rate2 * (1 + k * (random.NextDouble() - 0.5));
            graphic.Series[1].Points.AddXY(day, rate2);
        }
    }
}
