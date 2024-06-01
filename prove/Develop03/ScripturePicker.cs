using System;

public class Scripturepicker
{
    List<string> reference_list = new List<string>{ 
    "John 3:16",
    "Moses 1:39",
    "Proverbs 3:5-6"
    };

    List<string> scripture_list = new List<string>{
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.",
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6. In all thy ways acknowledge him, and he shall direct thy paths."
        };
    public string[] split_scripture;
    public string reference;
    Random random = new Random();
    public Scripturepicker()
    {
    int scriptureIndex = random.Next(scripture_list.Count);
    string scripture = scripture_list[scriptureIndex];
    reference = reference_list[scriptureIndex];
    split_scripture = scripture.Split(' ');
    }
    
    public List<string> GetWords()
    {
        return new List<string>(split_scripture);
    }
    public string GetReference()
    {
        return reference;
    }
}