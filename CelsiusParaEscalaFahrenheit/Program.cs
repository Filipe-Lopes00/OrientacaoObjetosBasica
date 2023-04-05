using CelsiusParaEscalaFahrenheit;

internal class Program
{
    private static void Main(string[] args)
    {
        CelsiusParaFh celsius = new CelsiusParaFh();

        celsius.TempF = 0;
        Console.WriteLine(celsius.CalcularTempC ());
    }
}