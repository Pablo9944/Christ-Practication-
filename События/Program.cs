using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace События
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc1 = new MyClass();
            mc1.myEvent += Handler1;
            mc1.myEvent += Handler2;
            mc1.InvokeEvent();
        }
        static private void Handler1()
        {
            Console.WriteLine("Обрабочтик события 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Обрабочтик события 2");
        }
    }
}
public delegate void EventDelegate();
class MyClass
{
    public event EventDelegate myEvent;

    public void InvokeEvent()
    {
        myEvent.Invoke();
    }
}

