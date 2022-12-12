using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковариантность_и_Контравариантность_обобщений__Делегаты_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ковариантность

            //MyDelegate<Mersedes> merDel = MersedeBuilder;
            //MyDelegate<Car> carDel = merDel;
            //Console.WriteLine(carDel().GetType() + " " + merDel().GetType());

            #endregion

            #region Контрвариантность

            //MyDelegate<Car> carDel = MersedeBuilder;
            //MyDelegate<Mersedes> mersedelDel = carDel;
            //carDel(new Car());
            //mersedelDel(new Mersedes());

            #endregion

        }

        #region  метод для Делегата Ковариантность
        static Mersedes MersedeBuilder()
        {
            return new Mersedes();
        }
        #endregion

        #region  метод для Делегата Контрваринатность

        static void MersedeBuilder(Car car)
        {
            Console.WriteLine(car.GetType());
        }
        #endregion


    }
}

#region Коваринатность
//class Car
//{
//  public void Drive() { }
//}
//class Mersedes : Car
//{
// public string ClassName;
//}
//delegate T MyDelegate<out T>();
#endregion

#region Контрвариантность

//class Car
//{
//    public void Drive() { }
//}
//class Mersedes : Car
//{

//}
//delegate void MyDelegate<in T>(T parametr);
#endregion
