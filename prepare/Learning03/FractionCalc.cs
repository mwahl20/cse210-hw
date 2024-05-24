using System;


public class Fractionary
{
    private int numer;
    private int denom;

    public void Fractionifier()
    {
            numer = 1;
            denom = 1;
    }
    public void Fractionifier(int WholeNum)
    {
        numer = WholeNum;
        denom = 1;
    }
    public void Fractionifier(int num, int den)
    {
        numer = num;
        denom = den;
    }
    public string Get_Fraction()
    {
        string fraction = $"{numer}/{denom}";
        return fraction;
    }
    public double GetDecimal()
    {
        return (double)numer/(double)denom;
    }
}