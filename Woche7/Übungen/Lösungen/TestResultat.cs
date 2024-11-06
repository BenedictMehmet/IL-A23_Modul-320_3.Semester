using System;

namespace IL_A23_Modul_320_3.Semester.Woche7.Übungen.Lösungen
{
    internal class TestResultat
    {
        /* Die Main-Methode ist der Einstiegspunkt des Programms */
        static void Main()
        {
            /* Deklaration der Variablen:
               - maxPunkte: Maximale erreichbare Punkte (10).
               - bestandenPunkte: Mindestpunkte für das Bestehen (7).
               - erhaltenePunkte: Variable, um die eingegebene Punktzahl zu speichern. */
            int maxPunkte = 10;
            int bestandenPunkte = 7;
            int erhaltenePunkte;

            /* Endlosschleife, die wiederholt nach einer Punktzahl fragt,
               bis der Benutzer das Programm mit -1 beendet. */
            while (true)
            {
                Console.Write("Bitte geben Sie Ihre Punktzahl ein (oder -1 zum Beenden): ");
                /* Liest die Benutzereingabe als String ein */
                string input = Console.ReadLine();

                /* Versucht, die Eingabe in eine Ganzzahl (int) zu konvertieren.
                   Falls die Konvertierung nicht möglich ist, gibt TryParse "false" zurück,
                   und eine Fehlermeldung wird angezeigt. */
                if (!int.TryParse(input, out erhaltenePunkte))
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                    /* continue überspringt den Rest der Schleife und startet sie neu */
                    continue;
                }

                /* Überprüfung, ob der Benutzer -1 eingegeben hat,
                   um das Programm zu beenden. */
                if (erhaltenePunkte == -1)
                {
                    Console.WriteLine("Programm beendet.");
                    /* break beendet die Schleife */
                    break;
                }

                /* Überprüfung, ob die eingegebene Punktzahl im gültigen Bereich liegt
                   (zwischen 0 und maxPunkte). Wenn nicht, wird eine Fehlermeldung angezeigt
                   und die Schleife neu gestartet. */
                if (erhaltenePunkte < 0 || erhaltenePunkte > maxPunkte)
                {
                    Console.WriteLine($"Bitte geben Sie eine Punktzahl zwischen 0 und {maxPunkte} ein.");
                    continue;
                }

                /* Überprüfung, ob die Punktzahl den Mindestanforderungen entspricht */
                if (erhaltenePunkte >= bestandenPunkte)
                {
                    /* Wenn die Punktzahl ausreichend ist, wird die Bewertung
                       basierend auf der Punktzahl vorgenommen. */
                    switch (erhaltenePunkte)
                    {
                        case 10:
                            Console.WriteLine("Ergebnis: Sehr gut"); // 10 Punkte
                            break;
                        case 9:
                            Console.WriteLine("Ergebnis: Gut"); // 9 Punkte
                            break;
                        case 8:
                            Console.WriteLine("Ergebnis: Befriedigend"); // 8 Punkte
                            break;
                        case 7:
                            Console.WriteLine("Ergebnis: Ausreichend"); // 7 Punkte
                            break;
                        default:
                            Console.WriteLine("Ergebnis: Leider nicht genügend Punkte erreicht");
                            break;
                    }
                }
                else
                {
                    /* Wenn die Punktzahl unter der Bestehensgrenze liegt,
                       wird angezeigt, dass die Punktzahl nicht ausreichend ist. */
                    Console.WriteLine("Ergebnis: Leider nicht genügend Punkte erreicht");
                }
            }
        }
    }
}
