using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45_WFControls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (perimeterRB.Checked) resultL.Text = Math.Round(2 * (float)Math.PI * float.Parse(textBox4.Text), 2).ToString();
            else if (areaRB.Checked) resultL.Text = Math.Round((float)Math.PI * Math.Pow(float.Parse(textBox4.Text), 2), 2).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(textBox5.Text) && textBox5.Text != "") listBox1.Items.Add(textBox5.Text);
            textBox5.Clear();
        }
    }
}
