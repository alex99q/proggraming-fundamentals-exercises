using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());

            //Checks what data type is a
            string typeOfa = "";

            if (byte.MinValue <= a && a <= byte.MaxValue)
            {
                typeOfa = "byte";
            }
            else if (ushort.MinValue <= a && a <= ushort.MaxValue)
            {
                typeOfa = "ushort";
            }
            else if (uint.MinValue <= a && a <= uint.MaxValue)
            {
                typeOfa = "uint";
            }
            else if (ulong.MinValue <= a && a <= ulong.MaxValue)
            {
                typeOfa = "ulong";
            }


            //Checks what data type is b
            string typeOfb = "";

            if (byte.MinValue <= b && b <= byte.MaxValue)
            {
                typeOfb = "byte";
            }
            else if (ushort.MinValue <= b && b <= ushort.MaxValue)
            {
                typeOfb = "ushort";
            }
            else if (uint.MinValue <= b && b <= uint.MaxValue)
            {
                typeOfb = "uint";
            }
            else if (ulong.MinValue <= b && b <= ulong.MaxValue)
            {
                typeOfb = "ulong";
            }

            //output
            ulong biggerNumber = Math.Max(a, b);

            if (biggerNumber == a)
            {
                if(typeOfb == "byte")
                {
                    double result = Math.Round((double)a / byte.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfa}
smaller type: {typeOfb}
{biggerNumber} can overflow {typeOfb} {result} times");
                }
                else if (typeOfb == "ushort")
                {
                    double result = Math.Round((double)a / ushort.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfa}
smaller type: {typeOfb}
{biggerNumber} can overflow {typeOfb} {result} times");
                }
                else if (typeOfb == "uint")
                {
                    double result = Math.Round((double)a / uint.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfa}
smaller type: {typeOfb}
{biggerNumber} can overflow {typeOfb} {result} times");
                }
                else if (typeOfb == "ulong")
                {
                    double result = Math.Round((double)a / ulong.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfa}
smaller type: {typeOfb}
{biggerNumber} can overflow {typeOfb} {result} times");
                }
            }
            else if (biggerNumber == b)
            {
                if (typeOfa == "byte")
                {
                    double result = Math.Round((double)b / byte.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfb}
smaller type: {typeOfa}
{biggerNumber} can overflow {typeOfa} {result} times");
                }
                else if (typeOfa == "ushort")
                {
                    double result = Math.Round((double)b / ushort.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfb}
smaller type: {typeOfa}
{biggerNumber} can overflow {typeOfa} {result} times");
                }
                else if (typeOfa == "uint")
                {
                    double result = Math.Round((double)b / uint.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfb}
smaller type: {typeOfa}
{biggerNumber} can overflow {typeOfa} {result} times");
                }
                else if (typeOfa == "ulong")
                {
                    double result = Math.Round((double)b / ulong.MaxValue);

                    Console.WriteLine($@"bigger type: {typeOfb}
smaller type: {typeOfa}
{biggerNumber} can overflow {typeOfa} {result} times");
                }
            }

        }
    }
}
