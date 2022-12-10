using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = null;
            int? number1 = null;
            int? number2 = null;

            int? number3 = number1 + number2 + n;

            number1 = number2 ?? 10;
            Console.WriteLine(number1);


        }
    }
}
