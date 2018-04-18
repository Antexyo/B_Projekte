using System;
using System.Text;

namespace Aufgabe_2_Password_Checker
{
    public class PasswortChecker
    {

        public static int isGutesPasswort(string password)
        {

            int scorecounter = 0; //initialize ScoreCounter
            int buchstabencounter = 0;
            int numbercounter = 0;
            int uppercaseletters = 0;
            int lowercaseletters = 0;
            int specialchars = 0;
            int specialcharinmiddle = 0;
            int numberinmiddle = 0;

            char[] passwordchars = password.ToCharArray(); // Put string in char array
            
            // 1. Check Passwort Length
            if (password.Length >= 12)
            {
                scorecounter++;
            }

            foreach (char character in passwordchars)
            {
                if (character >= 65 && character <= 90) //uppercase counter
                {
                    uppercaseletters++;
                }
                else if (character >= 97 && character <= 122) //Lowercase counter
                {
                    lowercaseletters++;
                }
                else if (character >= 48 && character <= 57) //number counter
                {
                    numbercounter++;
                }
                else if (character >= 33 && character <=47 || character >= 91 && character <= 96 || character >= 123 && character <= 126 ) //scpecialchar counter
                {
                    specialchars++;
                }
            }


            buchstabencounter = uppercaseletters + lowercaseletters;
            // Auswertung
            if (buchstabencounter >= 2)
            {
                scorecounter++;
            }
            if (numbercounter >= 2)
            {
                scorecounter++;
            }
            if (uppercaseletters >= 2)
            {
                scorecounter++;
            }
            if (lowercaseletters >= 1)
            {
                scorecounter++;
            }
            if (specialchars >= 2)
            {
                scorecounter++;
            }

            if (numbercounter >= 1 || specialchars >= 1)
            {
                for (int i = 1; i < passwordchars.Length-1; i++) //ignore first and last char of array
                {
                    if (passwordchars[i] >= 33 && passwordchars[i] <= 47 || passwordchars[i] >= 91 && passwordchars[i] <= 96 || passwordchars[i]>= 123 && passwordchars[i] <= 126)
                    {
                        specialcharinmiddle++;
                    }
                    else if (passwordchars[i] >= 48 && passwordchars[i] <= 57)
                    {
                        numberinmiddle++;
                    }
                }
            }

            if (numberinmiddle >= 1 )
            {
                scorecounter++;
            }
            if (specialcharinmiddle >= 1)
            {
                scorecounter++;
            }

            return scorecounter;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schreiben Sie Ihren Passwort String!");
            string userinput = Console.ReadLine();
            Console.WriteLine("Das Passwort hat einen Score von {0}", PasswortChecker.isGutesPasswort(userinput));
            Console.ReadKey();
            
        }
    }
}
