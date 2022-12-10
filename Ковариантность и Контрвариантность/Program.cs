using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ковариантность_и_Контрвариантность
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // коварицация обобщений (upcat производного класса Mersedes к базовому классу Car).Для реализации используется out и свойства только для чтнения
            // коварицация обобщений ( downcats производного класса Mersedes к базовому классу Car).Для реализации используется in и свойства только для записи

            #region Простой пример

            //Mersedes mersedes = new Mersedes();
            //IGarage<Car> garage = new Garage<Car>(mersedes);// -2 Upcast(garage к IGarage и mersedec к Car)
            //garage.PrintPlace<Car>();

            #endregion

            #region Ковариантность

            //Mersedes mersedes = new Mersedes();

            //IGarage<Car> garage = new Garage<Mersedes>(mersedes);

            #endregion

            #region Контрвариантность

            Car car = new Mersedes();
            IGarage<Mersedes> garage = new Garage<Car>(car);
            Console.WriteLine(garage.ToString());
            #endregion



        }
    }
}

#region Простой пример

//abstract class Car { }

//class Mersedes : Car { }

//interface IGarage< T>
//{
//    T CarPlace { get; set; }
//    void PrintPlace<T>();

//}

//class Garage<T> : IGarage<T>
//{
//    public T CarPlace { get; set; }

//    public Garage(T car)
//    {
//        CarPlace = car;
//    }

//    public void PrintPlace<T>() => Console.WriteLine(CarPlace);

//}

#endregion 


