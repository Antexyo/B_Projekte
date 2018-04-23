using System;



class WallisschesProdukt
{

    public static double berechneProdukt(int n)
    {
        double ergebnis = 1;


        for (double i = 2; i <= (2*n); i +=2)
        {
            ergebnis *= (i / (i - 1)) * (i / (i + 1));
        }

        return ergebnis *2 ;
    }


    public static void Main()
    {
        Console.WriteLine("Geben Sie den Faktor ein: ");
        Console.WriteLine("Das Produkt ist: " + WallisschesProdukt.berechneProdukt(Convert.ToInt32(Console.ReadLine()))); 
        Console.ReadKey();
    }
}
