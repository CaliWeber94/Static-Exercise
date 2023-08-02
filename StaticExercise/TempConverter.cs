using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheittoCelcius(double fahrenheit)
        {
            var tempftc = (fahrenheit - 32) * 5/9;
            return tempftc;
        }

        public static double CelciustoFahrenheit(double celcius) 
        {
            var tempctf = (celcius * 9/5) + 32;
            return tempctf;
        }   
    }


}
