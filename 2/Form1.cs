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
            string path = @"C:\Users\Pablo\Desktop\��������.txt";
            //string newFile = @"C:\Users\Pablo\Desktop\�����\1.txt";

            //File.Copy(path,newFile.Replace("1","newFile"),true);
            //                                                     // ����������� �������
            //File.Create(@"C:\Users\Pablo\Desktop\�����\create.txt").Dispose();
            //File.WriteAllText(newFile.Replace("1","���������� ����"), "���-���-���");

            // ������ ����� �����
            //WinCool cool = new WinCool();
            //cool.Show();

            //WebClient wc = new WebClient();
            //wc.DownloadFile();


            // ������� 1

            //FileStream fs = new FileStream(path,FileMode.Append);
            //StreamWriter stream = new StreamWriter(fs);
            //stream.WriteLine("���-���-���");
            
            //stream.Close();
            //fs.Close();

            // �����٨���� ������� (����������� �����,����������� ����� )
            //using (FileStream fs = new FileStream(path, FileMode.Append))
                using (StreamWriter write = new StreamWriter(path,true))
                    for (int i = 0; i < 10; i++)
                         write.WriteLine($"���-���-���{i}");
                   

            using (StreamReader reade = new StreamReader(path))
                MessageBox.Show(reade.ReadToEnd());
                
             


        }
       
      
    }
} 