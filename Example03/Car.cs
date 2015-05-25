using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Car : IComparable
    {
        public Car(int 排氣量)
        {
            this.排氣量 = 排氣量;
        }

        public int 排氣量;

        public int CompareTo(object obj)
        {
            Car 另一部車子 = (Car)obj;
            return this.排氣量 - 另一部車子.排氣量;
        }

        public override string ToString()
        {
            return "這部車的排氣量:" + this.排氣量.ToString();
        }
    }
}