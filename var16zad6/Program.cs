using System;

namespace var16zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            bezlemith bezlemith = new bezlemith(100, "Doh");
            MinuteTariff minuteTariff = new MinuteTariff("Nih", 10);
            Console.WriteLine(bezlemith.PrintInfo() + "\n" + minuteTariff.PrintInfo());
        }
    }
}
