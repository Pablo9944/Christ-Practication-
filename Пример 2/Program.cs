using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            ShowMessage show = Show;
            student.Move(5, show);
        }
        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}

public delegate void ShowMessage(string message);

public class Student
{
    public void Move(int distance,ShowMessage show)
    {
        for (int i = 0; i < distance; i++)
        {
            show($"Пройдено {i} метров "); 
        }
    }
}
