using calculeMediaPonderada;

internal class Program
{
    private static void Main(string[] args)
    {
        mediaPonderada media = new mediaPonderada();
        media.prova1 = 10;
        media.peso1 = 0.60;
        media.prova2 = 10;
        media.peso2 = 0.40;

        Console.WriteLine(media.MediaPonderada());
    }
}