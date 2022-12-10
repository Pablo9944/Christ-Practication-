using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ограничения_универсальных_типов.where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<string>mc = new MyClass<string> ();
            MyStruct<int> ms = new MyStruct<int>();
            Class<TestClass> c = new Class<TestClass>();
        }
    }
}

class MyClass<T> where T : class
{
    public T class_field { get; set; }
}
class MyStruct<T> where T:struct
{
    public T struct_field { get; set; }
}

class Class<T> where T: new()
{
    
}
class TestClass
{

}