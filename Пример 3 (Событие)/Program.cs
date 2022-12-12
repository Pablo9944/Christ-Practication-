using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_3__Событие_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeyBoardMaster keyBoardMaster = new KeyBoardMaster();
            keyBoardMaster.sKeyPressedEvent += buttonS_Click;
            keyBoardMaster.wKeyPressedEvent += buttonW_Click;
            keyBoardMaster.stopEvent += button_Stop;

            string text = "";

            bool check = true;
            while (check)
            {
                Console.Write("Нажмите кнопку: ");
                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                { 
                    case ConsoleKey.S:
                        if (text.Length != 3)
                        {
                            keyBoardMaster.SKeyPressedEnet();
                            text += ConsoleKey.S;
                        }
                        else
                        keyBoardMaster.StopEvent();
                        break;
                    case ConsoleKey.W:
                        keyBoardMaster.WKeyPressedEnet();
                        break;
                    case ConsoleKey.Q:
                        check = false;
                        Console.WriteLine($"\n{text}");
                        break;
                    default:
                        break;
                }
            }
        }
        static private void buttonW_Click()
        {
            Console.WriteLine("\nВперёд");
        }
        static private void buttonS_Click()
        {
            Console.WriteLine("\nНазад");
        }
        static private void button_Stop()
        {
            Console.WriteLine("\nОстановил");
        }

    }
}public delegate void KeyPressEventDelegate();
public class KeyBoardMaster
{
    public event KeyPressEventDelegate wKeyPressedEvent;
    public event KeyPressEventDelegate sKeyPressedEvent;
    public event KeyPressEventDelegate stopEvent;

    public void WKeyPressedEnet()
    {
        if (wKeyPressedEvent !=null)
            wKeyPressedEvent.Invoke();
    }
    public void SKeyPressedEnet()
    {
        if (sKeyPressedEvent != null)
            sKeyPressedEvent.Invoke();
    }
    public void StopEvent()
    {
        if (stopEvent != null)
            stopEvent.Invoke();
    }
}
