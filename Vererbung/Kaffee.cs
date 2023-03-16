using System.Xml.Linq;

namespace Vererbung {
    internal class Kaffee : Getraenk {
        double koffeingehalt;
        String herkunftsland;
        String bohnensorte;
        public void SetKoffeingehalt(double d) {
            koffeingehalt = d;
        }
        public double GetKoffeingehalt() {
            return koffeingehalt;
        }
        public void SetHerkunftsland(String s) {
            herkunftsland = s;
        }
        public String GetHerkunftsland() {
            return herkunftsland;
        }
        public void SetBohnensorte(String s) {
            bohnensorte = s;
        }
        public String GetBohnensorte() {
            return bohnensorte;
        }
    }
}
