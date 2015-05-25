using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            cars[0] = new Car(2000);
            cars[1] = new Car(1600);
            cars[2] = new Car(3000);
            Array.Sort(cars);
            for (int index = 0; index < 3; index++)
            {
                //Console.WriteLine(cars[index].排氣量);

                //override ToString之後可以改寫為如下
                Console.WriteLine(cars[index]);
            }
        }
    }
}