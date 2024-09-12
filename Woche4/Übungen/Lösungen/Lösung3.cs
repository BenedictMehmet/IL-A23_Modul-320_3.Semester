using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester.Woche4.Übungen.Lösungen
{
    internal class Lösung3
    {
        public static void Main(string[] args)
        {
            int zahl;

            // do-while Schleife zur Eingabe einer geraden Zahl
            do
            {
                Console.Write("Bitte eine gerade Zahl eingeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());
            }
            while (zahl % 2 != 0); // Bedingung: Zahl muss gerade sein

            // Typumwandlung von int zu double
            double gleitkommazahl = (double)zahl;

            Console.WriteLine("Die eingegebene gerade Zahl: " + zahl);
            Console.WriteLine("Die Zahl als Gleitkommazahl: " + gleitkommazahl);
        }

    }
}
