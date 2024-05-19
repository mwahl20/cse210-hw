using System;

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
        PromptGenerator GetPrompt = new PromptGenerator();
        UserResponse GetResponse = new UserResponse();
        Uploader DataSaver = new Uploader();

        string new_prompt = promptGenerator.GetPrompt();
        string response = userResponse.GetResponse(prompt);
        DataSaver.Save(prompt, response);
    }
}