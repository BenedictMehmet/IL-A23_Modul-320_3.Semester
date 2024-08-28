using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._2._Lektion.Übungen.Lösungen
{
    internal class Lösung2
    {
        static void Main(string[] args)
        {
            int personAge = 30;  // Beispielwert, kann geändert werden.

            if (personAge < 12 || personAge > 65)
            {
                Console.WriteLine("Ermäßigung gewährt");
            }
            else
            {
                Console.WriteLine("Keine Ermäßigung");
            }
        }




    }
}
