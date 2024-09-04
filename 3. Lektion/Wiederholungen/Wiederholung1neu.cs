using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._3._Lektion.Wiederholungen
{
    internal class Wiederholung1neu
    {
        static void Main()
        {
            int alter = 22;

            // Komplexere Bedingungskette mit dem Bedingungsoperator `?:`
            string ticket = alter < 12
                            ? "Kinderticket"
                            : alter >= 12 && alter < 18
                            ? "Jugendticket"
                            : alter >= 18 && alter < 65
                            ? "Erwachsenenticket"
                            : "Seniorenticket";

            Console.WriteLine("Tickettyp: " + ticket);
        }
    }
}

