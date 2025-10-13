namespace Labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ильин Егор, ИС4-242-ОМ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Label3.Text = "Карташов Александр, ИС4-242-ОМ"
        }
    }
}
