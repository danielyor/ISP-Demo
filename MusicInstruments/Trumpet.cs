namespace MusicInstruments;

public class Trumpet : ITrumpet
{
    public void BlowAir()
    {
        Console.WriteLine("Blow air into the trumpet.");
    }

    public void Play()
    {
        Console.WriteLine("Play the trumpet!");
    }
}
