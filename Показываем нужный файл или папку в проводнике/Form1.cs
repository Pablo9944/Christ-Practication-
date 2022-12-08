using System.Diagnostics;

namespace Показываем_нужный_файл_или_папку_в_проводнике
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Pablo\Desktop\Этот компьютер.lnk";
            Cmd(path);
        }

        void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer",Arguments=$"/n,/select,{line}"});
           
        }
    }
}