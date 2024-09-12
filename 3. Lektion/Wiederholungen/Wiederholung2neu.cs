using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester._3._Lektion.Wiederholungen
{
    internal class Wiederholung2neu
    {
   
        static void Main()
        {
            int menge = 20;
            string kundentyp = "Premium";
            double einzelpreis = 50.0;

            // Berechnung des Rabatts basierend auf Menge und Kundentyp
            double rabatt = menge >= 50
                            ? kundentyp == "Premium" ? 0.20 : 0.10
                            : menge >= 20
                            ? kundentyp == "Premium" ? 0.15 : 0.05
                            : kundentyp == "Premium" ? 0.10 : 0.0;

            // Berechnung des Endpreises
            double endpreis = menge * einzelpreis * (1 - rabatt);

            Console.WriteLine("Endpreis: " + endpreis + " EUR");
        }
    }


}

