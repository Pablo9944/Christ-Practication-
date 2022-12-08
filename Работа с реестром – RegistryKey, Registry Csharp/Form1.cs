using Microsoft.Win32;

namespace Работа_с_реестром___RegistryKey__Registry_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region удаляем регистр "по умолчанию" Но он не удаляется,а становится каким был по умолчанию

            //key.DeleteValue("");

            #endregion

            #region меняем регистру "по умолчанию" значение

            //key.SetValue("", "путь");

            #endregion


            #region открываем реест по пути (считываем,создаем) (Если файла не окажется то будет ошибка поэтому лучше импользовать не CreateSubKey,а OpenSubKey)
            // Считываем (если будет работа с несколькими реестрами) (если нет это реестра не будет ошибки)
            // открывает
            // RegistryKey key =  Registry.CurrentUser.OpenSubKey(@"SOFTWARE\drpsu");

            // или              // открывает
            //Registry.CurrentUser.OpenSubKey(@"SOFTWARE\drpsu");

            //создает 
            // Registry.CurrentUser.CreateSubKey(@"SOFTWARE\drpsu");
            #endregion

            #region создаем реестр,удаляем реестр с именем и получаем значение реестра

            //создаем реестр
            //key.SetValue("Parametr", "что то тут интересное"); //(ctrl+D) - копирует строку

            // удаляем реестр с именем
            //key.DeleteValue("Parametr");

            // получаем значение реестра
            //label1.Text = key.GetValue("clientId").ToString();


            #endregion


            #region Удаляем раздел 

            //1 Сначала создаем
            //Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Delete").SetValue("delete","удалить");

            //2 Удаляем 
            // Registry.CurrentUser.DeleteSubKey(@"SOFTWARE\Delete");

            // 3 Удалить всё дерево (что в разделе)
            //Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\Delete");

            #endregion

            #region  OpenSubKey (просто открывает) Получаем имена разделов,реестров

            //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\8322898"))
            //       label1.Text = key.GetValue("7168").ToString();

            //RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\drpsu");

            //                     // получаем имена реестров  
            //string[] namereestr = key.GetValueNames();
            //Array.Sort(namereestr);

            //foreach (string name in namereestr)
            //{
            //    label1.Text += name + "\n";
            //}


            //RegistryKey key_razdel = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\");
            //                            // получаем имена разделов 
            //string[] namerazdel = key_razdel.GetSubKeyNames();
            //foreach (string name in namerazdel)
            //{
            //    label2.Text += name + "\n";
            //}


            #endregion

            #region А если нет у нас программы что делать....?

            // 1 Вариант но можно короче
            //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Моя программа"))
            //{
            //    if(key!=null)
            //    {
            //        if (key.GetValue("Параметр") != null)
            //        {
            //            label1.Text = key.GetValue("Параметр").ToString();
            //        }
            //    }
            //}


            // 2 Вариант короче но сложнее читать=)

            //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Моя программа"))
            //{
            //    label1.Text = key == null && key.GetValue("Параметр") == null ? key.GetValue("Параметр").ToString(): "" ;
            //}

            // 3 Вариант короче (?.)

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Моя программа"))
            {
                label1.Text = key?.GetValue("Параметр")?.ToString();
            }
            #endregion

        }
    }
}