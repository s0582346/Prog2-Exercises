using System;

namespace Uebung3.Typen
{
    class Program
    {
        static void Main()
        {

            // Hier werden die Variablen mit ihren entsprechenden Werten gespeichert 
            uint  a0 = 100101101;
            float a1 = 1.0f;
            string a2 = "HTW Berlin";
            double a3 = 299.0 * 1e6;
            char a4 = '#';
            int a5 = -1234;
            byte a6 = 123;
            bool a7 = true;
            decimal a8 = -11111.1m;
            ushort a9 = 65535;

            GebeVariableAus(nameof(a0), a0);
            GebeVariableAus(nameof(a1), a1);
            GebeVariableAus(nameof(a2), a2);
            GebeVariableAus(nameof(a3), a3);
            GebeVariableAus(nameof(a4), a4);
            GebeVariableAus(nameof(a5), a5);
            GebeVariableAus(nameof(a6), a6);
            GebeVariableAus(nameof(a7), a7);
            GebeVariableAus(nameof(a8), a8);
            GebeVariableAus(nameof(a9), a9);

            int b0 = 0;
            double b1 = 1.0;
            float b2 = 2f;
            string b3 = "3";

            int c0 = Convert.ToInt32(b0 * b1);
            double c1 = Convert.ToDouble(b3);
            float c2 = Convert.ToSingle(b1 + b2);
            string c3 = Convert.ToString(b1);


            GebeVariableAus(nameof(c0), c0);
            GebeVariableAus(nameof(c1), c1);
            GebeVariableAus(nameof(c2), c2);
            GebeVariableAus(nameof(c3), c3);

            // Hier wird das Ergebnis ausgegeben

            double ergebnis = InStunden(90);
            Console.WriteLine($"{90} Minuten sind {ergebnis} Stunden");

        }
        static void GebeVariableAus(string name, object wert)
        {

            // In der ersten neuen Methode werden die Variablen ausgegeben
            Console.WriteLine($"Die Variable {name} ist vom Typ {wert.GetType()} und hat den Wert { wert} ");
            
        }
        
        public static double InStunden(int minuten)
        {
            // In der zweiten neuen Methode werden Minuten in Stunden umgewandelt
            double ergebnis = minuten / 60.0;
            return ergebnis;
            


        }

    }
}
