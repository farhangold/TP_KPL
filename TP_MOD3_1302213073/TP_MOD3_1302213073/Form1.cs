namespace TP_MOD3_1302213073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            label1.Text = "Hello " + text;
        }
    }
}