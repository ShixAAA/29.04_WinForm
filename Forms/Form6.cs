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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            double k = Convert.ToDouble(textBox2.Text);
            double p = Convert.ToDouble(textBox3.Text);
            double q = f / k;
            double z = (p / 2) * Math.Sqrt(1 + (1 / (16 / 3 * Math.Pow(q, 2) * (1 + 4 / 3 * Math.Pow(q, 2)))));
            label6.Text = Convert.ToString($"{z:###.##}");
        }
    }
}
