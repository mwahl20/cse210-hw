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
        PromptGenerator promptGenerator = new PromptGenerator();
        UserResponse userResponse = new UserResponse();
        DataSaver dataSaver = new DataSaver();

        string new_prompt = promptGenerator.GetPrompt();
        string response = userResponse.GetResponse(new_prompt);
        dataSaver.Save(new_prompt, response);
    }
}