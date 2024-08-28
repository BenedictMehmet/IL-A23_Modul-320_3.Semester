using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._2._Lektion_30._08._2024
{
    internal class _2
    {
        static void Main(string[] args)
        {
            // Beispiel: Einfache Altersüberprüfung

            Console.WriteLine("Bitte geben Sie Ihr Alter ein:");
            int age;
            bool isNumeric = int.TryParse(Console.ReadLine(), out age);

            if (isNumeric)
            {
                // if/else Bedingung für Alterskategorien
                if (age < 18)
                {
                    Console.WriteLine("Sie sind minderjährig.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("Sie sind im erwerbsfähigen Alter.");
                }
                else
                {
                    Console.WriteLine("Sie sind im Ruhestand.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
            }

            // Weitere Logik könnte hier folgen...

            Console.WriteLine("Programm beendet. Drücken Sie eine beliebige Taste, um zu beenden.");
            Console.ReadKey();
        }
    }
}
