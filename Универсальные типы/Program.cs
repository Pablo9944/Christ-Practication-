using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Универсальные_типы
{
    internal class Program
    {
        static readonly string TITLE = "Кукушка накуковала,что Диман ПЕТУХ";
        static void Main(string[] args)
        {
            Student<string> mc = new Good<string>("");
            DelegateUniversal<string,string> du = MessagePrint;
            du.Invoke(TITLE);





        }
        static string MessagePrint(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}

public delegate R DelegateUniversal<T,R>(T s);   
abstract class Student<T>
{
    public T Value { get; set; }
    public Student(T Value)
    {
        this.Value = Value;
    }
    public virtual void Print(T value)
    {
        Console.WriteLine("Print abstract");
    }
   
}
class Good<T>: Student<T>
{
    public T Value { get; set; }
    public override void Print(T value)
    {
        Console.WriteLine(value);
    }
    public Good(T value):base (value)
    {
        Value = value;
    }

}
