using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._3._Lektion.Übungen.Lösungen
{
    internal class Lösung1
    {
        static void Main()
        {
            Console.Write("Bitte geben Sie die Punktzahl ein (0-100): ");
            int punktzahl = Convert.ToInt32(Console.ReadLine());

            string note = punktzahl >= 90 ? "A" :
                          punktzahl >= 80 ? "B" :
                          punktzahl >= 70 ? "C" :
                          punktzahl >= 60 ? "D" : "F";

            Console.WriteLine("Die Note ist: " + note);
        }
    }



}
}
