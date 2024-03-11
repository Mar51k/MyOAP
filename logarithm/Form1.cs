using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logarithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double underlog = 0, footlog = 0;
            try
            {
                if((double.Parse(textBox1.Text)) < 1 || (double.Parse(textBox3.Text) < 2)) 
                {
                    MessageBox.Show("Ошибка!");
                    return;
                }
                else
                {
                    underlog = double.Parse(textBox1.Text);
                    footlog = double.Parse(textBox3.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка!");
                return;

            }

            double result = Math.Log(underlog, footlog);
            MessageBox.Show($"{result}", "Результат");

        }
    }
}
