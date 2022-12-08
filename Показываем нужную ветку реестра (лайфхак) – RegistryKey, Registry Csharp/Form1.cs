using Microsoft.Win32;
using System.Diagnostics;

namespace Показываем_нужную_ветку_реестра__лайфхак____RegistryKey__Registry_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {   // Путь где реестр сохраняет где мы были в последний раз
            //SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit

            // Как завершить любой системный процесс
            foreach (Process process in Process.GetProcessesByName("regedit"))
            {
                process.Kill();
            }


            string path = @"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor";
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit")
                .SetValue("LastKey",path);

            Process.Start("regedit");
        }
    }
}