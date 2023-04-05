using CombustívelporKm_;

internal class Program
{
    private static void Main(string[] args)
    {
        combustível_ consum = new combustível_();
        consum.kmFinal = 500;
        consum.kmInicial = 100;
        consum.combustivel = 25;

        Console.WriteLine(consum.CalcularConsumo());



    }
}