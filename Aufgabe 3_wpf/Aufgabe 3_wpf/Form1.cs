using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_3_wpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPruefziffer_Click(object sender, EventArgs e)
        {

            // Einlesen der Serienummer als String
            string seriennummerggbn = tbxSeriennummer.Text;
            
            // Methoden Start
            int Pruefziffer(string snummer)
            {
                int restwert, quersumme, ergebnis;
                int char1 = 0;
                int vorergebnis = 0;

                char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                // Umwandeln des Seriennumme Arrays in Chararray
                char[] seriennummer = snummer.ToCharArray();
                int[] intarray = new int[seriennummer.Length -1];

                // Herausfinden der Zahl die zu der Stelle des Alphabets gehört
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (seriennummer [0] == alphabet [i])
                    {
                        // Char Wert vom Alphabet
                        char1 = i + 1;
                        // Falls Wert >= 10 splitte für Quersumme
                        if (char1 >= 10)
                        {
                            int charsub1 = char1 / 10;
                            int charsub2 = char1 % 10;
                            char1 = charsub1 + charsub2;
                        }
                        
                        
                    }
                }
                // Conver to Int Array
                for (int i = 1; i < seriennummer.Length  ; i++)
                {
                    intarray[i-1] = Convert.ToInt32(seriennummer[i].ToString());
                }
                // Zusammenzählen ohne Buchstaben
                for (int i = 0; i < intarray.Length; i++)
                {
                    vorergebnis = vorergebnis + intarray[i];
                }
                // Finales Zusammenzählen
                quersumme = vorergebnis + char1;
                // Rest der Berechnungen
                restwert = quersumme % 9;
                if (8 - restwert == 0)
                {
                    ergebnis = 9;
                }
                else
                {
                    ergebnis = 8 - restwert;
                }
                return ergebnis;
            }
            // Ausgabe in Label , Aufrufen der Methode
            lblPruefziffer.Text = Pruefziffer(seriennummerggbn).ToString();
        }
    }
}
