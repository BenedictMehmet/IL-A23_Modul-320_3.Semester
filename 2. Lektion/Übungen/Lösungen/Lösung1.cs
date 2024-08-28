using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._2._Lektion.Übungen.Lösungen
{
    internal class Lösung1
    {

        static void Main(string[] args)
        {
            int inputNumber = 55;  // Beispielwert, kann geändert werden.

            if (inputNumber >= 1 && inputNumber <= 100)
            {
                Console.WriteLine("Zahl liegt im Bereich");
            }
            else
            {
                Console.WriteLine("Zahl liegt außerhalb des Bereichs");
            }
        }


    }
}
