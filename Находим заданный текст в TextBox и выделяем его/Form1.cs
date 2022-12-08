namespace Находим_заданный_текст_в_TextBox_и_выделяем_его
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectionLength = 5;
            textBox1.SelectionStart = 0;
            textBox1.SelectAll();
        }

       
    }
}