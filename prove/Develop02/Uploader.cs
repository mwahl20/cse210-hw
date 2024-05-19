using System;
using System.IO;

public class DataSaver
{
    private string path = "Journal.txt";

    public void Save(string prompt, string response)
    {
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine("Prompt: " + prompt);
            writer.WriteLine("Response: " + response);
            writer.WriteLine("Date: " + DateTime.Now);
            writer.WriteLine(new string('-',20));
        }
        Console.WriteLine("Saved");
    }
}