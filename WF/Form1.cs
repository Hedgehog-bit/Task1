using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side = double.Parse(this.Input.Text);
            double r = side / Math.Sqrt(3);
            this.Output1.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            double a = double.Parse(this.Input1.Text);
            double b = double.Parse(this.Input2.Text);
            double c = double.Parse(this.Input3.Text);
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                this.Output2.Text = "Треугольник прямоугольный";
            }
            else
                this.Output2.Text = "Треугольник не прямоугольный";
        }
    }
}
