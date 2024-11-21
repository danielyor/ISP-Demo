namespace MusicInstruments;

public class Trumpet : IMusicInstrument
{
    public void Amplify()
    {
        throw new NotImplementedException();
    }

    public void BlowAir()
    {
        Console.WriteLine("Blow air into the trumpet.");
    }

    public void Play()
    {
        Console.WriteLine("Play the trumpet!");
    }

    public void PlaySickSolo()
    {
        throw new NotImplementedException();
    }

    public void Pluck()
    {
        throw new NotImplementedException();
    }

    public void SetVolume(int volume)
    {
        throw new NotImplementedException();
    }

    public void Strike()
    {
        throw new NotImplementedException();
    }

    public void Tune()
    {
        throw new NotImplementedException();
    }
}
