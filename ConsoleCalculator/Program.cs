using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while(cont)
            {
                Greeting();
                cont = Continue();
            }
        }

        public static void Greeting()
        {
            Console.Write("Press any following key to perform an arithmetic operation: \n" +
                "\t1 - Addition\n" +
                "\t2 - Subtraction\n" +
                "\t3 - Multipliation\n" +
                "\t4 - Division\n" +
                "Select an option: ");
            string input = Console.ReadLine();
            Selector(input);
        }

        public static bool Continue()
        {
            Console.Write("Do you want to continue again (Y/N)?: ");
            string input = Console.ReadLine();
            if(input == "Y" || input == "y")
            {
                return true;
            }
            else if(input == "N" || input == "n")
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }

        public static void Selector(string input)
        {
            switch(input)
            {
                case "1":
                    AdditionFunction();
                    break;
                case "2":
                    SubtractionFunction();
                    break;
                case "3":
                    MultiplicationFunction();
                    break;
                case "4":
                    DivisionFunction();
                    break;
                default:
                    Console.WriteLine("Incorrect selection input Please try again.");
                    Greeting();
                    break;
            }
        }

        public static void AdditionFunction()
        {
            Console.Write("\nEnter Value 1: ");
            string val1 = Console.ReadLine();
            int x = 0;
            int y = 0;
            if (Int32.TryParse(val1, out x))
            {
                Console.Write("Enter Value 2: ");
                string val2 = Console.ReadLine();
                if (Int32.TryParse(val2, out y))
                {
                    int sum = x + y;
                    Console.WriteLine(val1 + " + " + val2 + " = " + sum.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter valid integers.");
                    AdditionFunction();
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integers.");
                AdditionFunction();
            }
        }

        public static void SubtractionFunction()
        {
            Console.Write("\nEnter Value 1: ");
            string val1 = Console.ReadLine();
            int x = 0;
            int y = 0;
            if (Int32.TryParse(val1, out x))
            {
                Console.Write("Enter Value 2: ");
                string val2 = Console.ReadLine();
                if (Int32.TryParse(val2, out y))
                {
                    int difference = x - y;
                    Console.WriteLine(val1 + " - " + val2 + " = " + difference.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter valid integers.");
                    SubtractionFunction();
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integers.");
                SubtractionFunction();
            }

        }

        public static void MultiplicationFunction()
        {
            Console.Write("\nEnter Value 1: ");
            string val1 = Console.ReadLine();
            int x = 0;
            int y = 0;
            if (Int32.TryParse(val1, out x))
            {
                Console.Write("Enter Value 2: ");
                string val2 = Console.ReadLine();
                if (Int32.TryParse(val2, out y))
                {
                    int product = x * y;
                    Console.WriteLine(val1 + " * " + val2 + " = " + product.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter valid integers.");
                    MultiplicationFunction();
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integers.");
                MultiplicationFunction();
            }

        }

        public static void DivisionFunction()
        {
            Console.Write("\nEnter Value 1: ");
            string val1 = Console.ReadLine();
            int x = 0;
            int y = 0;
            if (Int32.TryParse(val1, out x))
            {
                Console.Write("Enter Value 2: ");
                string val2 = Console.ReadLine();
                if (Int32.TryParse(val2, out y))
                {
                    int quotient = x / y;
                    Console.WriteLine(val1 + " / " + val2 + " = " + quotient.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter valid integers.");
                    DivisionFunction();
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integers.");
                DivisionFunction();
            }

        }
    }
}
