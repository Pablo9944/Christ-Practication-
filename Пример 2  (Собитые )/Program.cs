using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_2___Собитые__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyEvent += Handler1;
            instance.MyEvent += Handler2;
            instance.InvokeEvent();
        }
        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }
    }
    
}
public delegate void EventDelegate();
class MyClass
{
    EventDelegate myEvent;

    public event EventDelegate MyEvent
    {
        add { myEvent += value; }
        remove { myEvent -= value; }
    }
    public void InvokeEvent()
    {
        myEvent.Invoke();
    }
}  