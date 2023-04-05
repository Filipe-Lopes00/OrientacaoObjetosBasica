using VolumeDeUmaEsfera;

internal class Program
{
    private static void Main(string[] args)
    {
        VolumeEsfera volume = new VolumeEsfera();

        volume.raio = 1;
        Console.WriteLine(volume.VolumeDaEsfera());
    }
}