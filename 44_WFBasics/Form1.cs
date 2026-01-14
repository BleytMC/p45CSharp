namespace _44_WFBasics
{
    public partial class Form1 : Form
    {
        int count = 0;

        Point lastLocation;

        public Form1()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            DateTime dateAfterWeek = new DateTime(2026, 1, 21);

            TimeSpan difference = dateAfterWeek - now;
            MessageBox.Show(difference.TotalDays.ToString());

            //DialogResult result = MessageBox.Show("Test", "Message", MessageBoxButtons.OKCancel);

            //if(result == DialogResult.OK)
            //{
            //    MessageBox.Show("You have clicked OK!");
            //}
            //else if (result == DialogResult.Cancel)
            //{
            //    MessageBox.Show("You have clicked CANCEL!");
            //}


            //DialogResult result = DialogResult.Retry;

            //while (result == DialogResult.Retry)
            //{
            //    result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);
            //}
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Left)
            //{
            //    MessageBox.Show("Left Mouse Button Clicked!", "Message", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
            //}
            //else if (e.Button == MouseButtons.Right) {
            //    MessageBox.Show("You clicked right mouse button!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //}

            //this.Text = count++.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = $"{e.X}, {e.Y}";
            //textLabel.Text = $"{e.X}, {e.Y}";
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Message");

            textLabel.Text = count++.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < 30) button2.Top += e.Y;
            else if(e.Y >= 30) button2.Top -= e.Y - 50;
            if (e.X < 45) button2.Left += e.X;
            else if (e.X >= 45) button2.Left -= e.X - 80;
            label1.Text = e.Location.ToString();
        }
    }
}
