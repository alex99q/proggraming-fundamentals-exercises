using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal earthToStar = (decimal)4.22 * 9450000000000;
            decimal earthToCenterMilkyWay = 26000 * 9450000000000;
            decimal diameterMilkyWay = 100000 * 9450000000000;
            decimal earthToEdgeUniverse = (decimal)46500000000 * 9450000000000;

            Console.WriteLine("{0:e2}", earthToStar);
            Console.WriteLine("{0:e2}", earthToCenterMilkyWay);
            Console.WriteLine("{0:e2}", diameterMilkyWay);
            Console.WriteLine("{0:e2}", earthToEdgeUniverse);
        }
    }
}
