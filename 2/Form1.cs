using System.Net;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Pablo\Desktop\Обучение.txt";
            //string newFile = @"C:\Users\Pablo\Desktop\Христ\1.txt";

            //File.Copy(path,newFile.Replace("1","newFile"),true);
            //                                                     // Освобождает ресурсы
            //File.Create(@"C:\Users\Pablo\Desktop\Христ\create.txt").Dispose();
            //File.WriteAllText(newFile.Replace("1","Записанный файл"), "РОН-ДОН-ДОН");

            // Создал новую Форму
            //WinCool cool = new WinCool();
            //cool.Show();

            //WebClient wc = new WebClient();
            //wc.DownloadFile();


            // ВАРИАНТ 1

            //FileStream fs = new FileStream(path,FileMode.Append);
            //StreamWriter stream = new StreamWriter(fs);
            //stream.WriteLine("РОН-ДОН-ДОН");
            
            //stream.Close();
            //fs.Close();

            // СОКРАЩЁННЫЙ ВАРИАНТ (заканчивает поток,освобождает поток )
            //using (FileStream fs = new FileStream(path, FileMode.Append))
                using (StreamWriter write = new StreamWriter(path,true))
                    for (int i = 0; i < 10; i++)
                         write.WriteLine($"РОН-ДОН-ДОН{i}");
                   

            using (StreamReader reade = new StreamReader(path))
                MessageBox.Show(reade.ReadToEnd());
                
             


        }
       
      
    }
} 