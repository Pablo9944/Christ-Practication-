using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анонимные_методы
{
    public delegate void Anonim();
    public delegate string AnonimString(string s);

    internal class Program
    {
        static void Main(string[] args)
        {
            Anonim anonim = delegate
            {
                Console.WriteLine("Анонимный метод");
            };

            anonim();

            AnonimString anonim1 = delegate (string s)
            {
                Console.WriteLine(s);
                return s;
            };

            string result = anonim1("Анонимный метод с принимаемый и возвращаемой значением");
        }
    }
}
