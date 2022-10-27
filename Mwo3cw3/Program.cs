using System;
using System.Text;
using System.Threading.Tasks;

namespace Mwo3cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            Console.WriteLine("Program przeprowadzający zaawansowane operacje matematyczne. \n");

            do
            {
                int res;
                Console.Write("Wprowadź pierwszą liczbę:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Wprowadź drugą liczbę:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Wprowadź symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Dodawanie:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Odejmowanie:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Mnożenie:" + res);
                        break;
                    case "/":
                        if (num2 == 0) {
                            Console.WriteLine("Error");
                            Console.WriteLine("!Nie dzielimy przez 0!");
                        }
                        else {
                            res = num1 / num2;
                            Console.WriteLine("Dzielenie:" + res);
                        }
                        break;
                    default:
                        Console.WriteLine("Niepoprawne dane");
                        break;
                }
                Console.ReadLine();
                Console.Write("Czy chcesz kontynuować(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}