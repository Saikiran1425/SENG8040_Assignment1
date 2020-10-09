using System;
using Sai_Assignment1;
//using TriangleSolver;

namespace Sai_Assignment1
{
    public class Program
    {
        public class Sides {
            public int a, b, c;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("******Menu******\n");
                Console.WriteLine("1. Enter Triangle Dimensions\n2. Exit\n");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    break;
                }
                else if (option != 1) {
                    continue;
                }

                Sides sides = new Sides();
                Console.WriteLine("Enter First side");
                sides.a = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Enter Second side");
                sides.b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Third side");
                sides.c = int.Parse(Console.ReadLine());

                String result = Sai_Assignment1.TriangleSolver.Analyze(sides);
                Console.WriteLine(result);

            }

        }
    }
}
