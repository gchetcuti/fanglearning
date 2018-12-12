using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FangsClassLibrary
{
    public class Calculations
    {

        public static int DoubleANumber(int number)
        {
            return number * 2;
        }

        public static double DoubleANumber(double number)
        {
            return number * 2;
        }

        public static double GetCelsiusFromFarenheit(double Celcius)
        {
            return (Celcius - 32) * 5 / 9;
        }

        public static double GetFarenheitFromCelsius(double farenheit)
        {
            return (farenheit *9 / 5) + 32;
            
        }

        public static int AgeInDogYears(int realAge)
        {
            return realAge * 7;
        }

        public void Method()
        {
            

        }

    }
}
