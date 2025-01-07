using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_A23_Modul_320_3.Semester.KW02_25
{
    internal class methodenParameter2
    {
        internal double Tanken(double Menge, int gefahreneKilometer)
        {
            double literPro100km = Menge * 100 / gefahreneKilometer;

            return literPro100km;
        }
    }

    class MethodenParameter2
    {

        static void Main(string[] args)
        {
            methodenParameter2 PKW = new methodenParameter2();
            double verbrauch;
            verbrauch = PKW.Tanken(43, 689);

            Console.WriteLine("Verbrauch: {0:f} Liter pro 100 km", verbrauch);
        }
    }
}


