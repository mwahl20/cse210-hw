using System;
using System.Xml.Serialization;

class UserResponse
{
    public string GetResponse(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        

        string choice = " ";
        PromptGenerator promptGenerator = new PromptGenerator();
        UserResponse userResponse = new UserResponse();
        DataSaver dataSaver = new DataSaver();
        while (choice != "5")
        {
            Console.WriteLine("Please Select a choice:");
            Console.WriteLine("1. Write a new Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                
                case "1":
                    string new_prompt = promptGenerator.GetPrompt();
                    string response = userResponse.GetResponse(new_prompt);
                    dataSaver.StageEntry(new_prompt, response);
                    break;

                case "2":
                    dataSaver.DisplayEntries();
                    break;
                case "3":
                    dataSaver.Save();
                    break;
                case "4":
                    dataSaver.DisplayJournal();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Not an Option, please try again");
                    break;
            }
        }
    }
}