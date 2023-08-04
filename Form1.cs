using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Percent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            float amount = float.Parse(numericUpDown1.Value.ToString());
            float percent = float.Parse(numericUpDown2.Value.ToString());
            int times = int.Parse(numericUpDown3.Value.ToString());
            if ((amount == 0) || (percent == 0) || (times == 0))
            {
                if ((amount == 0) && (percent == 0) && (times == 0))
                {
                    numericUpDown1.BackColor = Color.Red;
                    numericUpDown2.BackColor = Color.Red;
                    numericUpDown3.BackColor = Color.Red;                    
                }
                if ((amount == 0) || (percent == 0) || (times == 0))
                {
                    if (amount == 0)
                    {
                        numericUpDown1.BackColor = Color.Red;
                    }
                    else
                    {
                        numericUpDown1.BackColor = Color.DarkGray;
                    }
                    if (percent == 0)
                    {
                        numericUpDown2.BackColor = Color.Red;
                    }
                    else
                    {
                        numericUpDown2.BackColor = Color.DarkGray;
                    }
                    if (times == 0)
                    {
                        numericUpDown3.BackColor = Color.Red;
                    }
                    else
                    {
                        numericUpDown3.BackColor = Color.DarkGray;
                    }
                }
                MessageBox.Show("Всі поля повинні мати значення, більші за нуль");
            }
            else
            {
                numericUpDown1.BackColor = Color.DarkGray;
                numericUpDown2.BackColor = Color.DarkGray;
                numericUpDown3.BackColor = Color.DarkGray;
                float plused;
                for (int i = 0; i < times; i++)
                {
                    plused = (amount / 100) * percent;
                    amount += plused;
                    string result = String.Format("{0:f3}", amount);
                    string result2 = String.Format("{0:f}", plused);
                    textBox1.Text += $"{i + 1 + "-ий",9}: {result,20}       Дохід : {result2,20}" + Environment.NewLine;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
