using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripturepicker picker = new Scripturepicker();
        Replacer replacer = new Replacer();
        string reference = picker.GetReference();
        List<string> words = picker.GetWords();
        
        replacer.DisplayWords(words); 
        string quitter = "_";

        while(quitter != "quit")
        {
            
            Console.WriteLine("Press Enter for 3 more words to be removed, or quit to finish");
            quitter = Console.ReadLine();
            if (quitter =="quit")
            {
                break;
            }
            Console.Clear();
            Console.WriteLine(reference);
            replacer.ReplaceWords(3, words);
            
        }
    }
}