using System;
using static Sai_Assignment1.Program;

namespace Sai_Assignment1
{
    public static class TriangleSolver
    {
        public static string Analyze(Sides sides)
        {
            String result = null;
            int a = sides.a;
            int b = sides.b;
            int c = sides.c;

            result =  checkIfTriangle(a,b,c);
            
            return result;
        }

        private static String checkIfTriangle(int a, int b, int c)
        {
            String result = null;
            if (a + b > c &&
                b + c > a &&
                c + a > b)
            {
               

                result = "Sides form a Triangle\n";
                

                result = checkTypeOfTriangle(a, b, c, result);

            }
            else
            {
                result = "Sides doesn't form a Triangle\n";
                
            }

            return result;
        }

        private static String checkTypeOfTriangle(int a, int b, int c, string result)
        {
            if (a == b && b == c)
            {
                result += "Triangle is Equilateral\n";
                
            }
            else if (a == b || b == c || c == a)
            {
                result += "Triangle is Isosceles\n";
               
            }
            else
            {
                result += "Triangle is Scalene\n";
                
            }
            return result;
        }
    }
}
