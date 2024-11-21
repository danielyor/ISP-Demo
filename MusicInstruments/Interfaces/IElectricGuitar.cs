namespace MusicInstruments;

public interface IElectricGuitar : IStringedInstrument
{
    void Amplify();
    void SetVolume(int volume);
    void PlaySickSolo();
}
