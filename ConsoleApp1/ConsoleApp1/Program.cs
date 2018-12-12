using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FangsClassLibrary;
using FangsClassLibraryTests;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true) { 
            int calc;
            int num1;
            
            
                Console.WriteLine("Please enter your number:");
                num1 = Console.Read();
                Console.WriteLine("1 - double a number");
                Console.WriteLine("2 - Convert to Celcius");
                Console.WriteLine("3 - Convert to Farenheit");
                Console.WriteLine("4 - Age in Dog Years");
                Console.WriteLine("5 - Exit program");
                Console.WriteLine("Please enter your choice:");
                calc = Console.Read();

                SelectiveCalc choice;
                choice = (SelectiveCalc)calc;

                switch (choice)
                {
                    case SelectiveCalc.DoubleANumber:
                        {

                            Console.Write(Calculations.DoubleANumber(num1));
                            break;
                        }
                    case SelectiveCalc.Celcius:
                        {

                            Console.Write(Calculations.GetCelsiusFromFarenheit(num1));
                            break;
                        }
                    case SelectiveCalc.Farenheit:
                        {

                            Console.Write(Calculations.GetFarenheitFromCelsius(num1));
                            break;
                        }
                    case SelectiveCalc.AgeInDogYears:
                        {

                            Console.Write(Calculations.AgeInDogYears(num1));
                            break;
                        }
                    case SelectiveCalc.Exit:
                        {
                            return;
                        }
                }

            }

        }
    }
}
