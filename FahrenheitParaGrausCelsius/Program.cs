using FahrenheitParaGrausCelsius;

internal class Program
{
    private static void Main(string[] args)
    {
        FahrenheitCelsius fahrenheit = new FahrenheitCelsius();

        fahrenheit.TempC = 32;
        Console.WriteLine(fahrenheit.CalcularFh());

    }
}