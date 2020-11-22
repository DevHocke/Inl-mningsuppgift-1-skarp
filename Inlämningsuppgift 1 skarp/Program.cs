using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_1_skarp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Campus Mölndal";
            
            List<int> changes = new List<int>();
            bool keepGoing = false;
            int result = 0;

            Console.WriteLine("Hello and welcome to the calculator!");
            System.Threading.Thread.Sleep(1800);
            Console.Clear();

            do
            {
                Console.WriteLine("Enter first operator: ");
                string operatorOne = Console.ReadLine();
                char one = Convert.ToChar(operatorOne);
                Console.WriteLine("Enter second operator: ");
                string operatorTwo = Console.ReadLine();
                char two = Convert.ToChar(operatorTwo);

                Console.WriteLine("Enter first term: ");
                int termOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second term: ");
                int termTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter third term: ");
                int termThree = Convert.ToInt32(Console.ReadLine());



            } while (keepGoing == true);

            








            Console.ReadLine();
        }
    }
}
