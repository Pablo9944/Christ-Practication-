using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Универсальные_типы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<string> mc = new Good<string>("Кукушка накуковала,что Диман ПЕТУХ");
            mc.Print(mc.Value);
            
        }
    }
}
abstract class Student<T>
{
    public T Value { get; set; }
    public Student(T Value)
    {
        this.Value = Value;
    }
    public abstract void Print(T value);
   
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
