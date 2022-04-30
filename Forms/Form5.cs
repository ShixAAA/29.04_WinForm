using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(textBox2.Text);
            double n = Convert.ToDouble(textBox3.Text);
            double V = Convert.ToDouble(textBox5.Text);
            double U = Convert.ToDouble(textBox6.Text);
            double c = ((U-V)/2)*Math.Sin(2*a);
            double z = 0.5 * (m + n + Math.Sqrt(Math.Pow(m - n, 2) + 4 * Math.Pow(c, 2)));
            label8.Text = Convert.ToString($"{z:###.##}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
