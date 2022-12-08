using System.Diagnostics;

namespace Пишем_умный_ланчер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\РАЗЛИЧНЫЕ_ПРОГРАММЫ\FreeMove.exe";

            // запустить службу -  команда
            // Cmd("sc start \"Bonjour Service\"");
            // Cmd("start \"\"\"%programfiles%\\iTunes\\iTunes.exe\"");
            //Cmd("start \"\"\"%programfiles%\\Notepad++\\notepad++.exe\"");
            label1.Text = path;
            Cmd($"start {path}");




        }

        void Cmd(string line)
        {
            #region Команды /c/k/s/q/d/a
            /*
            /C  Выполнение указанной команды (строки) с последующим завершением.
            /K  Выполнение указанной команды (строки) без последующего завершения.
            /S  Изменение поведения после /C или /K (см. ниже)
            /Q  Отключение режима вывода команд на экран (ECHO).
            /D  Отключение выполнения команд AutoRun из реестра (см. ниже)
            /A  Вывод результатов выполнения команд в формате ANSI.
             */
            #endregion
            Process.Start(new ProcessStartInfo { FileName = "cmd", Arguments = $"/c{line}",
             // чтобы не видеть окно                   //Дождаться окончания этого метода
            WindowStyle = ProcessWindowStyle.Hidden}).WaitForExit(); 
        }
    }
}