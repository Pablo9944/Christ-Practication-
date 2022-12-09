using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лямбда_выражение_Byte__
{
    public delegate void DelegatVoid(); 
    public delegate string DelegatString(string s);
    public delegate bool DelegateTwoParametrs(int a,int b);


    internal class Program
    {
        List<string> list = new List<string>();
        static void Main(string[] args)
        {
            DelegatVoid dv = () => Console.WriteLine("public delegate void DelegatVoid();");
            dv.Invoke();

            Console.WriteLine();
            Console.WriteLine(new string('$', 100));

            DelegatString ds = (s) =>
            {
                Console.WriteLine("\npublic delegate string DelegatString(string s);");
                return s;
            };

            ds.Invoke(" ");

            Console.WriteLine();
            Console.WriteLine(new string('$', 100));
            Console.WriteLine();

            DelegateTwoParametrs dtp = (a, b) => a < b;
            Console.WriteLine("public delegate bool DelegateTwoParametrs(int a,int b);");
            dtp.Invoke(1, 3);

           
        }

     
  

    }
}
