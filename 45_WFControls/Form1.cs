namespace _45_WFControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Red;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) MessageBox.Show("You have checked the checkBox");
            else MessageBox.Show("You haven't checked the checkBox");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked) MessageBox.Show("Ви хочете піцу");
            else if (checkBox2.CheckState == CheckState.Unchecked) MessageBox.Show("Ви не хочете піцу");
            else MessageBox.Show("Ви можливо хочете піцу");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) MessageBox.Show("Ви чоловік");
            else if (radioButton2.Checked) MessageBox.Show("Ви жінка");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
