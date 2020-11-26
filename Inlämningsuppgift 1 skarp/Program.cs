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
            // The program writes a welcome message to the user and is on the screen for 2.5 seconds before the do while loop starts.
            Console.WriteLine("Hello and welcome to the calculator!");
            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            do
            {
                // The user is asked to write two operators and the answer is stored in the variables one and two after having been converted. 
                Console.WriteLine("Enter first operator: ");
                string operatorOne = Console.ReadLine();
                char one = Convert.ToChar(operatorOne);
                Console.WriteLine("Enter second operator: ");
                string operatorTwo = Console.ReadLine();
                char two = Convert.ToChar(operatorTwo);
                // The user is asked to enter term 1 to 3 and the answers are stored in termOne, termTwo, termThree.
                Console.WriteLine("Enter first term: ");
                int termOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second term: ");
                int termTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter third term: ");
                int termThree = Convert.ToInt32(Console.ReadLine());

                if (one == '+') // If one is a char + the program tryes row by row ( if ) antingen +, -, /, * när true så hoppar koden in i det rätta kodblocket.
                {
                    if (two == '+')
                    {
                        // First we run the calculation´and store the answer in the double variable result.
                        // Then we add the result in the List named changes, declared in the start of the Main method.
                        // The calculations and the result is printed out to the user in console.
                        // The program waits 2.5 secunds before it c´lears the console.
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
                    // If result is bigger then 100, More then a 100 is written in console.
                    // the user later can choose exit or go again.
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
                        // if the user said go on the bool keepGoing is set to true and the program loops.
                        keepGoing = true;
                    }
                    else
                    {
                        // If the user chooses EXIT the bool keepGoing is set to false witch breaks the loop for EXIT.
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
            // When the user exits the loop all the sums the operator created is written out in console in the forach loop.
            result = 0;
            foreach (var item in changes)
            {
                Console.WriteLine($"Values in list = {item}");
                result = result + item;                
            }
            // When the program is done it thanks the user for their inputs and writes the result of all the sums.
            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine($"Total sum is: {result}"); 

            Console.ReadLine();
        }
    }
}
