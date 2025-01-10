using System;

namespace IL_A23_Modul_320_3.Semester.KW02_25
{
    internal class MethodenBeispiel1
    {
        internal int Geschwindigkeit; // Hiermit wird ein Feld deklariert, also muss Geschwindigkeit eine Zahl sein

        //Methode deklarieren
        // modifiers void Methodenname ()
        // { }
        internal void Anzeigen()
        {
            Console.WriteLine("Geschwindigkeit: " + this.Geschwindigkeit);
        }
    }

    class methodenBeispiel1
    {
        static void Main(string[] args)
        {
            MethodenBeispiel1 PKW = new MethodenBeispiel1();
            PKW.Geschwindigkeit = 54;

            MethodenBeispiel1 Fahrrad = new MethodenBeispiel1();
            Fahrrad.Geschwindigkeit = 18;

            PKW.Anzeigen();
            Fahrrad.Anzeigen();
    
        }
    }
}
