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
            #region Огранмичения универсальных классов

            //MyClass<string> mc = new MyClass<string>();
            //MyStruct<int> ms = new MyStruct<int>();
            //Class<TestClass> c = new Class<TestClass>();
            //c.instance.Str = "Проверка";
            //Console.WriteLine(c.instance.Str);

            //MyClass1<Derived> myClass1 = new MyClass1<Derived>();
            //MyClass1<Base> myClass11 = new MyClass1<Base>();
            #endregion

            #region Огранмичения универсальных классов от интерфейсов

            //MyClass1<Derived> mc1 = new MyClass1<Derived>();
            //MyClass2<Derived> mc2 = new MyClass2<Derived>();
            //MyClass3<Derived> mc3 = new MyClass3<Derived>();
            //MyClass1<IInterface> m4 = new MyClass1<IInterface >();


            #endregion

            #region Naked ограничение

            MyClass<Derived, Base> myClass = new MyClass<Derived, Base>();


            #endregion

        }
    }
}

#region class MyClass<T> where T : class
//class MyClass<T> where T : class
//{
//    public T class_field { get; set; }
//}
#endregion

#region  class MyStruct<T> where T : struct

//class MyStruct<T> where T : struct
//{
//    public T struct_field { get; set; }
//}

#endregion

#region class Class<T> where T : new()

//class Class<T> where T : new()
//{
//    public T instance { get; set; } = new T(); // имя типа подставляется и вместо типа и вместо имени конструктора
//}
//class TestClass
//{
//    public string  Str { get; set; }
//    public override string ToString()
//    {
//        return $"Str value {Str}";
//    }
//}

#endregion

#region  class<T> where T : Base

//class Base  
//{

//}
//class Derived:Base
//{

//}

//class MyClass1<T> where T:Base
//{

//}
#endregion

#region Огранмичения универсальных классов от интерфейсов

//interface IInterface { }
//interface IInterface<P> { }
//class Derived : IInterface, IInterface<int> { }

//class MyClass1<T> where T : IInterface { }
//class MyClass2<T> where T : IInterface<int> { }

//class MyClass3<T> where T: IInterface, IInterface<int> { }

#endregion





#region Naked ограничение

class Base { }
class Derived : Base { }

class MyClass<T,P> where T:P
{

}


#endregion



