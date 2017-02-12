using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)people / 24);

            Console.WriteLine(courses);

            //if (people % 24 == 0)
            //{
            //    Console.WriteLine(people / 24);
            //}
            //else
            //{
            //    double people24 = people / 24;
            //    Console.WriteLine(Math.Round((people24), 0) + 1);
            //}
        }
    }
}
