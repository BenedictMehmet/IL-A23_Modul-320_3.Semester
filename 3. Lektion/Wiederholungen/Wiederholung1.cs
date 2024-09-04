using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._3._Lektion.Wiederholungen
{
    internal class Wiederholung1
    {
        static void Main()
        {
            int alter = 22;
            string ticket;

            if (alter < 12)
            {
                ticket = "Kinderticket";
            }
            else if (alter >= 12 && alter < 18)
            {
                ticket = "Jugendticket";
            }
            else if (alter >= 18 && alter < 65)
            {
                ticket = "Erwachsenenticket";
            }
            else
            {
                ticket = "Seniorenticket";
            }

            Console.WriteLine("Tickettyp: " + ticket);
        }
    }



}

