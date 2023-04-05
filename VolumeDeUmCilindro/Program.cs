using VolumeDeUmCilindro;

internal class Program
{
    private static void Main(string[] args)
    {
        Cilindro cilindro = new Cilindro();
        cilindro.altura = 10;
        cilindro.base_ = 10;
        Console.WriteLine(cilindro.calcularCilindro());
    }
}