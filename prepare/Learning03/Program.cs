using System;

class Program
{
    static void Main(string[] args)
    {
        Fractionary type1 = new Fractionary();
        type1.Fractionifier();
        Console.WriteLine(type1.Get_Fraction());
        Console.WriteLine(type1.GetDecimal());

        Fractionary type2 = new Fractionary();
        type2.Fractionifier(5);
        Console.WriteLine(type2.Get_Fraction());
        Console.WriteLine(type2.GetDecimal());

        Fractionary type3 = new Fractionary();
        type3.Fractionifier(3,4);
        Console.WriteLine(type3.Get_Fraction());
        Console.WriteLine(type3.GetDecimal());

        Fractionary type4 = new Fractionary();
        type4.Fractionifier(1,3);
        Console.WriteLine(type4.Get_Fraction());
        Console.WriteLine(type4.GetDecimal());

    }
}