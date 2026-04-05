using System;
using System.Diagnostics;

public class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null);
        Debug.Assert(title.Length <= 100);

        this.title = title;
        this.id = new Random().Next(10000, 100000);
        this.playCount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000);

        try
        {
            int currentCount = int.Parse(playCount);
            int newCount = checked(currentCount + count);
            playCount = newCount.ToString();
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: playcount melebihi batas!");
        }
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
        SayaMusicTrack track = new SayaMusicTrack("In Hell We Live, Lament");

        for (int i = 0; i < 250; i++)
        {
            track.IncreasePlayCount(10000000);
        }

        track.PrintTrackDetails();
    }
}