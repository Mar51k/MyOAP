using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string f = textBox1.Text;
            int c = Convert.ToInt32(textBox2.Text);
            int c1 = Convert.ToInt32(textBox3.Text);

            dateTimePicker2.MaxDate = DateTime.Now;
            DateTime dt1 = dateTimePicker2.Value;
            DateTime dt2 = DateTime.Now;

            int d = (dt2.Year - dt1.Year) * 365;
            string s = "Вы " + f;
            listBox1.Items.Add(s);

            s = Convert.ToString(d);
            s = "Вы прожили " + s + " дней";
            listBox1.Items.Add(s);

            s = Convert.ToString(c1);
            s = "Вы хотите учиться ещё " + s + " дней";
            listBox1.Items.Add(s);

            dt1 = dt1.AddDays(c1);
            s = "Вы станете очень умным " + dt1;
            listBox1.Items.Add(s);

            s = Convert.ToString(dt1.DayOfWeek);
            s = "Это будет в " + s;
            listBox1.Items.Add(s);

            s = "Если вы не поняли, подучите английский :)";
            listBox1.Items.Add(s);

            int year = Convert.ToInt32(textBox5.Text);
            listBox1.Items.Add(year);

            

            int day = Convert.ToInt32(textBox4.Text);
            var date = new DateTime(year);
            date = date.AddDays(day);
            listBox1.Items.Add(date.ToString("M"));

            

        }
    }
}
