using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //賽車 F1 = new 賽車();
            ICar F1 = new 賽車();
            F1.加速(100);
            ((賽車)F1).打方向燈();
        }
    }
}