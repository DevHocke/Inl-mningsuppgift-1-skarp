using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_1_skarp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Campus Mölndal";
            
            List<double> changes = new List<double>();
            bool keepGoing = false;
            double result = 0;

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

                if (one == '+')
                {
                    if (two == '+')
                    {
                        result = termOne + termTwo + termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " + " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne + termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne + termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne + termTwo / termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    
                }
                else if (one == '-')
                {
                    if (two == '+')
                    {
                        result = termOne - termTwo + termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " + " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne - termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne - termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne - termTwo / termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    
                }
                else if (one == '*')
                {
                    if (two == '+')
                    {
                        result = termOne * termTwo + termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " * " + termTwo + " + " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne * termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " * " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne * termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " * " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne * termTwo / termThree;
                        Console.WriteLine(termOne + " * " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    
                }
                else if (one == '/')
                {
                    if (two == '+')
                    {
                        result = termOne / termTwo + termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " + " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne / termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne / termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne / termTwo / termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(1800);
                        Console.Clear();
                    }

                }
                if (result > 100)
                {
                    Console.WriteLine("More then 100");
                    Console.WriteLine("Do you want another try? ");
                }
                else if (result == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                    Console.WriteLine("Do you want another try? ");
                }
                else if (result < 100)
                {
                    Console.WriteLine("Less then a hundred");
                    Console.WriteLine("Do you want another try? ");
                }

            } while (keepGoing == true);

            








            Console.ReadLine();
        }
    }
}
