using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            uint inputRows = uint.Parse(Console.ReadLine());

            string cypherString = "", currString, prevString = "";
            string concatMode = "NormalMode";

            while (inputRows > 0)
            {
                currString = Console.ReadLine();

                if (prevString == currString)
                {
                    cypherString = string.Empty;

                    if (prevString != "spin")
                        inputRows--;

                    continue;
                }

                if (currString != "spin")
                    inputRows--;

                else
                {
                    if (concatMode == "SpinMode")
                        concatMode = "NormalMode";

                    else
                        concatMode = "SpinMode";

                    prevString = currString;
                    continue;
                }

                switch (concatMode)
                {
                    case ("NormalMode"):
                        cypherString = cypherString + currString;
                        break;

                    case ("SpinMode"):
                        cypherString = currString + cypherString;
                        break;
                }

                prevString = currString;

            }
            Console.WriteLine(cypherString);
        }
    }
}
