namespace Vererbung {
    internal class Program {
        static void Main(string[] args) {
            Gast newgast = new();
            newgast.SetTischnummer(1);
            bool anwesend = true;
            while (anwesend) {
                Console.WriteLine("Welches Getränk wollen sie bestellen?");
                Console.WriteLine("1) Tee\n2)Kaffee\n3)Bier\n4)Lokal verlassen");
                int antwort = Convert.ToInt16(Console.ReadLine());
                switch (antwort) {
                    case 1:
                    Tee();
                    break;
                    case 2:
                    Kaffee();
                    break;
                    case 3:
                    Bier();
                    break;
                    case 4:
                    anwesend = false;
                    break;
                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsche Eingabe");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
            }

        }
        static void Tee() {
            Fruechtetee tee = new();
            Console.Write("Welchen Tee Sorte wollen Sie? :");
            tee.SetSorte(Console.ReadLine());
            Console.WriteLine($"Wollen Sie Zucker zu ihrem {tee.GetSorte()}tee? (true/false)");
            tee.SetZucker(Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine($"Wollen Sie Zitrone zu ihrem {tee.GetSorte()}tee? (true/false)");
            tee.SetZitrone(Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine($"Wollen Sie Milch zu ihrem {tee.GetSorte()}tee? (true/false)");
            tee.SetMilch(Convert.ToBoolean(Console.ReadLine()));
            Console.WriteLine($"Wie lang soll ihr {tee.GetSorte()}tee ziehen ? (in minuten angeben)");
            tee.SetZiehzeit(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Voilá, ihr {tee.GetSorte()}tee mit");
            if (tee.GetZucker()) {
                Console.Write(" Zucker");
            }
            if (tee.GetZitrone()) {
                Console.Write(" Milch");
            }
            if (tee.GetZitrone()) {
                Console.WriteLine(" Zitrone.");
            }
            if (!tee.GetZitrone() && !tee.GetZucker() && !tee.GetMilch()) {
                Console.WriteLine(" nichts.");
            }
            Console.WriteLine($"Er ist genau {tee.GetZiehzeit()} Minuten gezogen.");
        }
        static void Kaffee() {
            Console.WriteLine("Welchen Kaffee wollen Sie?: \n1) Espresso\n2) Milchkaffee\n3) latte Macchiato\n4) Eiskaffee\n5) zurück");
            int antwort = Convert.ToInt16(Console.ReadLine());
            switch (antwort) {
                case 1:
                Espresso espresso = new();
                Console.Write("Welchen Koffeingehalt soll ihr Espresso haben? ");
                espresso.SetKoffeingehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write("aus welchem Land sollen die Bohnen kommen? ");
                espresso.SetHerkunftsland(Console.ReadLine());
                Console.Write("Welche Bohnensorte soll ihr Espresso haben? ");
                espresso.SetBohnensorte(Console.ReadLine());
                Console.Write("Normal oder einen doppelten Espresso? (true/false)");
                espresso.SetDoppel(Convert.ToBoolean(Console.ReadLine()));
                if (espresso.GetDoppel()) {
                    Console.Write("Voilá, ihr doppelter Espresso");
                }
                else {
                    Console.Write("Voilá, ihr normaler Espresso");
                }
                Console.WriteLine($" aus dem Herkunftsland: {espresso.GetHerkunftsland()}, der Bohnensorte: {espresso.GetBohnensorte()}, dem koffeingehalt: {espresso.GetKoffeingehalt()}");
                break;
                case 2:
                Milchkaffee milchkaffee = new();
                Console.Write("Welchen Koffeingehalt soll ihr Espresso haben? ");
                milchkaffee.SetKoffeingehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write("aus welchem Land sollen die Bohnen kommen? ");
                milchkaffee.SetHerkunftsland(Console.ReadLine());
                Console.Write("Welche Bohnensorte soll ihr Espresso haben? ");
                milchkaffee.SetBohnensorte(Console.ReadLine());
                Console.Write("Mit Milchschaum? (true/false)");
                milchkaffee.SetMilchschaum(Convert.ToBoolean(Console.ReadLine()));
                Console.Write("Wie hoch soll der Milchanteil sein? ");
                milchkaffee.SetMilchanteil(Convert.ToDouble(Console.ReadLine()));
                if (milchkaffee.GetMilchschaum()) {
                    Console.Write("Voilá, ihr Milchkaffee mit Milchschaum");
                }
                else {
                    Console.Write("Voilá, ihr Milchkaffe ohne Milchschaum");
                }
                Console.WriteLine($" aus dem Herkunftsland: {milchkaffee.GetHerkunftsland()}, der Bohnensorte: {milchkaffee.GetBohnensorte()}, dem koffeingehalt: {milchkaffee.GetKoffeingehalt()}");
                break;
                case 3:
                LatteMacchiato latte = new();
                Console.Write("Welchen Koffeingehalt soll ihr Espresso haben? ");
                latte.SetKoffeingehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write("aus welchem Land sollen die Bohnen kommen? ");
                latte.SetHerkunftsland(Console.ReadLine());
                Console.Write("Welche Bohnensorte soll ihr Espresso haben? ");
                latte.SetBohnensorte(Console.ReadLine());
                Console.Write("Mit Milchschaum? (true/false)");
                latte.SetMilchschaum(Convert.ToBoolean(Console.ReadLine()));
                Console.Write("Wie hoch soll der Milchanteil sein? ");
                latte.SetMilchanteil(Convert.ToDouble(Console.ReadLine()));
                if (latte.GetMilchschaum()) {
                    Console.Write("Voilá, ihr Milchkaffee mit Milchschaum");
                }
                else {
                    Console.Write("Voilá, ihr Milchkaffe ohne Milchschaum");
                }
                Console.WriteLine($" aus dem Herkunftsland: {latte.GetHerkunftsland()}, der Bohnensorte: {latte.GetBohnensorte()}, dem koffeingehalt: {latte.GetKoffeingehalt()} und Milchanteil von: {latte.GetMilchanteil()}");
                break;
                case 4:
                Eiskaffee Eiskaffee = new();
                Console.Write("Welchen Koffeingehalt soll ihr Espresso haben? ");
                Eiskaffee.SetKoffeingehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write("aus welchem Land sollen die Bohnen kommen? ");
                Eiskaffee.SetHerkunftsland(Console.ReadLine());
                Console.Write("Welche Bohnensorte soll ihr Espresso haben? ");
                Eiskaffee.SetBohnensorte(Console.ReadLine());
                Console.Write("Mit Sahne? (true/false)");
                Eiskaffee.SetSahne(Convert.ToBoolean(Console.ReadLine()));
                Console.Write("Wie hoch soll der Milchanteil sein? ");
                Eiskaffee.SetAnzahlEiskugel(Convert.ToInt16(Console.ReadLine()));
                if (Eiskaffee.GetSahne()) {
                    Console.Write("Voilá, ihr Milchkaffee mit Milchschaum");
                }
                else {
                    Console.Write("Voilá, ihr Milchkaffe ohne Milchschaum");
                }
                Console.WriteLine($" aus dem Herkunftsland: {Eiskaffee.GetHerkunftsland()}, der Bohnensorte: {Eiskaffee.GetBohnensorte()}, dem koffeingehalt: {Eiskaffee.GetKoffeingehalt()} und mit {Eiskaffee.GetAnzahlEiskugel()} Eiskugeln.");
                break;
                case 5:
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falsche Eingabe");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }

        }
        static void Bier() {
            Console.WriteLine("Welches Bier wollen Sie?: \n1) Malzbier\n2) Weizenbier\n3) zurück");
            int antwort = Convert.ToInt16(Console.ReadLine());
            switch (antwort) {
                case 1:
                Malzbier bierm = new();
                Console.Write("Welche Hefesorte soll ihr Malzbier haben? ");
                bierm.SetHefesorte(Console.ReadLine());
                Console.Write("Welche Hopfensorte soll ihr Malzbier haben? ");
                bierm.SetHopfensorte(Console.ReadLine());
                Console.Write("Welchen Stammwürzegehalt soll ihr Malzbier haben? ");
                bierm.SetStammwuerzegehalt(Convert.ToInt16(Console.ReadLine()));
                Console.Write("Wie hoch soll der Alkoholgehalt sein? ");
                bierm.SetAlkoholgehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write($"Voilá, ihr Malzbier mit der Hefesorte: {bierm.GetHefesorte()}, der Hopfensorte: {bierm.GetHopfensorte()}, dem Stammwürzegehalt: {bierm.GetStammwuerzegehalt()} und dem Alkoholgehalt: {bierm.GetAlkoholgehalt()}");
                break;
                case 2:
                Weizenbier bierw = new();
                Console.Write("Welche Hefesorte soll ihr Malzbier haben? ");
                bierw.SetHefesorte(Console.ReadLine());
                Console.Write("Welche Hopfensorte soll ihr Malzbier haben? ");
                bierw.SetHopfensorte(Console.ReadLine());
                Console.Write("Welchen Stammwürzegehalt soll ihr Malzbier haben? ");
                bierw.SetWeizenmalzgehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Wie hoch soll der Alkoholgehalt sein? ");
                bierw.SetAlkoholgehalt(Convert.ToDouble(Console.ReadLine()));
                Console.Write($"Voilá, ihr Weizenbier mit der Hefesorte: {bierw.GetHefesorte()}, der Hopfensorte: {bierw.GetHopfensorte()}, dem Stammwürzegehalt: {bierw.GetWeizenmalzgehalt()} und dem Alkoholgehalt: {bierw.GetAlkoholgehalt()}");
                break;
                case 3:
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Falsche Eingabe");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }
        }
    }
}