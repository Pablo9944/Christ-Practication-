using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщенный_делегат
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Action
            //MyClass mc = new MyClass();

            //Action<string> action1 = Action;
            //mc.ActionMethod("Action<string>", action1);

            //Action<int, bool> action2 = Action2Parametrs;
            //mc.ActionMethoTwoParametrs(777, true, action2);

            #endregion

            #region Func

            //Func<int, string> func1 = FuncMethod;
            //mc.FuncMethod(666, func1);

            //string m = "sdsfdsfsd";

            //Console.WriteLine(m);

            #endregion


            #region Событие
            MyClass mc = new MyClass();
            // mc.Moving += mc_Moving;
            // вариаент с обощенным событием
            mc.Moving += mc_Moving;

            mc.Move(7);

            #endregion
        }

        //private static void mc_Moving(object sender, MovingEventArgs e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        private static void mc_Moving(string message)
        {
            Console.WriteLine(message);
        }

        //public static void Action (string message )
        //{
        //    Console.WriteLine(message);
        //}

        //public static void Action2Parametrs(int value, bool flag)
        //{
        //    Console.WriteLine(new string('#', 10));
        //    Console.WriteLine($"Action<{value},{flag}>");
        //}

        //public static string FuncMethod(int value)
        //{
        //    Console.WriteLine(new string('#', 10));
        //    Console.WriteLine(value);
        //    return value.ToString();
        //}

        //public static void Show(string message) 
        //{
        //    Console.WriteLine(message);
        //}

    }

    public delegate void ShowMessage(string message);

    class MovingEventArgs:EventArgs
    {
        public string Message { get; set; }
        public MovingEventArgs(string message)
        {
            Message = message;
        }
    }
    
    class MyClass
    {
        //public event EventHandler<MovingEventArgs> Moving;

        // Можно сделать обобщенное событие
        public event Action<string> Moving;

        public void Move(int distance )
        {
            for (int i = 0; i < distance; i++)
            {
                // Moving(this, new MovingEventArgs($"идёт перемещение {i}")) ;
                Moving("Вариант 2");
            }
        }

    //    public void ActionMethod(string message, Action<string> action)
    //    {
    //        action(message);
    //    }

    //    public void ActionMethoTwoParametrs(int value,bool flag, Action<int,bool> action) 
    //    {
    //        action(value,flag); 
    //    }

    //    public string FuncMethod(int value,Func<int,string> func) 
    //    {
    //        return func(value);
    //    }
    }
}
