using system;
using System.IO;

public class DataSaver
{
    private string path = "mwahl20/cse210-hw/prove/Develop02/Journal.txt";

    public void Save(string prompt, string response)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine("Prompt: " + prompt);
            writer.WriteLine("Response: " + response);
            writer.WriteLine("Date: " + DateTime.now);
            writer.WriteLine(new string("...",20));
        }
        Console.WriteLine("Saved");
    }
}