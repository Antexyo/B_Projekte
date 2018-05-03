using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Aufgabe_5
{



    public partial class Form1 : Form
    {
        public static double TimeToSec(double hours, double minutes, double seconds)
        {
            // Total Time in Seconds umrechnung

            if (hours > 23 || hours < 0)
            {
                throw new ArgumentException("Stundenangabe muss zwischen 0 und 23 sein!");
            }

            if (minutes > 59 | minutes < 0)
            {
                throw new ArgumentException("Minutenangabe muss zwischen 0 und 59 sein!");
            }

            if (seconds > 59 | seconds < 0)
            {
                throw new ArgumentException("Sekundenangabe muss zwischen 0 und 59 sein!");
            }
                double totalTimeSeconds = (hours * 3600) + (minutes * 60) + seconds;
                return totalTimeSeconds;
        }

        public void SecToTime(double timeSeconds)
        {
            // Rechne die Sekunden in eine Uhrzeit um
            double hours = timeSeconds / 3600;
            double minutes = (timeSeconds % 3600) / 60;
            double seconds = timeSeconds % 60;

            tbxDiffh.Text = Convert.ToString(Math.Abs(Convert.ToInt32(hours)));
            tbxDiffm.Text = Convert.ToString(Math.Abs(Convert.ToInt32(minutes)));
            tbxDiffs.Text = Convert.ToString(Math.Abs(seconds));
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btBerechnen_Click(object sender, EventArgs e)
        {

            double difft1t2 = TimeToSec(Convert.ToDouble(tbxT1h.Text), Convert.ToDouble(tbxT1m.Text), Convert.ToDouble(tbxT1s.Text)) - 
                              TimeToSec(Convert.ToDouble(tbxT2h.Text), Convert.ToDouble(tbxT2m.Text), Convert.ToDouble(tbxT2s.Text));

            SecToTime(difft1t2);

            if (difft1t2 < 0)
            {
                tbxDiffh.Text = tbxDiffh.Text.Insert(0, "-");
            }


        }
    }
}
