using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ковариантность_и_Контрвариантность
{
    abstract class Car { }
    class Mersedes : Car { }

    interface IGarage<in T>
    {
        T CarPlace { set; }
    }
    class Garage<T> : IGarage<T>
    {
        T carplace;
        public Garage(T car)
        {
            carplace = car;
        }

        public T CarPlace
        {
            set
            {
               carplace = value;
            }
        }

        public override string ToString()
        {
            return carplace.ToString();
        }
    }
}
