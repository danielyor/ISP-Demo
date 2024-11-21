namespace MusicInstruments;

public class Piano : IPiano
{
    public void Play()
    {
        Console.WriteLine("Play the piano!");
    }

    public void Tune()
    {
        Console.WriteLine("Tune the piano.");
    }
}
