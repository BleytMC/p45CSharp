namespace _50_WFHM
{
    public partial class Form1 : Form
    {
        int leftButton = 0;
        int rightButton = 0;
        int middleButton = 0;

        DateTime birthday = new DateTime(2026, 05, 19);

        bool isClosing = false;
        int timeToClose = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    leftButton++;
                    break;

                case MouseButtons.Right:
                    rightButton++;
                    break;

                case MouseButtons.Middle:
                    middleButton++;
                    break;
            }

            label1.Text = $"Left Button - {leftButton}\nRight Button - {rightButton}\nMiddle Button - {middleButton}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan difference = birthday - DateTime.Now;
            label2.Text = difference.TotalSeconds.ToString();

            if (isClosing && timeToClose > 0)
            {
                timeToClose--;
                button1.Text = timeToClose.ToString();
            }
            if (timeToClose <= 0) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isClosing) isClosing = true;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < 30) button2.Top += e.Y + 5;
            else button2.Top -= 60 - e.Y + 5;

            if (e.X < 50) button2.Left += e.X + 5;
            else button2.Left -= 100 - e.X + 5;
        }
    }
}
