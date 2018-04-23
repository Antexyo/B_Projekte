using System;

class prfziffer
{
    public static int pruefziffer_berechnen(char [] seriennummer)
    {
        int pruefziffer, quersumme = 0;
        char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


        for (int i = 0; i < alphabet.Length; i++)
        {
            if (seriennummer[0] == alphabet[i])
            {
                quersumme = (i + 1) % 10 + (i + 1) / 10;


            }
        }

        for (int i = 1; i < seriennummer.Length; i++)
        {
            quersumme += Convert.ToInt32(seriennummer[i].ToString());
        }

        pruefziffer = quersumme % 9;

        if (pruefziffer == 0)
        {
            pruefziffer = 9;
        }
        else
        {
            pruefziffer = 8 - pruefziffer;
        }
        return pruefziffer;
    }

    public static void Main()
    {

        char[] seriennummer = new char[] { 'V', '0', '2', '3', '8', '7', '0', '4', '0', '0', '3' };

        Console.WriteLine("Prüfziffer: " + prfziffer.pruefziffer_berechnen(seriennummer));
        Console.ReadKey();
    }
}