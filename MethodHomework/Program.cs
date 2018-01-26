using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            int bigNumb = 0;
            Console.WriteLine("The larger number is " + (Numbers(bigNumb)) + "\n");

            int num = 0;
            bool trueOrFalse = NumbersTwo(num);
            Console.WriteLine("The numbers are equal. " + trueOrFalse + "\n");

            string favFood = " ";
            Console.WriteLine("My favorite foods are " + (Foods(favFood)) + "\n");

            int tri = 0;
            Console.WriteLine("The missing side of the triangle is " + (Triangle(tri)));
        }
        //method for question 3
        static string Foods(string n)
        {
            string x = " ";
            int i = 0;
            string[] names = new string[3];

            for (i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name one of your favorite foods ");
                names[i] = Console.ReadLine();
            }

            for (i = 0; i < names.Length; i++)
            {
                x += names[i] + " ";

            }
            return x;
        }
        //method for question 1
        static int Numbers(int num)
        {
            int[] numbers = new int[2];
            int i;
            int j = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number to compare");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            if (numbers[0] > numbers[1])
            {
                j = numbers[0];
            }
            else
            {
                j = numbers[1];
            }
            return j;
        }
        //method for question 2
        static bool NumbersTwo(int equal)
        {
            int[] numbers = new int[2];
            int i;
            bool equal1 = true;
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number to compare");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            if (numbers[0] == numbers[1])
            {
                equal1 = true;
            }
            else
            {
                equal1 = false;
            }
            return equal1;
        }
        //Method for question 4
        static double Triangle(int side)
        {
            double a, b, c;
            string misSide;
            double total = 0;
            double answer = 0;

            Console.WriteLine("Which side are you missing, a, b, or c?");
            misSide = Console.ReadLine().ToLower();

            if (misSide == "a")
            {
                Console.WriteLine("Enter side b");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side c");
                c = int.Parse(Console.ReadLine());

                while (c < b)
                {
                    Console.WriteLine("c must be larger than b");

                    Console.WriteLine("Enter side b");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side c");
                    c = int.Parse(Console.ReadLine());
                }

                b = (b * b); c = (c * c);
                total = (c - b);

                answer = Math.Sqrt(total);
            }
            if (misSide == "b")
            {
                Console.WriteLine("Enter side a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side c");
                c = int.Parse(Console.ReadLine());

                while (c < a)
                {
                    Console.WriteLine("c must be larger than a");

                    Console.WriteLine("Enter side a");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side c");
                    c = int.Parse(Console.ReadLine());
                }
                a = (a * a); c = (c * c);
                total = (c - a);

                answer = Math.Sqrt(total);
            }
            if (misSide == "c")
            {
                Console.WriteLine("Enter side a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side b");
                b = int.Parse(Console.ReadLine());

                a = (a * a); b = (b * b);
                total = a + b;

                answer = Math.Sqrt(total);
            }
            return answer;
        }
    }
}

