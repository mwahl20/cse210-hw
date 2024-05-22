using System;
using System.IO;

public class DataSaver
{
    public string path = "Journal.txt";
    public string inputs = "EntryStager.txt";

    public void StageEntry(string prompt, string response)
    {
        using (StreamWriter writer = new StreamWriter(inputs, true))
        {
            writer.WriteLine("Prompt: " + prompt);
            writer.WriteLine("Response: " + response);
            writer.WriteLine("Date: " + DateTime.Now);
            writer.WriteLine(new string('-',20));
        }
        Console.WriteLine("Staged");
    }

    public void DisplayEntries()
    {
        using (StreamReader readtext = new StreamReader(inputs))
        {
            string line;
            while((line = readtext.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }
        }
    }
    public void Save()
    {
        string content = File.ReadAllText(inputs);
        File.AppendAllText(path, content);
        Console.WriteLine("File Uploaded completely");
        File.WriteAllText(inputs, string.Empty);
    }

    public void DisplayJournal()
    {
        using (StreamReader readtext = new StreamReader(path))
        {
            string line;
            while((line = readtext.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }
        }
    }
}