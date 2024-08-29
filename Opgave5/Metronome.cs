namespace Opgave5;

public delegate void Notify();
public class Metronome
{
    //public event Notify Tick;

    public void Tick()
    {
        Console.WriteLine("Heard you");
    }
    Notify n = Tick;
    

   


}   

