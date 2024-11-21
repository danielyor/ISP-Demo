namespace MusicInstruments;

public class Drums : IDrums
{
    public void Play()
    {
        Console.WriteLine("Play the drums!");
    }

    public void Strike()
    {
        Console.WriteLine("Strike the drums!");
    }
}
