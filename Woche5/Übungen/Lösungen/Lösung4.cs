﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester.Woche5.Übungen.Lösungen
{
    internal class Lösung4
    {

        static void Main()
        {
            // Liste von Namen
            List<string> namen = new List<string> { "Anna", "Ben", "Carla", "David" };

            // foreach-Schleife: Iteriert über jeden Namen in der Liste
            foreach (string name in namen)
            {
                Console.WriteLine($"Name: {name}");
            }
        }


    }
}
