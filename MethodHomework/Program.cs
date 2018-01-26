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

            int [] numb = new int[2];
            bool trueOrFalse = NumbersTwo(numb);
            Console.WriteLine("The numbers are equal. " + trueOrFalse + "\n");

            string [] favFood = new string [3];
            Console.WriteLine("My favorite foods are " + (Foods(favFood)) + "\n");

            int tri = 0;
            Console.WriteLine("The missing side of the triangle is " + (Triangle(tri)));
        }
        //method for question 3
        static string Foods(string [] names)
        {
            string x = " ";
            int i = 0;

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
        static int Numbers(int number)
        {
            int i;
            int j = 0;
            int[] num = new int[2];
            for (i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter a number to compare");
                num[i] = int.Parse(Console.ReadLine());
            }
            if (num[0] > num[1])
            {
                j = num[0];
            }
            else
            {
                j = num[1];
            }
            return j;
        }
        //method for question 2
        static bool NumbersTwo(int[] numbers)
        {
            int[] num = new int[2];
            bool isEqual = true;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter a number to compare");
                num[i] = int.Parse(Console.ReadLine());
            }
            if (num[0] == num[1])
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            return isEqual;
            
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

