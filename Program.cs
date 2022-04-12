using System;

public class Program
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split();
        double r = double.Parse(str[0]);
        double d = double.Parse(str[1]);
        double S = 0;
        string tmp;
        S = ((r * r) - ((d * d) * 0.25)) * (double) 3.141592654;
        //tmp = Math.Round(S,3, MidpointRounding.ToEven).ToString();
        
       
        tmp = String.Format("{0:0.00}", S);
        tmp = tmp.Replace(',', '.');
        Console.WriteLine(tmp);
    }
}
