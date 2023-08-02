namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tempftc = TempConverter.FahrenheittoCelcius(98);
            var tempctf = TempConverter.CelciustoFahrenheit(36);

            Console.WriteLine($"This it the temp today in Fahrenheit {tempctf}");
            Console.WriteLine($"This is the temp today in Celcius {tempftc}");
        }
    }
}
