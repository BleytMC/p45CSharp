namespace _31_EventsExampleWF
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
            //MessageBox.Show("Button Clicked!");
            BackColor = Color.Brown;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {e.X}, Y: {e.Y}";
        }
    }
}
