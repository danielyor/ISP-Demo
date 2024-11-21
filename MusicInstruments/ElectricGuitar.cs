namespace MusicInstruments;

public class ElectricGuitar : IMusicInstrument
{
    public void Amplify()
    {
        Console.WriteLine("Plug the guitar in.");
    }

    public void BlowAir()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        Console.WriteLine("Start playing the guitar.");
    }

    public void PlaySickSolo()
    {
        Console.WriteLine("Play a really sick guitar solo!");
    }

    public void Pluck()
    {
        Console.WriteLine("Pluck a string.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine("Set the volume at: " + volume);
    }

    public void Strike()
    {
        throw new NotImplementedException();
    }

    public void Tune()
    {
        Console.WriteLine("Tune the guitar.");
    }
}
