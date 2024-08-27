using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._2._Lektion_30._08._2024
{
    internal class _3
    {
        static void Main(string[] args)
        {
            // Beispiel: Notenbewertung basierend auf einer Punktzahl

            Console.WriteLine("Bitte geben Sie Ihre Punktzahl (0-100) ein:");
            int score;
            bool isNumeric = int.TryParse(Console.ReadLine(), out score);

            if (isNumeric)
            {
                // if/else Bedingung für Notenstufen
                if (score >= 90)
                {
                    Console.WriteLine("Ihre Note ist: A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("Ihre Note ist: B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Ihre Note ist: C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Ihre Note ist: D");
                }
                else
                {
                    Console.WriteLine("Ihre Note ist: F");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 0 und 100 ein.");
            }

            Console.WriteLine("Programm beendet. Drücken Sie eine beliebige Taste, um zu beenden.");
            Console.ReadKey();
        }
    }
}
