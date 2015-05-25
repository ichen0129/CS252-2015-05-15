using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class 賽車 : ICar
    {
        public void 加速(int 加速度)
        {
            Console.WriteLine("現在加速{0}", 加速度);
        }

        public void 減速度(int 減速度)
        {
            Console.WriteLine("現在減速{0}", 減速度);
        }

        public void 打方向燈()
        {
        }
    }
}