using CalcularMediaHarmonica;

internal class Program
{
    private static void Main(string[] args)
    {
        mediaHarmonica mediaTotal = new mediaHarmonica();

        mediaTotal.media1 = 10;
        mediaTotal.media2=10;
        mediaTotal.media3 = 10;
        mediaTotal.media4 = 10;
        Console.WriteLine(mediaTotal.MediaTotal());


    }
}