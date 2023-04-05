using LataDeOleo;

internal class Program
{
    private static void Main(string[] args)
    {

        LataDeOleo_ oleo = new LataDeOleo_();

        oleo.altura = 10;
        oleo.base_ = 10;
        Console.WriteLine(oleo.calcularLata());


    }
}