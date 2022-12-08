using System.Diagnostics;

namespace Лямбда_выражение
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            //foreach (Button button in Controls.OfType<Button>())
            //    button.Click += async (s, e) =>
            //    {
            //        await Task.Delay(1000);
            //        Process.Start("notepad");
            //    };

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            #region Пример
            //label1.Text = Print();
            //label1.Text = Prin();


            //public string Print()
            //{
            //    return "Слово";
            //}
            //public string Prin() => "Слово";

            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Click += (s, e) => 
            //{ 
            //    Process.Start("notepad"); 
            //};
        }
    }
}