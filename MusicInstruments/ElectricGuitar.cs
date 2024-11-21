namespace MusicInstruments;

public class ElectricGuitar : IElectricGuitar
{
    public void Amplify()
    {
        Console.WriteLine("Plug the guitar in.");
    }

    public void Play()
    {
        Console.WriteLine("Start playing the guitar!");
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

    public void Tune()
    {
        Console.WriteLine("Tune the guitar.");
    }
}
