using System;

namespace BinearAusgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Es wird den Nutzer aufgefordert, eine Zahl einzugeben
            Console.WriteLine("Bitte geben Sie eine Zahl zwichen 0 und 255:");
            string eingabe = (Console.ReadLine()); 

            // Die Zahl wird in eine Zahl von Datentyp byte umgewandelt
            // Falls die Eingabe falsch ist, wird es dem Nutzer darauf hingewiesen 
            byte zahl; 
            if (!byte.TryParse(eingabe, out zahl))
            {
                Console.WriteLine("Die Eingabe ist falsch");
            }
      


            // Hier werden die Ergebnisse ausgegeben 
            string ergebnis1 = Byte2Binary(zahl);
            Console.WriteLine("Dezimal Zahl in Binär:" + ergebnis1);

            string ergebnis2 = Byte2Hexadecimal(zahl);
            Console.WriteLine("Dezimal Zahl in Hexadezimal:" + ergebnis2);

        }

        // In dieser Methode soll die Zahl in eine Binärzahl umgewandelt werden
        public static string Byte2Binary(byte zahl)
        {
            int i = 0;
            int testValue = 1;
            string result = "";
            while (i < 8)
            {
                if ((zahl & testValue) !=0)
                {
                    result = "1" + result;

                }
                else
                {
                    result = "0" + result;
                }

                testValue = 2 * testValue;
                i = i + 1;


            }
            return result;
        }
        // In dieser Methode soll die Zahl in eine Hexadezimalzahl umgewandelt werden
        public static string Byte2Hexadecimal(byte zahl)
        {
            
            string hex = zahl.ToString("X2");
            return hex;
        }





    }
}
