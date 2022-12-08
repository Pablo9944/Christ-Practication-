using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты_и_события
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass mc = new Myclass();

            CountDelegate cd1 = mc.GetCount;
            CountDelegate cd2 = mc.GetCountSymbolA;


            Console.WriteLine(cd1.Invoke("слово"));
            
            Console.WriteLine(new string('=', 10));
            Console.WriteLine(cd2.Invoke("АбрАмов"));
            
            Console.WriteLine(new string('=', 10));

            CountDelegateSymbolA cd3 = mc.GetCountSymbolA;
            Console.WriteLine(cd3.Invoke("АбрАмченковА", 'А'));


            Console.WriteLine(PrintValue(cd1,"Пример"));

        }
        static int PrintValue(CountDelegate cd,string value)
        {
            Console.WriteLine(new string('=', 10));
            return cd(value);
        }
    }
}
public delegate int CountDelegate(string value);
public delegate int CountDelegateSymbolA(string value, char symbol);

public class Myclass
{
    public int GetCount(string value)
    {
        return value.Length;
    }

    public int GetCountSymbolA(string value)
    {
        return value.Count(a => a == 'А');
    }
    public int GetCountSymbolA(string value, char symbol)
    {
        return value.Count(a => a == symbol);
    }

}
