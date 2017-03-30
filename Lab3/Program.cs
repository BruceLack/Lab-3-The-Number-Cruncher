using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Cruncher. Enter an integer and the Cruncher will crunch.");
                for (int startNum = int.Parse(Console.ReadLine()); startNum>0; startNum--)
                {
                    Console.WriteLine("Number = " + startNum + "    Squared = " + SquareNum(startNum)+ "     Cubed = " + CubeNum(startNum));
                }
                
                run = Continue();
            }
        }
        public static int SquareNum(int startNum)
        {
            int squareNum = (startNum * startNum);
            return squareNum;
        }
        public static int CubeNum(int startNum)
        {
            int cubeNum = (startNum * startNum * startNum);
            return cubeNum;
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Keep Crunching? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("Thanks for making the Cruncher the premier name in number-crunching since 3/29/2017!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("The Cruncher did not understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
