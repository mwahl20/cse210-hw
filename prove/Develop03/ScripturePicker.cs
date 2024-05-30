using System;

public class Scripturepicker
{
    public string reference = "John 3:16";

    string scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    public string[] split_scripture;
    public Scripturepicker()
    {
        split_scripture = scripture.Split(' ');
    } 

    public List<string> GetWords()
    {
        return new List<string>(scripture.Split(' '));
    }


}