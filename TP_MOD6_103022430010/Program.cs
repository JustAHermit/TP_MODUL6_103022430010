using System;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random random = new Random();
        this.id = random.Next(10000, 100000);

        this.playCount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        int currentCount = int.Parse(playCount);
        int newCount = currentCount + count;
        playCount = newCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

}
class Program
{
    static void Main()
    {
        SayaMusicTrack lagu = new SayaMusicTrack("Gone Angels");

        lagu.IncreasePlayCount(12021773);

        lagu.PrintTrackDetails();
    }
}