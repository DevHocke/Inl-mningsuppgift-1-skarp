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
            int yesNo = 0;

            Console.WriteLine("Hello and welcome to the calculator!");
            System.Threading.Thread.Sleep(2500);
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
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne + termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne + termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne + termTwo / termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " + " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
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
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne - termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne - termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne - termTwo / termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " - " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
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
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne * termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " * " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne * termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " * " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne * termTwo / termThree;
                        Console.WriteLine(termOne + " * " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
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
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '-')
                    {
                        result = termOne / termTwo - termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " - " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '*')
                    {
                        result = termOne / termTwo * termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " * " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else if (two == '/')
                    {
                        result = termOne / termTwo / termThree;
                        changes.Add(result);
                        Console.WriteLine(termOne + " / " + termTwo + " / " + termThree + " = " + result);
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                    }

                }
                if (result > 100)
                {
                    Console.WriteLine("More then 100");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Do you want another try?");
                    Console.WriteLine("Press 1 for yes.");
                    Console.WriteLine("Press 2 for no.");
                    yesNo = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (yesNo == 1)
                    {
                        keepGoing = true;
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }
                else if (result == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Do you want another try? ");
                    Console.WriteLine("Press 1 for yes.");
                    Console.WriteLine("Press 2 for no.");
                    yesNo = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (yesNo == 1)
                    {
                        keepGoing = true;
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }
                else if (result < 100)
                {
                    Console.WriteLine("Less then a hundred");
                    Console.WriteLine("Do you want another try? ");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Press 1 for yes.");
                    Console.WriteLine("Press 2 for no.");
                    yesNo = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (yesNo == 1)
                    {
                        keepGoing = true;
                    }
                    else
                    {
                        keepGoing = false;
                    }
                }

            } while (keepGoing == true);

            result = 0;
            foreach (var item in changes)
            {
                Console.WriteLine("Values in list = " + item);
                result = result + item;                
            }
            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Total sum is: " + result); 

            Console.ReadLine();
        }
    }
}
