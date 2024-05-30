using System;

public class Replacer
{
    private Random random;

    public Replacer()
    {
        random = new Random();
    }

    public void ReplaceWords(int count, List<string> words)
    {
        Scripturepicker picker = new Scripturepicker();
        bool allreplaced = true;
        foreach (var word in words)
        {
            if (!word.All(c => c== '_'))
            {
                allreplaced = false;
                break;
            }
        }
        if(allreplaced == true)
        {
            words.Clear();
            words.AddRange(picker.GetWords());
            Console.WriteLine("Scripture Refilled.");
        }
        int list_length = words.Count;
        int replCount = words.Count(word => word.All(c=> c== ' '));
        HashSet<int> usedIndexes = new HashSet<int>();
        
        if (replCount >= words.Count -count)
        {
            words.Clear();
            words.AddRange(picker.GetWords());
            Console.WriteLine("Scripture Refilled");
        }
        for (int i=0; i < count; i++)
        {
            int index;
            do
            {
                index = random.Next(0,list_length);
            }while (usedIndexes.Contains(index) || words[index] == new string('_', words[index].Length));

            usedIndexes.Add(index);
            words[index] = new string('_', words[index].Length);
        }

        DisplayWords(words);
    }

    public void DisplayWords(List<string> words)
    {
        Console.Clear();
        Console.WriteLine(string.Join(" ", words));
    }
    
}
